using ControleDeEstoque.Services.Interfaces;
using ControleDeEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControleDeEstoque.Forms
{
    public partial class CadastroItemForm : Form
    {
        // Serviços utilizados
        private readonly IItemService _itemService;
        private readonly IFornecedorService _fornecedorService;

        // Construtor do Formulário
        public CadastroItemForm(IItemService itemService, IFornecedorService fornecedorService)
        {
            InitializeComponent();
            _itemService = itemService ?? throw new ArgumentNullException(nameof(itemService));
            _fornecedorService = fornecedorService ?? throw new ArgumentNullException(nameof(fornecedorService));

            // Configurações iniciais
            txtPreco.Leave += txtPreco_Leave;
            txtPreco.KeyPress += txtPreco_KeyPress;
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        // Eventos de Teclado
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e o separador decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Permite apenas um ponto decimal
            if (e.KeyChar == '.' && txtPreco.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        // Formatar TextBox de Preço ao perder o foco
        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPreco.Text, out decimal valor))
            {
                txtPreco.Text = valor.ToString("C2"); // Formata como moeda
            }
        }

        // Método para obter a descrição da categoria
        public static string GetEnumDescription(CategoriaItem categoria)
        {
            return categoria switch
            {
                CategoriaItem.GraosECereais => "Grãos e Cereais",
                CategoriaItem.LegumesEVegetais => "Legumes e Vegetais",
                CategoriaItem.Frutas => "Frutas",
                CategoriaItem.ProdutosLacteos => "Produtos Lácteos",
                CategoriaItem.CarnesEAves => "Carnes e Aves",
                CategoriaItem.SementesEMudas => "Sementes e Mudas",
                CategoriaItem.FerramentasEEquipamentos => "Ferramentas e Equipamentos",
                CategoriaItem.AdubosEFertilizantes => "Adubos e Fertilizantes",
                CategoriaItem.RacoesESuplementos => "Raçōes e Suplementos",
                _ => categoria.ToString() // Para outros casos, retorna o nome original
            };
        }

        // Evento de carregamento do Formulário
        private async void CadastroItemForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Carrega os fornecedores
                var fornecedores = await _fornecedorService.GetAllFornecedoresAsync();

                comboFornecedor.DataSource = fornecedores;
                comboFornecedor.DisplayMember = "Nome"; // Nome exibido
                comboFornecedor.ValueMember = "Id"; // ID do fornecedor

                // Carrega as categorias no ComboBox
                comboCategoria.DataSource = Enum.GetValues(typeof(CategoriaItem))
                                         .Cast<CategoriaItem>()
                                         .Select(c => GetEnumDescription(c))
                                         .ToList();

                if (fornecedores.Count == 0)
                {
                    MessageBox.Show("Nenhum fornecedor encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
            }
        }

        // Evento do botão Salvar
        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura os dados dos TextBoxes
                string nome = txtNome.Text.Trim();
                string categoriaSelecionada = comboCategoria.SelectedItem?.ToString();
                decimal preco;
                int quantidadeEstoque;
                int fornecedorId = (int)comboFornecedor.SelectedValue; // Assumindo que o ComboBox possui uma lista de fornecedores com IDs

                // Validações
                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(categoriaSelecionada))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.");
                    return;
                }

                // Remove R$ e espaços para validação do preço
                string precoString = txtPreco.Text.Replace("R$", "").Replace(" ", "").Trim();
                if (!decimal.TryParse(precoString, out preco) || preco < 0)
                {
                    MessageBox.Show("Digite um preço válido.");
                    return;
                }

                if (!int.TryParse(txtQuantidadeEstoque.Text, out quantidadeEstoque) || quantidadeEstoque < 0)
                {
                    MessageBox.Show("Digite uma quantidade válida.");
                    return;
                }

                // Obter o valor da enumeração correspondente
                var categoria = Enum.GetValues(typeof(CategoriaItem))
                                    .Cast<CategoriaItem>()
                                    .FirstOrDefault(c => GetEnumDescription(c) == categoriaSelecionada);

                if (categoria == 0 && categoriaSelecionada != GetEnumDescription(CategoriaItem.GraosECereais)) // Verifica se não encontrou
                {
                    MessageBox.Show("Categoria não encontrada.");
                    return;
                }

                // Cria uma instância de Item
                var item = new Item
                {
                    Nome = nome,
                    Categoria = categoria,
                    Preco = preco,
                    QuantidadeEstoque = quantidadeEstoque,
                    FornecedorId = fornecedorId
                };

                // Salvar no Banco de Dados
                await _itemService.AddItemAsync(item);

                // Confirmar e limpar o formulário
                MessageBox.Show("Item cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o item: " + ex.Message);
            }
        }


        // Método para limpar os campos do formulário
        private void LimparCampos()
        {
            txtNome.Text = "";
            comboCategoria.SelectedIndex = -1;
            txtPreco.Text = "";
            txtQuantidadeEstoque.Text = "";
            comboFornecedor.SelectedIndex = -1;
        }

        // Evento do botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
                this.Close();      
        }

        //Mensagem de confirmação para fechar a tela
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja cancelar? Todas as alterações não salvas serão perdidas.",
                                          "Cancelar",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancela o fechamento se o usuário clicar em 'Não'
            }
        }

        //Ao apertar enter passa para o próximo
        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Impede o "beep" do Enter
                // Mover o foco para o próximo controle
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void txtPreco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Impede o "beep" do Enter
                // Mover o foco para o próximo controle
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void txtQuantidadeEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Impede o "beep" do Enter
                // Mover o foco para o próximo controle
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
