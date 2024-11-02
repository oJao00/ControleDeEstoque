using ControleDeEstoque.Models;
using ControleDeEstoque.Services.Interfaces;

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

        private void InicializarCampos()
        {
            txtProduto.Text = string.Empty;
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
            if (string.IsNullOrWhiteSpace(txtProduto.Text))
            {
                MessageBox.Show("O campo Produto é obrigatório.");
                txtProduto.Focus();
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

                    var producao = new Producao
                    {
                        Produto = txtProduto.Text.Trim(),
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
            txtProduto.Clear();
            dtpDataProducao.Value = DateTime.Now;
            nudQuantidadeProduzida.Value = 0;
            nudQuantidadePerdida.Value = 0;
            txtCondicoesAmbientais.Clear();
            txtMetodoProducao.Clear();
            txtEquipamentoUtilizado.Clear();
            txtObservacoes.Clear();
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

        private void btnCancelarProducao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroProducaoForm_Load(object sender, EventArgs e)
        {
            InicializarCampos();
        }
    }
}
