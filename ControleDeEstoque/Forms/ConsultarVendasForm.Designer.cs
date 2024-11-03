namespace ControleDeEstoque.Forms
{
    partial class ConsultarVendasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarVendasForm));
            dtpData = new DateTimePicker();
            btnBuscar = new Button();
            dgvVendas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NomeCliente = new DataGridViewTextBoxColumn();
            ValorTotal = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            btnGerarArquivo = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
            SuspendLayout();
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(271, 93);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(105, 23);
            dtpData.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(422, 88);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 32);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvVendas
            // 
            dgvVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendas.Columns.AddRange(new DataGridViewColumn[] { Id, NomeCliente, ValorTotal, Data });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVendas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVendas.Location = new Point(65, 147);
            dgvVendas.Name = "dgvVendas";
            dgvVendas.ReadOnly = true;
            dgvVendas.Size = new Size(555, 300);
            dgvVendas.TabIndex = 2;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.FillWeight = 30F;
            Id.HeaderText = "Id Venda";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // NomeCliente
            // 
            NomeCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NomeCliente.FillWeight = 80F;
            NomeCliente.HeaderText = "Cliente";
            NomeCliente.Name = "NomeCliente";
            NomeCliente.ReadOnly = true;
            // 
            // ValorTotal
            // 
            ValorTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            ValorTotal.DefaultCellStyle = dataGridViewCellStyle1;
            ValorTotal.FillWeight = 50F;
            ValorTotal.HeaderText = "Valor Total";
            ValorTotal.Name = "ValorTotal";
            ValorTotal.ReadOnly = true;
            // 
            // Data
            // 
            Data.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Data.FillWeight = 60F;
            Data.HeaderText = "Data da Venda";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // btnGerarArquivo
            // 
            btnGerarArquivo.Location = new Point(500, 471);
            btnGerarArquivo.Name = "btnGerarArquivo";
            btnGerarArquivo.Size = new Size(120, 35);
            btnGerarArquivo.TabIndex = 3;
            btnGerarArquivo.Text = "Gerar Arquivo";
            btnGerarArquivo.UseVisualStyleBackColor = true;
            btnGerarArquivo.Click += btnGerarArquivo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 28);
            label1.Name = "label1";
            label1.Size = new Size(183, 30);
            label1.TabIndex = 4;
            label1.Text = "Consultar Vendas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 94);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 5;
            label2.Text = "Data da venda";
            // 
            // ConsultarVendasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 521);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGerarArquivo);
            Controls.Add(dgvVendas);
            Controls.Add(btnBuscar);
            Controls.Add(dtpData);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(700, 560);
            MinimumSize = new Size(700, 560);
            Name = "ConsultarVendasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Vendas";
            Load += ConsultarVendasForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpData;
        private Button btnBuscar;
        private DataGridView dgvVendas;
        private Button btnGerarArquivo;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn ValorTotal;
        private DataGridViewTextBoxColumn Data;
    }
}