namespace ControleDeEstoque.Forms
{
    partial class NovaVendaForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaVendaForm));
            label1 = new Label();
            txtBuscarItem = new TextBox();
            btnBuscarItem = new Button();
            label2 = new Label();
            label3 = new Label();
            cmbCliente = new ComboBox();
            label4 = new Label();
            dtpDataVenda = new DateTimePicker();
            label5 = new Label();
            cmbMetodoPagamento = new ComboBox();
            btnFinalizarVenda = new Button();
            btnCancelarVenda = new Button();
            lstResultadosItens = new ListView();
            IdItem = new ColumnHeader();
            Nome1 = new ColumnHeader();
            Preco1 = new ColumnHeader();
            Quantidade1 = new ColumnHeader();
            dgvItensSelecionados = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            btnRemover = new DataGridViewButtonColumn();
            btnAdicionarItem = new Button();
            txtTotalVenda = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItensSelecionados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "Buscar Item";
            // 
            // txtBuscarItem
            // 
            txtBuscarItem.Location = new Point(113, 20);
            txtBuscarItem.Name = "txtBuscarItem";
            txtBuscarItem.Size = new Size(200, 23);
            txtBuscarItem.TabIndex = 1;
            txtBuscarItem.KeyDown += txtBuscarItem_KeyDown;
            // 
            // btnBuscarItem
            // 
            btnBuscarItem.Location = new Point(321, 19);
            btnBuscarItem.Name = "btnBuscarItem";
            btnBuscarItem.Size = new Size(80, 25);
            btnBuscarItem.TabIndex = 2;
            btnBuscarItem.Text = "Buscar";
            btnBuscarItem.UseVisualStyleBackColor = true;
            btnBuscarItem.Click += btnBuscarItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(417, 20);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 4;
            label2.Text = "Itens Selecionados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 346);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 6;
            label3.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(95, 346);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(305, 23);
            cmbCliente.TabIndex = 7;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            cmbCliente.RegionChanged += cmbCliente_RegionChanged;
            cmbCliente.Validating += cmbCliente_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 389);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 8;
            label4.Text = "Data da Venda";
            // 
            // dtpDataVenda
            // 
            dtpDataVenda.Format = DateTimePickerFormat.Short;
            dtpDataVenda.Location = new Point(144, 388);
            dtpDataVenda.Name = "dtpDataVenda";
            dtpDataVenda.Size = new Size(257, 23);
            dtpDataVenda.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 432);
            label5.Name = "label5";
            label5.Size = new Size(167, 21);
            label5.TabIndex = 10;
            label5.Text = "Método de Pagamento";
            // 
            // cmbMetodoPagamento
            // 
            cmbMetodoPagamento.FormattingEnabled = true;
            cmbMetodoPagamento.Items.AddRange(new object[] { "Crédito", "Débito", "Pix" });
            cmbMetodoPagamento.Location = new Point(201, 430);
            cmbMetodoPagamento.Name = "cmbMetodoPagamento";
            cmbMetodoPagamento.Size = new Size(200, 23);
            cmbMetodoPagamento.TabIndex = 11;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.Location = new Point(649, 489);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(120, 40);
            btnFinalizarVenda.TabIndex = 12;
            btnFinalizarVenda.Text = "Finalizar Venda";
            btnFinalizarVenda.UseVisualStyleBackColor = true;
            btnFinalizarVenda.Click += btnFinalizarVenda_Click;
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.Location = new Point(789, 489);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(120, 40);
            btnCancelarVenda.TabIndex = 13;
            btnCancelarVenda.Text = "Cancelar";
            btnCancelarVenda.UseVisualStyleBackColor = true;
            btnCancelarVenda.Click += btnCancelarVenda_Click;
            // 
            // lstResultadosItens
            // 
            lstResultadosItens.Columns.AddRange(new ColumnHeader[] { IdItem, Nome1, Preco1, Quantidade1 });
            lstResultadosItens.Location = new Point(19, 60);
            lstResultadosItens.Name = "lstResultadosItens";
            lstResultadosItens.Size = new Size(382, 218);
            lstResultadosItens.TabIndex = 14;
            lstResultadosItens.UseCompatibleStateImageBehavior = false;
            lstResultadosItens.View = View.Details;
            // 
            // IdItem
            // 
            IdItem.Text = "Id";
            IdItem.Width = 45;
            // 
            // Nome1
            // 
            Nome1.Text = "Nome";
            Nome1.Width = 170;
            // 
            // Preco1
            // 
            Preco1.Text = "Preço";
            Preco1.Width = 85;
            // 
            // Quantidade1
            // 
            Quantidade1.Text = "Quantidade";
            Quantidade1.Width = 80;
            // 
            // dgvItensSelecionados
            // 
            dgvItensSelecionados.AllowUserToAddRows = false;
            dgvItensSelecionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensSelecionados.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Preco, Quantidade, btnRemover });
            dgvItensSelecionados.Location = new Point(420, 60);
            dgvItensSelecionados.Name = "dgvItensSelecionados";
            dgvItensSelecionados.Size = new Size(489, 393);
            dgvItensSelecionados.TabIndex = 16;
            dgvItensSelecionados.CellContentClick += dgvItensSelecionados_CellContentClick;
            dgvItensSelecionados.CellEndEdit += dgvItensSelecionados_CellEndEdit;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.FillWeight = 25F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
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
            Preco.FillWeight = 50F;
            Preco.HeaderText = "Preço";
            Preco.Name = "Preco";
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantidade.FillWeight = 50F;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // btnRemover
            // 
            btnRemover.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.NullValue = "X";
            btnRemover.DefaultCellStyle = dataGridViewCellStyle1;
            btnRemover.FillWeight = 20F;
            btnRemover.HeaderText = "";
            btnRemover.Name = "btnRemover";
            btnRemover.Resizable = DataGridViewTriState.True;
            btnRemover.SortMode = DataGridViewColumnSortMode.Automatic;
            btnRemover.Text = "X";
            btnRemover.UseColumnTextForButtonValue = true;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Location = new Point(305, 294);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(95, 30);
            btnAdicionarItem.TabIndex = 17;
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.UseVisualStyleBackColor = true;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // txtTotalVenda
            // 
            txtTotalVenda.Location = new Point(824, 18);
            txtTotalVenda.Name = "txtTotalVenda";
            txtTotalVenda.ReadOnly = true;
            txtTotalVenda.Size = new Size(85, 23);
            txtTotalVenda.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(776, 19);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 19;
            label6.Text = "Total";
            // 
            // NovaVendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 563);
            Controls.Add(label6);
            Controls.Add(txtTotalVenda);
            Controls.Add(btnAdicionarItem);
            Controls.Add(btnCancelarVenda);
            Controls.Add(btnFinalizarVenda);
            Controls.Add(cmbMetodoPagamento);
            Controls.Add(label5);
            Controls.Add(dtpDataVenda);
            Controls.Add(label4);
            Controls.Add(cmbCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBuscarItem);
            Controls.Add(txtBuscarItem);
            Controls.Add(label1);
            Controls.Add(lstResultadosItens);
            Controls.Add(dgvItensSelecionados);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NovaVendaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nova Venda";
            Load += NovaVendaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItensSelecionados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarItem;
        private Button btnBuscarItem;
        private Label label2;
        private DataGridView dgvItensSelecionados;
        private Label label3;
        private ComboBox cmbCliente;
        private Label label4;
        private DateTimePicker dtpDataVenda;
        private Label label5;
        private ComboBox cmbMetodoPagamento;
        private Button btnFinalizarVenda;
        private Button btnCancelarVenda;
        private ListView lstResultadosItens;
        private Button btnAdicionarItem;
        private ColumnHeader IdItem;
        private ColumnHeader Nome1;
        private ColumnHeader Preco1;
        private ColumnHeader Quantidade1;
        private TextBox txtTotalVenda;
        private Label label6;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewButtonColumn btnRemover;
    }
}