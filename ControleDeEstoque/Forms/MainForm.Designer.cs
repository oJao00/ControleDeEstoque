namespace ControleDeEstoque
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            itemToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            produçãoToolStripMenuItem1 = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            novaVendaToolStripMenuItem = new ToolStripMenuItem();
            consultarVendaToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            novoPedidoToolStripMenuItem = new ToolStripMenuItem();
            consultarPedidToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, vendaToolStripMenuItem, pedidosToolStripMenuItem, estoqueToolStripMenuItem, relatóriosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itemToolStripMenuItem, clienteToolStripMenuItem, fornecedorToolStripMenuItem, produçãoToolStripMenuItem1 });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(69, 20);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // itemToolStripMenuItem
            // 
            itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            itemToolStripMenuItem.Size = new Size(180, 22);
            itemToolStripMenuItem.Text = "Item";
            itemToolStripMenuItem.Click += itemToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(180, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(180, 22);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // produçãoToolStripMenuItem1
            // 
            produçãoToolStripMenuItem1.Name = "produçãoToolStripMenuItem1";
            produçãoToolStripMenuItem1.Size = new Size(180, 22);
            produçãoToolStripMenuItem1.Text = "Produção";
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaVendaToolStripMenuItem, consultarVendaToolStripMenuItem });
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(51, 20);
            vendaToolStripMenuItem.Text = "Venda";
            // 
            // novaVendaToolStripMenuItem
            // 
            novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            novaVendaToolStripMenuItem.Size = new Size(160, 22);
            novaVendaToolStripMenuItem.Text = "Nova Venda";
            // 
            // consultarVendaToolStripMenuItem
            // 
            consultarVendaToolStripMenuItem.Name = "consultarVendaToolStripMenuItem";
            consultarVendaToolStripMenuItem.Size = new Size(160, 22);
            consultarVendaToolStripMenuItem.Text = "Consultar Venda";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoPedidoToolStripMenuItem, consultarPedidToolStripMenuItem });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(61, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // novoPedidoToolStripMenuItem
            // 
            novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            novoPedidoToolStripMenuItem.Size = new Size(165, 22);
            novoPedidoToolStripMenuItem.Text = "Novo Pedido";
            // 
            // consultarPedidToolStripMenuItem
            // 
            consultarPedidToolStripMenuItem.Name = "consultarPedidToolStripMenuItem";
            consultarPedidToolStripMenuItem.Size = new Size(165, 22);
            consultarPedidToolStripMenuItem.Text = "Consultar Pedido";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(61, 20);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGRONIP";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem itemToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem produçãoToolStripMenuItem1;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem novaVendaToolStripMenuItem;
        private ToolStripMenuItem consultarVendaToolStripMenuItem;
        private ToolStripMenuItem novoPedidoToolStripMenuItem;
        private ToolStripMenuItem consultarPedidToolStripMenuItem;
    }
}