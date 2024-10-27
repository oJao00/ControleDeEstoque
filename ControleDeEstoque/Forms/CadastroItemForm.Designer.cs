namespace ControleDeEstoque.Forms
{
    partial class CadastroItemForm
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
            lblCAtegoria = new Label();
            comboCategoria = new ComboBox();
            lblPreco = new Label();
            txtPreco = new TextBox();
            lblQuantidade = new Label();
            txtQuantidadeEstoque = new TextBox();
            lblFornecedor = new Label();
            comboFornecedor = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(20, 20);
            lblNome.Margin = new Padding(0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(80, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(120, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(250, 23);
            txtNome.TabIndex = 5;
            txtNome.KeyDown += txtNome_KeyDown;
            // 
            // lblCAtegoria
            // 
            lblCAtegoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCAtegoria.Location = new Point(20, 60);
            lblCAtegoria.Margin = new Padding(0);
            lblCAtegoria.Name = "lblCAtegoria";
            lblCAtegoria.Size = new Size(80, 23);
            lblCAtegoria.TabIndex = 6;
            lblCAtegoria.Text = "Categoria";
            lblCAtegoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboCategoria
            // 
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(120, 60);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(250, 23);
            comboCategoria.TabIndex = 7;
            // 
            // lblPreco
            // 
            lblPreco.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(20, 100);
            lblPreco.Margin = new Padding(0);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(80, 23);
            lblPreco.TabIndex = 8;
            lblPreco.Text = "Preço";
            lblPreco.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(120, 100);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(250, 23);
            txtPreco.TabIndex = 9;
            txtPreco.KeyDown += txtPreco_KeyDown;
            // 
            // lblQuantidade
            // 
            lblQuantidade.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(20, 140);
            lblQuantidade.Margin = new Padding(0);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(80, 23);
            lblQuantidade.TabIndex = 10;
            lblQuantidade.Text = "Quantidade";
            lblQuantidade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtQuantidadeEstoque
            // 
            txtQuantidadeEstoque.Location = new Point(120, 140);
            txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            txtQuantidadeEstoque.Size = new Size(250, 23);
            txtQuantidadeEstoque.TabIndex = 11;
            txtQuantidadeEstoque.KeyDown += txtQuantidadeEstoque_KeyDown;
            // 
            // lblFornecedor
            // 
            lblFornecedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFornecedor.Location = new Point(20, 180);
            lblFornecedor.Margin = new Padding(0);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(80, 23);
            lblFornecedor.TabIndex = 12;
            lblFornecedor.Text = "Fornecedor";
            lblFornecedor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboFornecedor
            // 
            comboFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFornecedor.FormattingEnabled = true;
            comboFornecedor.Location = new Point(120, 180);
            comboFornecedor.Name = "comboFornecedor";
            comboFornecedor.Size = new Size(250, 23);
            comboFornecedor.TabIndex = 13;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ControlLight;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(120, 222);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(240, 222);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CadastroItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(384, 261);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(comboFornecedor);
            Controls.Add(lblFornecedor);
            Controls.Add(txtQuantidadeEstoque);
            Controls.Add(lblQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(comboCategoria);
            Controls.Add(lblCAtegoria);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "CadastroItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Item";
            Load += CadastroItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblCAtegoria;
        private ComboBox comboCategoria;
        private Label lblPreco;
        private TextBox txtPreco;
        private Label lblQuantidade;
        private TextBox txtQuantidadeEstoque;
        private Label lblFornecedor;
        private ComboBox comboFornecedor;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}