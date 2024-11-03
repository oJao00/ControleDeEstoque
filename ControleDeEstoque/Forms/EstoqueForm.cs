using ControleDeEstoque.Data;
using ControleDeEstoque.Services;
using ControleDeEstoque.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque.Forms
{

    public partial class EstoqueForm : Form
    {
        private readonly IItemService _itemService;
        public EstoqueForm(IItemService itemService)
        {
            InitializeComponent();
            _itemService = itemService ?? throw new ArgumentNullException(nameof(itemService));
        }

        private void EstoqueForm_Load(object sender, EventArgs e)
        {

            dgvEstoque.AutoGenerateColumns = false; // Desativar geração automática de colunas
            dgvEstoque.Columns.Clear(); // Limpar qualquer coluna previamente gerada

            // Definir manualmente as colunas que deseja exibir
            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 10,
            });
            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nome",
                HeaderText = "Nome",
                DataPropertyName = "Nome",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 100
            });
            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Preco",
                HeaderText = "Preço",
                DataPropertyName = "Preco",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }, // Formatação de moeda
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 30
            });
            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Quantidade",
                HeaderText = "Quantidade",
                DataPropertyName = "QuantidadeEstoque",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 30
            });

            // Carregar dados no DataGridView
            CarregarTodosItens();

        }



        private void CarregarTodosItens()
        {
            var itens = _itemService.ObterTodosItens();
            dgvEstoque.DataSource = itens;
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            string termoBusca = txtBusca.Text.Trim();

            if (string.IsNullOrEmpty(termoBusca))
            {
                // Carregar todos os itens se o campo de busca estiver vazio
                CarregarTodosItens();
            }
            else
            {
                // Pesquisar itens pelo nome
                dgvEstoque.DataSource = _itemService.ObterItensPorNome(termoBusca);
            }
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvEstoque.Rows)
                {
                    if (row.IsNewRow) continue;

                    int itemId = (int)row.Cells["Id"].Value;
                    decimal preco = decimal.Parse(row.Cells["Preco"].Value.ToString());
                    int quantidade = int.Parse(row.Cells["Quantidade"].Value.ToString());

                    var item = _itemService.ObterItemPorId(itemId);
                    if (item != null)
                    {
                        item.Preco = preco;
                        item.QuantidadeEstoque = quantidade;
                        _itemService.AtualizarItem(item);
                    }
                }

                MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarTodosItens();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar alterações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            // Define o limite para considerar um item como "baixo estoque"
            int limiteBaixoEstoque = 10; // ajuste conforme necessário

            // Obtém os itens com baixo estoque
            var itensBaixoEstoque = _itemService.ObterItensComBaixoEstoque(limiteBaixoEstoque);

            // Define o caminho para o arquivo na pasta "Downloads"
            string pastaDownloads = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string caminhoArquivo = Path.Combine(pastaDownloads, $"Relatorio_BaixoEstoque_{DateTime.Now:yyyyMMdd_HHmmss}.txt");

            // Gera o conteúdo do arquivo
            using (StreamWriter writer = new StreamWriter(caminhoArquivo, false))
            {
                writer.WriteLine("Relatório de Itens com Baixo Estoque");
                writer.WriteLine($"Data: {DateTime.Now}");
                writer.WriteLine(new string('-', 30));

                if (itensBaixoEstoque.Count == 0)
                {
                    writer.WriteLine("Nenhum item com baixo estoque.");
                }
                else
                {
                    foreach (var item in itensBaixoEstoque)
                    {
                        writer.WriteLine($"ID: {item.Id}");
                        writer.WriteLine($"Nome: {item.Nome}");
                        writer.WriteLine($"Preço: {item.Preco:C}");
                        writer.WriteLine($"Quantidade em Estoque: {item.QuantidadeEstoque}");
                        writer.WriteLine(new string('-', 30));
                    }
                }
            }

            // Mostra uma mensagem para o usuário indicando onde o arquivo foi salvo
            MessageBox.Show($"Relatório gerado em: {caminhoArquivo}", "Relatório de Baixo Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = caminhoArquivo,
                UseShellExecute = true // Necessário para abrir arquivos com o programa padrão do sistema
            });
        }

    }
}

