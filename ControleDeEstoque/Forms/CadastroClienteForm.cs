using ControleDeEstoque.Models;
using ControleDeEstoque.Services.Interfaces;

namespace ControleDeEstoque.Forms
{
    public partial class CadastroClienteForm : Form
    {
        private readonly IClienteService _clienteService;

        public CadastroClienteForm(IClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
        }

        private void CadastroClienteForm_Load(object sender, EventArgs e)
        {
            // Carregamentos iniciais, se necessário
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura os Dados dos TextBoxes
                string nome = txtNome.Text.Trim();
                string contato = maskedTextBoxContato.Text.Trim(); // Utiliza o maskedTextBox
                string email = txtEmail.Text.Trim();
                string cep = maskedTextBoxCEP.Text.Trim();
                string numero = txtNumero.Text.Trim();
                string estado = txtEstado.Text.Trim();
                string cidade = txtCidade.Text.Trim();
                string complemento = txtComplemento.Text.Trim();

                // Validações
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

                // Cria uma Instância de Cliente
                var cliente = new Cliente
                {
                    Nome = nome,
                    Contato = contato,
                    Email = email,
                    CEP = cep,
                    Numero = numero,
                    Estado = estado,
                    Cidade = cidade,
                    Complemento = complemento
                };

                // Salvar no Banco de Dados
                await _clienteService.AddClienteAsync(cliente);

                // Confirmar e Limpar o Formulário
                MessageBox.Show("Cliente cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                // Exibe a mensagem de erro com a exceção interna
                MessageBox.Show("Erro ao salvar o cliente: " + ex.Message + "\n\n" + ex.InnerException?.Message);
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            maskedTextBoxContato.Text = ""; // Limpa o campo de telefone
            txtEmail.Text = "";
            maskedTextBoxCEP.Text = "";
            txtNumero.Text = "";
            txtEstado.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
        }

        // Evento do botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void maskedTextBoxContato_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e o caractere de controle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela o evento se o caractere não for um número
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas letras, números, '.', '_', '-', '@' e caracteres de controle
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '_' && e.KeyChar != '-' && e.KeyChar != '@')
            {
                e.Handled = true; // Cancela o evento se o caractere não for permitido
            }
        }

        private void maskedTextBoxCEP_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxCEP.Text))
            {
                // Não realiza a validação se o campo estiver vazio.
                return;
            }
            // Verifica se o campo de CEP está completo (9 caracteres no formato "00000-000")
            if (maskedTextBoxCEP.Text.Length != 9 || !maskedTextBoxCEP.MaskFull)
            {
                MessageBox.Show("Por favor, insira um CEP válido no formato 00000-000.", "CEP Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBoxCEP.Focus();
            }
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            // Verifica se o campo Estado tem exatamente 2 caracteres
            if (!Validator.IsValidState(txtEstado.Text.Trim()))
            {
                MessageBox.Show("Por favor, insira a sigla do estado com 2 letras (por exemplo, SP, RJ).", "Estado Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstado.Focus();
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e o uso da tecla de controle Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia caracteres que não sejam numéricos
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                // Não realiza a validação se o campo estiver vazio.
                return;
            }
            // Verifica se o campo está vazio ou com valor inválido
            if (!Validator.IsValidNumber(txtNumero.Text.Trim()))
            {
                MessageBox.Show("Por favor, insira um número válido.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
            }
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            // Verifica se o campo cidade está vazio ou inválido
            if (!Validator.IsValidCity(txtCidade.Text.Trim()))
            {
                MessageBox.Show("Digite um nome de cidade válido.", "Cidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCidade.Focus();
            }
        }
    }
}
