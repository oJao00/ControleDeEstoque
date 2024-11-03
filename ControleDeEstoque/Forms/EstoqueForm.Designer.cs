namespace ControleDeEstoque.Forms
{
    partial class EstoqueForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstoqueForm));
            label1 = new Label();
            btnBuscarItem = new Button();
            txtBusca = new TextBox();
            label2 = new Label();
            dgvEstoque = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            btnSalvarAlteracoes = new Button();
            btnRelatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 19);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 5;
            label1.Text = "Estoque";
            // 
            // btnBuscarItem
            // 
            btnBuscarItem.Location = new Point(453, 82);
            btnBuscarItem.Name = "btnBuscarItem";
            btnBuscarItem.Size = new Size(80, 25);
            btnBuscarItem.TabIndex = 8;
            btnBuscarItem.Text = "Buscar";
            btnBuscarItem.UseVisualStyleBackColor = true;
            btnBuscarItem.Click += btnBuscarItem_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(245, 83);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(200, 23);
            txtBusca.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 83);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 6;
            label2.Text = "Buscar Item";
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToOrderColumns = true;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Preco, Quantidade });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEstoque.Location = new Point(65, 135);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.Size = new Size(555, 320);
            dgvEstoque.TabIndex = 9;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.FillWeight = 10F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Preco
            // 
            Preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            Preco.DefaultCellStyle = dataGridViewCellStyle1;
            Preco.FillWeight = 30F;
            Preco.HeaderText = "Preço";
            Preco.Name = "Preco";
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantidade.FillWeight = 30F;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // btnSalvarAlteracoes
            // 
            btnSalvarAlteracoes.Location = new Point(500, 480);
            btnSalvarAlteracoes.Name = "btnSalvarAlteracoes";
            btnSalvarAlteracoes.Size = new Size(120, 40);
            btnSalvarAlteracoes.TabIndex = 13;
            btnSalvarAlteracoes.Text = "Salvar Alterações";
            btnSalvarAlteracoes.UseVisualStyleBackColor = true;
            btnSalvarAlteracoes.Click += btnSalvarAlteracoes_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(65, 477);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(140, 47);
            btnRelatorio.TabIndex = 14;
            btnRelatorio.Text = "Gerar Relatório de Itens com baixo estoque";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // EstoqueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(684, 539);
            Controls.Add(btnRelatorio);
            Controls.Add(btnSalvarAlteracoes);
            Controls.Add(dgvEstoque);
            Controls.Add(btnBuscarItem);
            Controls.Add(txtBusca);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(700, 578);
            MinimumSize = new Size(700, 578);
            Name = "EstoqueForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            Load += EstoqueForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBuscarItem;
        private TextBox txtBusca;
        private Label label2;
        private DataGridView dgvEstoque;
        private Button btnSalvarAlteracoes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Quantidade;
        private Button btnRelatorio;
    }
}