using ControleDeEstoque.Data;
using ControleDeEstoque.Models;
using ControleDeEstoque.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.IO;
using OfficeOpenXml;


namespace ControleDeEstoque.Forms
{
    public partial class NovaVendaForm : Form
    {
        private readonly IItemService _itemService;
        private readonly IClienteService _clienteService;
        private readonly IVendaService _vendaService;
        private readonly ApplicationDbContext _context;

        public NovaVendaForm(IItemService itemService, IClienteService clienteService, IVendaService vendaService, ApplicationDbContext context)
        {
            InitializeComponent();
            _itemService = itemService ?? throw new ArgumentNullException(nameof(itemService));
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
            _vendaService = vendaService ?? throw new ArgumentNullException(nameof(vendaService));
            _context = context;

            dgvItensSelecionados.CellValidating += dgvItensSelecionados_CellValidating;

            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Para uso não comercial



        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza de que deseja cancelar? As informações não salvas serão perdidas.",
                                            "Cancelar",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void NovaVendaForm_Load(object sender, EventArgs e)
        {
            var clientes = _clienteService.ObterTodosClientes();
            cmbCliente.DataSource = clientes.ToList();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Id";

            lstResultadosItens.View = View.Details;
            lstResultadosItens.FullRowSelect = true;
            lstResultadosItens.LabelEdit = true;

            cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;



        }

        private void dgvItensSelecionados_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvItensSelecionados.Columns[e.ColumnIndex].Name == "Quantidade")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int newQuantity) || newQuantity < 1)
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, insira uma quantidade válida (número positivo).");
                }
                else
                {
                    /*var preco = decimal.Parse(dgvItensSelecionados.Rows[e.RowIndex].Cells["Preco"].Value.ToString(), System.Globalization.NumberStyles.Currency);*/
                    AtualizarTotal();
                }
            }

        }
        private void AtualizarTotal()
        {
            decimal totalVenda = 0;

            foreach (DataGridViewRow row in dgvItensSelecionados.Rows)
            {
                if (row.Cells["Preco"].Value != null && row.Cells["Quantidade"].Value != null)
                {
                    decimal preco = decimal.Parse(row.Cells["Preco"].Value.ToString(), System.Globalization.NumberStyles.Currency);
                    int quantidade = int.Parse(row.Cells["Quantidade"].Value.ToString());

                    totalVenda += preco * quantidade;
                }
            }

            txtTotalVenda.Text = totalVenda.ToString("C"); // Formata como moeda
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            lstResultadosItens.Items.Clear();
            var buscaTexto = txtBuscarItem.Text.Trim();
            var itens = _itemService.BuscarItensPorNome(buscaTexto);

            foreach (var item in itens)
            {
                var quantidadeEmEstoque = item.QuantidadeEstoque;
                if (quantidadeEmEstoque > 0)
                {
                    var listViewItem = new ListViewItem(item.Id.ToString())
                    {
                        SubItems = { item.Nome, item.Preco.ToString("C"), quantidadeEmEstoque.ToString() }
                    };
                    lstResultadosItens.Items.Add(listViewItem);
                }
            }
        }


        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {

            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um cliente.");
                return;
            }

            if (lstResultadosItens.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um item para adicionar.");
                return;
            }

            var itemSelecionado = lstResultadosItens.SelectedItems[0];
            var quantidadeEmEstoque = int.Parse(itemSelecionado.SubItems[3].Text);

            // Verifica se o item tem estoque disponível
            if (quantidadeEmEstoque < 1)
            {
                MessageBox.Show("Este item está sem estoque e não pode ser adicionado.");
                return;
            }

            foreach (DataGridViewRow row in dgvItensSelecionados.Rows)
            {
                if (row.Cells["Id"].Value.ToString() == itemSelecionado.SubItems[0].Text)
                {
                    MessageBox.Show("Este item já foi adicionado.");
                    return;
                }
            }

            var precoUnitario = decimal.Parse(itemSelecionado.SubItems[2].Text, System.Globalization.NumberStyles.Currency);
            var quantidade = 1;

            dgvItensSelecionados.Rows.Add(
                itemSelecionado.SubItems[0].Text, // Id
                itemSelecionado.SubItems[1].Text, // Nome
                precoUnitario.ToString("C"), // Preço formatado
                quantidade.ToString() // Quantidade
            );

            AtualizarTotal();

        }





        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {

            if (cmbCliente.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um cliente.");
                return;
            }

            if (dgvItensSelecionados.Rows.Count == 0)
            {
                MessageBox.Show("Adicione itens à venda antes de finalizar.");
                return;
            }

            if (cmbMetodoPagamento.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um método de pagamento.");
                return;
            }


            var venda = new Venda
            {
                ClienteId = (int)cmbCliente.SelectedValue,
                Data = DateTime.Now,
                MetodoDePagamento = cmbMetodoPagamento.Text,
            };

            decimal valorTotal = 0; // Inicializa a variável valorTotal
            bool quantidadeSuficiente = true;

            try
            {



                foreach (DataGridViewRow row in dgvItensSelecionados.Rows)
                {
                    if (row.Cells["Id"].Value != null && row.Cells["Quantidade"].Value != null)
                    {
                        var itemId = int.Parse(row.Cells["Id"].Value.ToString());
                        var quantidadeVendida = int.Parse(row.Cells["Quantidade"].Value.ToString());
                        var precoUnitario = decimal.Parse(row.Cells["Preco"].Value.ToString(), System.Globalization.NumberStyles.Currency);

                        var item = _context.Itens.SingleOrDefault(i => i.Id == itemId);

                        if (item != null)
                        {
                            if (item.QuantidadeEstoque >= quantidadeVendida)
                            {
                                item.QuantidadeEstoque -= quantidadeVendida;
                                venda.AdicionarItem(itemId, quantidadeVendida, precoUnitario);

                                // Acumula o valor total
                                valorTotal += precoUnitario;
                            }
                            else
                            {
                                MessageBox.Show($"Estoque insuficiente para o item '{item.Nome}'. Estoque disponível: {item.QuantidadeEstoque}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                quantidadeSuficiente = false;
                                break;
                            }
                        }
                    }
                }

                if (quantidadeSuficiente)
                {
                    _vendaService.SalvarVenda(venda);
                    _context.SaveChanges();  // Salva as mudanças no contexto (atualização do estoque)

                    var cliente = new Cliente();

                    // Gera o arquivo de texto com os detalhes da venda, passando o valor total corretamente
                    GerarArquivoVenda(cliente: _context.Clientes.Find(venda.ClienteId), venda, valorTotal);

                    MessageBox.Show("Venda finalizada com sucesso!");


                    LimparFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao finalizar venda: {ex.Message}\n{ex.InnerException?.Message}");
            }

        }

        // Método para gerar o arquivo com as informações da venda
        // Método para gerar o arquivo com as informações da venda
        private void GerarArquivoVenda(Cliente cliente, Venda venda, decimal valorTotal)
        {
            string pastaDownloads = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string caminhoArquivo = Path.Combine(pastaDownloads, $"Venda_{venda.Data:yyyyMMdd_HHmmss}.txt");

            using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
            {
                writer.WriteLine("Informações da Venda");
                writer.WriteLine($"Venda ID: {venda.Id}");
                writer.WriteLine($"Data: {venda.Data}");
                writer.WriteLine($"Cliente: {cliente.Nome}   Contato: {cliente.Contato}");
                writer.WriteLine($"Método de Pagamento: {venda.MetodoDePagamento}");
                writer.WriteLine(new string('-', 30));

                writer.WriteLine("Itens Vendidos:");
                foreach (var item in venda.ItensVendidos)
                {
                    var itemInfo = _context.Itens.Find(item.ItemId);
                    writer.WriteLine($"\n- Nome: {itemInfo.Nome}");
                    writer.WriteLine($"  Quantidade: {item.Quantidade}");
                    writer.WriteLine($"  Preço Unitário: {item.PrecoUnitario:C}");
                    writer.WriteLine($"  Total: {item.PrecoUnitario * item.Quantidade:C}"); // Este valor está correto
                }

                writer.WriteLine(new string('-', 30));
                writer.WriteLine($"Valor Total da Venda: {valorTotal:C}");
            }

            MessageBox.Show($"Arquivo de venda gerado em: {caminhoArquivo}", "Arquivo Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abrir o arquivo gerado
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = caminhoArquivo,
                UseShellExecute = true // Necessário para abrir arquivos com o programa padrão do sistema
            });
        }



        private void txtBuscarItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica se a tecla pressionada é Enter
            {
                e.SuppressKeyPress = true; // Suprime o som de "ping" do beep
                btnBuscarItem_Click(sender, e); // Chama o método de busca
            }
        }


        private void AtualizarTotalVenda()
        {
            decimal total = 0;

            // Itera sobre as linhas da DataGridView para calcular o total
            foreach (DataGridViewRow row in dgvItensSelecionados.Rows)
            {
                if (row.Cells["Preco"].Value != null &&
                    decimal.TryParse(row.Cells["Preco"].Value.ToString(), System.Globalization.NumberStyles.Currency, null, out decimal preco) &&
                    row.Cells["Quantidade"].Value != null &&
                    int.TryParse(row.Cells["Quantidade"].Value.ToString(), out int quantidade))
                {
                    total += preco * quantidade; // Adiciona ao total
                }
            }

            // Atualiza o TextBox com o total formatado
            txtTotalVenda.Text = total.ToString("C"); // Formato de moeda
        }

        private void dgvItensSelecionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula clicada é da coluna do botão e se não é a nova linha
            if (e.ColumnIndex == dgvItensSelecionados.Columns["btnRemover"].Index && e.RowIndex >= 0)
            {
                // Remove a linha clicada
                dgvItensSelecionados.Rows.RemoveAt(e.RowIndex);

                // Atualiza o total após remover o item
                AtualizarTotalVenda();
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue != null)
            {
                var clienteId = cmbCliente.SelectedValue; // Obter o Id do cliente selecionado
                                                          // Você pode fazer algo com o cliente selecionado aqui, se necessário
            }
        }

        private void cmbCliente_RegionChanged(object sender, EventArgs e)
        {
            var textoPesquisa = cmbCliente.Text.Trim();
            var clientesFiltrados = _clienteService.ObterTodosClientes()
                .Where(c => c.Nome.Contains(textoPesquisa, StringComparison.OrdinalIgnoreCase))
                .ToList();

            cmbCliente.DataSource = clientesFiltrados; // Atualiza o DataSource com os resultados filtrados
            cmbCliente.Invalidate(); // Atualiza o ComboBox
        }

        private void cmbCliente_Validating(object sender, CancelEventArgs e)
        {
            // Obtém o valor digitado no ComboBox
            var textoCliente = cmbCliente.Text.Trim();

            // Verifica se existe um cliente correspondente
            var clienteExistente = _clienteService.ObterTodosClientes()
                .Any(c => c.Nome.Equals(textoCliente, StringComparison.OrdinalIgnoreCase));

            if (!clienteExistente)
            {
                MessageBox.Show("O cliente digitado não está cadastrado.", "Cliente Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Cancel = true; // Impede que o foco saia do ComboBox
            }
        }

        private void LimparFormulario()
        {
            // Limpa o ComboBox de cliente, definindo-o para o valor padrão
            cmbCliente.SelectedIndex = -1;

            // Limpa o campo de busca de item
            txtBuscarItem.Clear();

            // Limpa o DataGridView de itens selecionados
            dgvItensSelecionados.Rows.Clear();

            // Reseta o total da venda
            txtTotalVenda.Text = "0,00";

            // Redefine o campo de data (opcional, se deseja usar a data atual)
            dtpDataVenda.Value = DateTime.Now;

            // Limpa o campo do método de pagamento, definindo-o para o valor padrão
            cmbMetodoPagamento.SelectedIndex = -1;
        }


        private decimal CalcularValorTotal()
        {
            decimal total = 0;

            // Verifica se o DataGridView tem dados
            if (cmbMetodoPagamento.DataSource is List<Item> itens)
            {
                foreach (var item in itens)
                {
                    // Supondo que a classe Item tem uma propriedade Preco e Quantidade
                    total += item.Preco * item.QuantidadeEstoque; // Ajuste aqui conforme suas propriedades
                }
            }

            return total;
        }

        private void dgvItensSelecionados_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a edição foi na coluna de quantidade
            if (e.ColumnIndex == dgvItensSelecionados.Columns["Quantidade"].Index)
            {
                var row = dgvItensSelecionados.Rows[e.RowIndex];
                int quantidadeSelecionada;

                // Tenta converter o valor da célula para um número
                if (int.TryParse(row.Cells["Quantidade"].Value.ToString(), out quantidadeSelecionada))
                {
                    // Obtém a quantidade em estoque a partir da lista de resultados de itens
                    int quantidadeEmEstoque = ObterQuantidadeEstoque(int.Parse(row.Cells["Id"].Value.ToString()));

                    // Verifica se a quantidade selecionada é maior que a disponível em estoque
                    if (quantidadeSelecionada > quantidadeEmEstoque)
                    {
                        MessageBox.Show($"Quantidade selecionada maior do que o estoque disponível ({quantidadeEmEstoque}).", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells["Quantidade"].Value = quantidadeEmEstoque; // Define a quantidade máxima permitida
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número válido para a quantidade.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    row.Cells["Quantidade"].Value = 1; // Define a quantidade mínima permitida
                }

                AtualizarTotal(); // Atualiza o total após a mudança de quantidade
            }
        }

        private int ObterQuantidadeEstoque(int itemId)
        {
            // Método para obter a quantidade em estoque com base no ID do item
            // Pode ser adaptado para buscar do banco de dados ou de uma lista de itens carregada
            foreach (ListViewItem item in lstResultadosItens.Items)
            {
                if (int.Parse(item.SubItems[0].Text) == itemId)
                {
                    return int.Parse(item.SubItems[3].Text); // Retorna a quantidade em estoque
                }
            }
            return 0;
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }




}

