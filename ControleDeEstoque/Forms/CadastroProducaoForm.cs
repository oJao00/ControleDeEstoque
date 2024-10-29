using ControleDeEstoque.Models;
using ControleDeEstoque.Services;
using ControleDeEstoque.Services.Interfaces;
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
    public partial class CadastroProducaoForm : Form
    {
        private readonly IProducaoService _producaoService;
        private readonly IItemService _itemService;
        public CadastroProducaoForm(IProducaoService producaoService, IItemService itemService)
        {
            InitializeComponent();
            _producaoService = producaoService ?? throw new ArgumentNullException(nameof(producaoService));
            _itemService = itemService ?? throw new ArgumentNullException(nameof(itemService));

        }

        private async void CadastroProducaoForm_Load(object sender, EventArgs e)
        {
            await CarregarProdutos(); // Chama o método assíncrono para carregar produtos
        }
        private async Task CarregarProdutos()
        {
            var produtos = await _itemService.GetAllItemsAsync(); // Método que busca todos os itens
            cmbProduto.DataSource = produtos; // Definindo a fonte de dados do ComboBox
            cmbProduto.DisplayMember = "Nome"; // O que será exibido no ComboBox
            cmbProduto.ValueMember = "Id"; // O valor associado
        }
        private void InicializarCampos()
        {
            cmbProduto.Text = string.Empty;
            dtpDataProducao.Value = DateTime.Now;
            nudQuantidadeProduzida.Value = 0;
            nudQuantidadePerdida.Value = 0;
            txtCondicoesAmbientais.Text = string.Empty;
            txtMetodoProducao.Text = string.Empty;
            txtEquipamentoUtilizado.Text = string.Empty;
            txtObservacoes.Text = string.Empty;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(cmbProduto.Text))
            {
                MessageBox.Show("O campo Produto é obrigatório.");
                cmbProduto.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCondicoesAmbientais.Text))
            {
                MessageBox.Show("O campo Condições Ambientais é obrigatório.");
                txtCondicoesAmbientais.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMetodoProducao.Text))
            {
                MessageBox.Show("O campo Método de Produção é obrigatório.");
                txtMetodoProducao.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEquipamentoUtilizado.Text))
            {
                MessageBox.Show("O campo Equipamento Utilizado é obrigatório.");
                txtEquipamentoUtilizado.Focus();
                return false;
            }
            return true;
        }

        private async void btnSalvarProducao_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    // Presumindo que você tenha um ComboBox chamado cmbProduto
                    var itemSelecionado = (Item)cmbProduto.SelectedItem; // Obtendo o Item selecionado

                    var producao = new Producao
                    {
                        Produto = itemSelecionado, // Atribuindo o objeto Item
                        DataDeProducao = dtpDataProducao.Value,
                        QuantidadeProduzida = (int)nudQuantidadeProduzida.Value,
                        QuantidadePerdida = (int)nudQuantidadePerdida.Value,
                        CondicoesAmbientais = txtCondicoesAmbientais.Text.Trim(),
                        MetodoDeProducao = txtMetodoProducao.Text.Trim(),
                        EquipamentoUtilizado = txtEquipamentoUtilizado.Text.Trim(),
                        Observacoes = txtObservacoes.Text.Trim()
                    };

                    await _producaoService.AddProducaoAsync(producao);
                    MessageBox.Show("Produção cadastrada com sucesso!");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar a produção: " + ex.Message);
                }
            }
        }

        private void LimparCampos()
        {
            dtpDataProducao.Value = DateTime.Now;
            nudQuantidadeProduzida.Value = 0;
            nudQuantidadePerdida.Value = 0;
            txtCondicoesAmbientais.Clear();
            txtMetodoProducao.Clear();
            txtEquipamentoUtilizado.Clear();
            txtObservacoes.Clear();
        }

        private void btnCancelarProducao_Click(object sender, EventArgs e)
        {
            this.Close();
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

    }
}
