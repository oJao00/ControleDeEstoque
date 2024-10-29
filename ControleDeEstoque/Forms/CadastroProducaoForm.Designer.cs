namespace ControleDeEstoque.Forms
{
    partial class CadastroProducaoForm
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
            txtCondicoesAmbientais = new TextBox();
            lblCep = new Label();
            btnCancelarProducao = new Button();
            btnSalvarProducao = new Button();
            lblEmail = new Label();
            lblContato = new Label();
            lblNome = new Label();
            dtpDataProducao = new DateTimePicker();
            nudQuantidadeProduzida = new NumericUpDown();
            nudQuantidadePerdida = new NumericUpDown();
            label1 = new Label();
            txtMetodoProducao = new TextBox();
            label2 = new Label();
            txtEquipamentoUtilizado = new TextBox();
            label3 = new Label();
            txtObservacoes = new TextBox();
            label4 = new Label();
            cmbProduto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadeProduzida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadePerdida).BeginInit();
            SuspendLayout();
            // 
            // txtCondicoesAmbientais
            // 
            txtCondicoesAmbientais.Location = new Point(198, 125);
            txtCondicoesAmbientais.MaxLength = 50;
            txtCondicoesAmbientais.Name = "txtCondicoesAmbientais";
            txtCondicoesAmbientais.Size = new Size(227, 23);
            txtCondicoesAmbientais.TabIndex = 74;
            // 
            // lblCep
            // 
            lblCep.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCep.Location = new Point(35, 125);
            lblCep.Margin = new Padding(0);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(141, 23);
            lblCep.TabIndex = 67;
            lblCep.Text = "Condições Ambientais";
            lblCep.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCancelarProducao
            // 
            btnCancelarProducao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarProducao.Location = new Point(325, 329);
            btnCancelarProducao.Name = "btnCancelarProducao";
            btnCancelarProducao.Size = new Size(100, 30);
            btnCancelarProducao.TabIndex = 66;
            btnCancelarProducao.Text = "Cancelar";
            btnCancelarProducao.UseVisualStyleBackColor = true;
            // 
            // btnSalvarProducao
            // 
            btnSalvarProducao.BackColor = SystemColors.ControlLight;
            btnSalvarProducao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarProducao.Location = new Point(198, 329);
            btnSalvarProducao.Name = "btnSalvarProducao";
            btnSalvarProducao.Size = new Size(100, 30);
            btnSalvarProducao.TabIndex = 65;
            btnSalvarProducao.Text = "Salvar";
            btnSalvarProducao.UseVisualStyleBackColor = false;
            btnSalvarProducao.Click += btnSalvarProducao_Click;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(35, 75);
            lblEmail.Margin = new Padding(0);
            lblEmail.Name = "lblEmail";
            lblEmail.RightToLeft = RightToLeft.No;
            lblEmail.Size = new Size(146, 23);
            lblEmail.TabIndex = 63;
            lblEmail.Text = "Quantidade Produzida";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblContato
            // 
            lblContato.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContato.Location = new Point(226, 25);
            lblContato.Margin = new Padding(0);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(123, 23);
            lblContato.TabIndex = 62;
            lblContato.Text = "Data de Produção";
            lblContato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(35, 25);
            lblNome.Margin = new Padding(0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 23);
            lblNome.TabIndex = 60;
            lblNome.Text = "Produto";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDataProducao
            // 
            dtpDataProducao.Format = DateTimePickerFormat.Short;
            dtpDataProducao.Location = new Point(345, 25);
            dtpDataProducao.Name = "dtpDataProducao";
            dtpDataProducao.Size = new Size(80, 23);
            dtpDataProducao.TabIndex = 79;
            // 
            // nudQuantidadeProduzida
            // 
            nudQuantidadeProduzida.Location = new Point(198, 73);
            nudQuantidadeProduzida.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantidadeProduzida.Name = "nudQuantidadeProduzida";
            nudQuantidadeProduzida.Size = new Size(34, 23);
            nudQuantidadeProduzida.TabIndex = 80;
            // 
            // nudQuantidadePerdida
            // 
            nudQuantidadePerdida.Location = new Point(391, 73);
            nudQuantidadePerdida.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantidadePerdida.Name = "nudQuantidadePerdida";
            nudQuantidadePerdida.Size = new Size(34, 23);
            nudQuantidadePerdida.TabIndex = 82;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 73);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(148, 23);
            label1.TabIndex = 81;
            label1.Text = "Quantidade Perdida";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMetodoProducao
            // 
            txtMetodoProducao.Location = new Point(198, 177);
            txtMetodoProducao.MaxLength = 50;
            txtMetodoProducao.Name = "txtMetodoProducao";
            txtMetodoProducao.Size = new Size(227, 23);
            txtMetodoProducao.TabIndex = 84;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 175);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(141, 23);
            label2.TabIndex = 83;
            label2.Text = "Método de Produção";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEquipamentoUtilizado
            // 
            txtEquipamentoUtilizado.Location = new Point(198, 225);
            txtEquipamentoUtilizado.MaxLength = 50;
            txtEquipamentoUtilizado.Name = "txtEquipamentoUtilizado";
            txtEquipamentoUtilizado.Size = new Size(227, 23);
            txtEquipamentoUtilizado.TabIndex = 86;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 225);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 85;
            label3.Text = "Equipamento Utilizado";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(198, 275);
            txtObservacoes.MaxLength = 50;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(227, 23);
            txtObservacoes.TabIndex = 88;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 275);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 87;
            label4.Text = "Observações";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbProduto
            // 
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(94, 25);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(121, 23);
            cmbProduto.TabIndex = 89;
            // 
            // CadastroProducaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 381);
            Controls.Add(txtObservacoes);
            Controls.Add(label4);
            Controls.Add(txtEquipamentoUtilizado);
            Controls.Add(label3);
            Controls.Add(txtMetodoProducao);
            Controls.Add(label2);
            Controls.Add(nudQuantidadePerdida);
            Controls.Add(label1);
            Controls.Add(nudQuantidadeProduzida);
            Controls.Add(dtpDataProducao);
            Controls.Add(txtCondicoesAmbientais);
            Controls.Add(btnCancelarProducao);
            Controls.Add(btnSalvarProducao);
            Controls.Add(lblEmail);
            Controls.Add(lblContato);
            Controls.Add(lblNome);
            Controls.Add(lblCep);
            Controls.Add(cmbProduto);
            Name = "CadastroProducaoForm";
            Text = "Cadastro de Produção";
            Load += CadastroProducaoForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantidadeProduzida).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadePerdida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCondicoesAmbientais;
        private Label lblCep;
        private Button btnCancelarProducao;
        private Button btnSalvarProducao;
        private Label lblEmail;
        private Label lblContato;
        private Label lblNome;
        private DateTimePicker dtpDataProducao;
        private NumericUpDown nudQuantidadeProduzida;
        private NumericUpDown nudQuantidadePerdida;
        private Label label1;
        private TextBox txtMetodoProducao;
        private Label label2;
        private TextBox txtEquipamentoUtilizado;
        private Label label3;
        private TextBox txtObservacoes;
        private Label label4;
        private ComboBox cmbProduto;
    }
}