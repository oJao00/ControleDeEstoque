namespace ControleDeEstoque.Forms
{
    partial class CadastroClienteForm
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
            lblNome = new Label();
            txtNome = new TextBox();
            lblContato = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            lblCep = new Label();
            lblEndereco = new Label();
            lblNumero = new Label();
            txtEstado = new TextBox();
            lblEstado = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            maskedTextBoxCEP = new MaskedTextBox();
            txtNumero = new TextBox();
            maskedTextBoxContato = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(43, 18);
            lblNome.Margin = new Padding(0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(80, 23);
            lblNome.TabIndex = 16;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(143, 18);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(250, 23);
            txtNome.TabIndex = 17;
            // 
            // lblContato
            // 
            lblContato.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContato.Location = new Point(43, 68);
            lblContato.Margin = new Padding(0);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(80, 23);
            lblContato.TabIndex = 20;
            lblContato.Text = "Contato";
            lblContato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(43, 118);
            lblEmail.Margin = new Padding(0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 23);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 23;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ControlLight;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(117, 335);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(237, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCep
            // 
            lblCep.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCep.Location = new Point(45, 192);
            lblCep.Margin = new Padding(0);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(50, 23);
            lblCep.TabIndex = 28;
            lblCep.Text = "CEP";
            lblCep.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(196, 162);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(63, 17);
            lblEndereco.TabIndex = 30;
            lblEndereco.Text = "Endereço";
            // 
            // lblNumero
            // 
            lblNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(280, 192);
            lblNumero.Margin = new Padding(0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 23);
            lblNumero.TabIndex = 31;
            lblNumero.Text = "Número";
            lblNumero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEstado
            // 
            txtEstado.CharacterCasing = CharacterCasing.Upper;
            txtEstado.Location = new Point(349, 236);
            txtEstado.MaxLength = 2;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(44, 23);
            txtEstado.TabIndex = 34;
            txtEstado.Leave += txtEstado_Leave;
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(280, 236);
            lblEstado.Margin = new Padding(0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 23);
            lblEstado.TabIndex = 33;
            lblEstado.Text = "Estado";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(143, 236);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(88, 23);
            txtCidade.TabIndex = 36;
            txtCidade.Leave += txtCidade_Leave;
            // 
            // lblCidade
            // 
            lblCidade.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCidade.Location = new Point(43, 236);
            lblCidade.Margin = new Padding(0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(57, 23);
            lblCidade.TabIndex = 35;
            lblCidade.Text = "Cidade";
            lblCidade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(143, 280);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(250, 23);
            txtComplemento.TabIndex = 38;
            // 
            // lblComplemento
            // 
            lblComplemento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComplemento.Location = new Point(43, 280);
            lblComplemento.Margin = new Padding(0);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(95, 23);
            lblComplemento.TabIndex = 37;
            lblComplemento.Text = "Complemento";
            lblComplemento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(143, 194);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(88, 23);
            maskedTextBoxCEP.TabIndex = 39;
            maskedTextBoxCEP.Leave += maskedTextBoxCEP_Leave;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(349, 192);
            txtNumero.MaxLength = 5;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(44, 23);
            txtNumero.TabIndex = 32;
            txtNumero.KeyPress += txtNumero_KeyPress;
            txtNumero.Leave += txtNumero_Leave;
            // 
            // maskedTextBoxContato
            // 
            maskedTextBoxContato.Location = new Point(143, 68);
            maskedTextBoxContato.Mask = "(00)00000-0000";
            maskedTextBoxContato.Name = "maskedTextBoxContato";
            maskedTextBoxContato.Size = new Size(250, 23);
            maskedTextBoxContato.TabIndex = 40;
            // 
            // CadastroClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 381);
            Controls.Add(maskedTextBoxContato);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(txtCidade);
            Controls.Add(lblCidade);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(lblEndereco);
            Controls.Add(lblCep);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblContato);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(maskedTextBoxCEP);
            Name = "CadastroClienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadatrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblContato;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label lblCep;
        private Label lblEndereco;
        private Label lblNumero;
        private TextBox txtEstado;
        private Label lblEstado;
        private TextBox txtCidade;
        private Label lblCidade;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private MaskedTextBox maskedTextBoxCEP;
        private TextBox txtNumero;
        private MaskedTextBox maskedTextBoxContato;
    }
}