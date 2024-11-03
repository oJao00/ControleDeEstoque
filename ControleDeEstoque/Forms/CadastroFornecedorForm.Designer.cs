namespace ControleDeEstoque.Forms
{
    partial class CadastroFornecedorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFornecedorForm));
            maskedTextBoxContatoFornecedor = new MaskedTextBox();
            txtComplementoFornecedor = new TextBox();
            lblComplemento = new Label();
            txtCidadeFornecedor = new TextBox();
            lblCidade = new Label();
            txtEstadoFornecedor = new TextBox();
            lblEstado = new Label();
            txtNumeroFornecedor = new TextBox();
            lblNumero = new Label();
            lblEndereco = new Label();
            lblCep = new Label();
            btnCancelarFornecedor = new Button();
            btnSalvarFornecedor = new Button();
            txtEmailFornecedor = new TextBox();
            lblEmail = new Label();
            lblContato = new Label();
            txtNomeFornecedor = new TextBox();
            lblNome = new Label();
            maskedTextBoxCEPFornecedor = new MaskedTextBox();
            SuspendLayout();
            // 
            // maskedTextBoxContatoFornecedor
            // 
            maskedTextBoxContatoFornecedor.Location = new Point(158, 67);
            maskedTextBoxContatoFornecedor.Mask = "(00)00000-0000";
            maskedTextBoxContatoFornecedor.Name = "maskedTextBoxContatoFornecedor";
            maskedTextBoxContatoFornecedor.Size = new Size(250, 23);
            maskedTextBoxContatoFornecedor.TabIndex = 59;
            maskedTextBoxContatoFornecedor.Leave += maskedTextBoxContatoFornecedor_Leave;
            // 
            // txtComplementoFornecedor
            // 
            txtComplementoFornecedor.Location = new Point(158, 279);
            txtComplementoFornecedor.Name = "txtComplementoFornecedor";
            txtComplementoFornecedor.Size = new Size(250, 23);
            txtComplementoFornecedor.TabIndex = 57;
            // 
            // lblComplemento
            // 
            lblComplemento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComplemento.Location = new Point(58, 279);
            lblComplemento.Margin = new Padding(0);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(95, 23);
            lblComplemento.TabIndex = 56;
            lblComplemento.Text = "Endereço";
            lblComplemento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCidadeFornecedor
            // 
            txtCidadeFornecedor.Location = new Point(158, 235);
            txtCidadeFornecedor.Name = "txtCidadeFornecedor";
            txtCidadeFornecedor.Size = new Size(88, 23);
            txtCidadeFornecedor.TabIndex = 55;
            txtCidadeFornecedor.KeyPress += txtCidadeFornecedor_KeyPress;
            txtCidadeFornecedor.Leave += txtCidadeFornecedor_Leave;
            // 
            // lblCidade
            // 
            lblCidade.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCidade.Location = new Point(58, 235);
            lblCidade.Margin = new Padding(0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(57, 23);
            lblCidade.TabIndex = 54;
            lblCidade.Text = "Cidade";
            lblCidade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEstadoFornecedor
            // 
            txtEstadoFornecedor.CharacterCasing = CharacterCasing.Upper;
            txtEstadoFornecedor.Location = new Point(364, 235);
            txtEstadoFornecedor.MaxLength = 2;
            txtEstadoFornecedor.Name = "txtEstadoFornecedor";
            txtEstadoFornecedor.Size = new Size(44, 23);
            txtEstadoFornecedor.TabIndex = 53;
            txtEstadoFornecedor.Leave += txtEstadoFornecedor_Leave;
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(295, 235);
            lblEstado.Margin = new Padding(0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 23);
            lblEstado.TabIndex = 52;
            lblEstado.Text = "Estado";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNumeroFornecedor
            // 
            txtNumeroFornecedor.Location = new Point(364, 191);
            txtNumeroFornecedor.MaxLength = 5;
            txtNumeroFornecedor.Name = "txtNumeroFornecedor";
            txtNumeroFornecedor.Size = new Size(44, 23);
            txtNumeroFornecedor.TabIndex = 51;
            txtNumeroFornecedor.KeyPress += txtNumeroFornecedor_KeyPress;
            txtNumeroFornecedor.Leave += txtNumeroFornecedor_Leave;
            // 
            // lblNumero
            // 
            lblNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(295, 191);
            lblNumero.Margin = new Padding(0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 23);
            lblNumero.TabIndex = 50;
            lblNumero.Text = "Número";
            lblNumero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(211, 161);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(63, 17);
            lblEndereco.TabIndex = 49;
            lblEndereco.Text = "Endereço";
            // 
            // lblCep
            // 
            lblCep.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCep.Location = new Point(60, 191);
            lblCep.Margin = new Padding(0);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(50, 23);
            lblCep.TabIndex = 48;
            lblCep.Text = "CEP";
            lblCep.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCancelarFornecedor
            // 
            btnCancelarFornecedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarFornecedor.Location = new Point(252, 334);
            btnCancelarFornecedor.Name = "btnCancelarFornecedor";
            btnCancelarFornecedor.Size = new Size(100, 30);
            btnCancelarFornecedor.TabIndex = 47;
            btnCancelarFornecedor.Text = "Cancelar";
            btnCancelarFornecedor.UseVisualStyleBackColor = true;
            btnCancelarFornecedor.Click += btnCancelarFornecedor_Click;
            // 
            // btnSalvarFornecedor
            // 
            btnSalvarFornecedor.BackColor = SystemColors.ControlLight;
            btnSalvarFornecedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarFornecedor.Location = new Point(132, 334);
            btnSalvarFornecedor.Name = "btnSalvarFornecedor";
            btnSalvarFornecedor.Size = new Size(100, 30);
            btnSalvarFornecedor.TabIndex = 46;
            btnSalvarFornecedor.Text = "Salvar";
            btnSalvarFornecedor.UseVisualStyleBackColor = false;
            btnSalvarFornecedor.Click += btnSalvarFornecedor_Click;
            // 
            // txtEmailFornecedor
            // 
            txtEmailFornecedor.Location = new Point(158, 117);
            txtEmailFornecedor.Name = "txtEmailFornecedor";
            txtEmailFornecedor.Size = new Size(250, 23);
            txtEmailFornecedor.TabIndex = 45;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(58, 117);
            lblEmail.Margin = new Padding(0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 23);
            lblEmail.TabIndex = 44;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblContato
            // 
            lblContato.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContato.Location = new Point(58, 67);
            lblContato.Margin = new Padding(0);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(80, 23);
            lblContato.TabIndex = 43;
            lblContato.Text = "Contato";
            lblContato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNomeFornecedor
            // 
            txtNomeFornecedor.Location = new Point(158, 17);
            txtNomeFornecedor.Name = "txtNomeFornecedor";
            txtNomeFornecedor.Size = new Size(250, 23);
            txtNomeFornecedor.TabIndex = 42;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(58, 17);
            lblNome.Margin = new Padding(0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(80, 23);
            lblNome.TabIndex = 41;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // maskedTextBoxCEPFornecedor
            // 
            maskedTextBoxCEPFornecedor.Location = new Point(158, 193);
            maskedTextBoxCEPFornecedor.Mask = "00000-000";
            maskedTextBoxCEPFornecedor.Name = "maskedTextBoxCEPFornecedor";
            maskedTextBoxCEPFornecedor.Size = new Size(88, 23);
            maskedTextBoxCEPFornecedor.TabIndex = 58;
            maskedTextBoxCEPFornecedor.Leave += maskedTextBoxCEPFornecedor_Leave;
            // 
            // CadastroFornecedorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 381);
            Controls.Add(maskedTextBoxContatoFornecedor);
            Controls.Add(txtComplementoFornecedor);
            Controls.Add(lblComplemento);
            Controls.Add(txtCidadeFornecedor);
            Controls.Add(lblCidade);
            Controls.Add(txtEstadoFornecedor);
            Controls.Add(lblEstado);
            Controls.Add(txtNumeroFornecedor);
            Controls.Add(lblNumero);
            Controls.Add(lblEndereco);
            Controls.Add(lblCep);
            Controls.Add(btnCancelarFornecedor);
            Controls.Add(btnSalvarFornecedor);
            Controls.Add(txtEmailFornecedor);
            Controls.Add(lblEmail);
            Controls.Add(lblContato);
            Controls.Add(txtNomeFornecedor);
            Controls.Add(lblNome);
            Controls.Add(maskedTextBoxCEPFornecedor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(482, 420);
            MinimumSize = new Size(482, 420);
            Name = "CadastroFornecedorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Fornecedor";
            Load += CadastroFornecedorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBoxContatoFornecedor;
        private TextBox txtComplementoFornecedor;
        private Label lblComplemento;
        private TextBox txtCidadeFornecedor;
        private Label lblCidade;
        private TextBox txtEstadoFornecedor;
        private Label lblEstado;
        private TextBox txtNumeroFornecedor;
        private Label lblNumero;
        private Label lblEndereco;
        private Label lblCep;
        private Button btnCancelarFornecedor;
        private Button btnSalvarFornecedor;
        private TextBox txtEmailFornecedor;
        private Label lblEmail;
        private Label lblContato;
        private TextBox txtNomeFornecedor;
        private Label lblNome;
        private MaskedTextBox maskedTextBoxCEPFornecedor;
    }
}