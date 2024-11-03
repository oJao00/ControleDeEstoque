using ControleDeEstoque.Data;
using ControleDeEstoque.Models;
using ControleDeEstoque.Services;
using ControleDeEstoque.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ControleDeEstoque.Forms
{
    public partial class ConsultarVendasForm : Form
    {
        private readonly IVendaService _vendaService;
        private readonly ApplicationDbContext _context;
        public ConsultarVendasForm(ApplicationDbContext context, IVendaService vendaService)
        {
            InitializeComponent();
            _vendaService = vendaService ?? throw new ArgumentNullException(nameof(vendaService));

            _context = context;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime dataPesquisa = dtpData.Value.Date; // Usa o valor do DateTimePicker

            // Limpa os resultados anteriores
            dgvVendas.Rows.Clear();

            // Busca vendas na data especificada
            var vendas = _vendaService.ObterVendasPorData(dataPesquisa);

            foreach (var venda in vendas)
            {
                var cliente = _vendaService.ObterClientePorId(venda.ClienteId);
                dgvVendas.Rows.Add(venda.Id, cliente.Nome, venda.ValorTotal, venda.Data);
            }
        }

        private void ConsultarVendasForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {
            if (dgvVendas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma venda para gerar o arquivo.");
                return;
            }

            var vendaSelecionada = dgvVendas.SelectedRows[0];
            int vendaId = (int)vendaSelecionada.Cells["Id"].Value;
            var venda = _vendaService.ObterVendaPorId(vendaId);
            var cliente = _vendaService.ObterClientePorId(venda.ClienteId);

            // Gere o arquivo com as informações da venda
            GerarArquivoVenda(cliente, venda, venda.ValorTotal);
        }

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


    }
}
