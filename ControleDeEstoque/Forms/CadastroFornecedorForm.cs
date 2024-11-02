using ControleDeEstoque.Models;
using ControleDeEstoque.Services.Interfaces;
using System.Text.RegularExpressions;

namespace ControleDeEstoque.Forms
{

    public partial class CadastroFornecedorForm : Form
    {
        private readonly IFornecedorService _fornecedorService;
        public CadastroFornecedorForm(IFornecedorService fornecedorService)
        {
            InitializeComponent();
            _fornecedorService = fornecedorService ?? throw new ArgumentNullException(nameof(fornecedorService));
        }

        private void CadastroFornecedorForm_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxContatoFornecedor_Leave(object sender, EventArgs e)
        {


            // Retira os caracteres não numéricos para validar o número.
            string contato = maskedTextBoxContatoFornecedor.Text.Trim().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            // Não realiza a validação se o campo estiver vazio.
            if (string.IsNullOrWhiteSpace(contato)) return;

            // Verifica se o número possui o tamanho certo, com 10 ou 11 dígitos.
            if (contato.Length != 10 && contato.Length != 11)
            {
                MessageBox.Show("Número de telefone inválido. O número deve ter 10 ou 11 dígitos.");
                maskedTextBoxContatoFornecedor.Focus();
            }
        }
        private void txtEmailFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas letras, números, '.', '_', '-', '@' e caracteres de controle
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '_' && e.KeyChar != '-' && e.KeyChar != '@')
            {
                e.Handled = true; // Cancela o evento se o caractere não for permitido
            }
        }

        private void maskedTextBoxCEPFornecedor_Leave(object sender, EventArgs e)
        {
            // Confirma se o campo de CEP está completo no formato 00000-000.
            if (!maskedTextBoxCEPFornecedor.MaskFull)
            {
                MessageBox.Show("Por favor, insira um CEP válido no formato 00000-000.");
                maskedTextBoxCEPFornecedor.Focus();
            }
        }

        private void txtNumeroFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas dígitos e controle como Backspace.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela se não for número.
            }
        }

        private void txtNumeroFornecedor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroFornecedor.Text)) return;

            // Verifica se o valor é numérico.
            if (!int.TryParse(txtNumeroFornecedor.Text, out _))
            {
                MessageBox.Show("Por favor, insira um número válido.");
                txtNumeroFornecedor.Focus();
            }
        }

        private void txtEstadoFornecedor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEstadoFornecedor.Text)) return;

            if (txtEstadoFornecedor.Text.Trim().Length != 2)
            {
                MessageBox.Show("Por favor, insira a sigla do estado com 2 letras.");
                txtEstadoFornecedor.Focus();
            }
        }

        private void txtCidadeFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloqueia caracteres diferentes de letras e espaço.
            }
        }

        private void txtCidadeFornecedor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCidadeFornecedor.Text)) return;

            // Aceita letras com acentos e espaço.
            if (!Regex.IsMatch(txtCidadeFornecedor.Text, @"^[a-zA-ZÀ-ÿ\s]+$"))
            {
                MessageBox.Show("Digite um nome de cidade válido.");

            }
        }

        private async void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura os Dados dos TextBoxes
                string nome = txtNomeFornecedor.Text.Trim();
                string contato = maskedTextBoxContatoFornecedor.Text.Trim();
                string email = txtEmailFornecedor.Text.Trim();
                string cep = maskedTextBoxCEPFornecedor.Text.Trim();
                string numero = txtNumeroFornecedor.Text.Trim();
                string estado = txtEstadoFornecedor.Text.Trim();
                string cidade = txtCidadeFornecedor.Text.Trim();
                string complemento = txtComplementoFornecedor.Text.Trim();

                // Validação dos campos
                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(contato) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(cep) ||
                    string.IsNullOrWhiteSpace(numero) || string.IsNullOrWhiteSpace(estado) ||
                    string.IsNullOrWhiteSpace(cidade) || string.IsNullOrWhiteSpace(complemento))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.");
                    return;
                }

                // Validações específicas usando a classe Validator
                if (!Validator.IsValidEmail(email))
                {
                    MessageBox.Show("Por favor, insira um endereço de e-mail válido.");
                    return;
                }

                if (!Validator.IsValidPhoneNumber(contato))
                {
                    MessageBox.Show("Número de telefone inválido. O número deve ter 10 ou 11 dígitos.");
                    return;
                }

                if (!Validator.IsValidCEP(cep))
                {
                    MessageBox.Show("Por favor, insira um CEP válido no formato 00000-000.");
                    return;
                }

                if (!Validator.IsValidState(estado))
                {
                    MessageBox.Show("Por favor, insira a sigla do estado com 2 letras (por exemplo, SP, RJ).");
                    return;
                }

                if (!Validator.IsValidCity(cidade))
                {
                    MessageBox.Show("Digite um nome de cidade válido.");
                    return;
                }

                if (!Validator.IsValidNumber(numero))
                {
                    MessageBox.Show("Por favor, insira um número válido.");
                    return;
                }

                // Cria uma nova instância de Fornecedor
                var fornecedor = new Fornecedor
                {
                    Nome = nome,
                    Contato = contato,
                    Email = email,
                    CEP = cep,
                    Numero = numero,
                    Estado = estado,
                    Cidade = cidade,
                    Complemento = complemento,
                };

                // Salva o fornecedor no banco de dados
                await _fornecedorService.AddFornecedorAsync(fornecedor);

                // Confirmação de sucesso e limpeza do formulário
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro com a exceção interna
                MessageBox.Show("Erro ao salvar o fornecedor: " + ex.Message + "\n\n" + ex.InnerException?.Message);
            }

        }
        private void LimparCampos()
        {
            txtNomeFornecedor.Text = "";
            maskedTextBoxContatoFornecedor.Text = ""; // Limpa o campo de telefone
            txtEmailFornecedor.Text = "";
            maskedTextBoxCEPFornecedor.Text = "";
            txtNumeroFornecedor.Text = "";
            txtEstadoFornecedor.Text = "";
            txtCidadeFornecedor.Text = "";
            txtComplementoFornecedor.Text = "";
        }

        private void btnCancelarFornecedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Mensagem de confirmação para fechar a tela
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

        // Ao apertar enter, passa para o próximo campo
        private void txt_KeyDown(object sender, KeyEventArgs e)
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
