using ControleDeEstoque.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleDeEstoque.Services.Interfaces;
using ControleDeEstoque.Services;
using ControleDeEstoque.Data;
using ControleDeEstoque.Repositories;

namespace ControleDeEstoque
{
    public partial class MainForm : Form
    {
        private readonly IItemService _itemService;
        private readonly IFornecedorService _fornecedorService;
        private readonly IClienteService _clienteService;
        private readonly IProducaoService _producaoService;

        public MainForm(IItemService itemService, IFornecedorService fornecedorService, IClienteService clienteService, IProducaoService producaoService)
        {
            InitializeComponent();
            _itemService = itemService ?? throw new ArgumentNullException(nameof(itemService));
            _fornecedorService = fornecedorService ?? throw new ArgumentNullException(nameof(fornecedorService));
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
            _producaoService = producaoService ?? throw new ArgumentNullException(nameof(producaoService));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroItemForm = new CadastroItemForm(_itemService, _fornecedorService);
            cadastroItemForm.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroClienteForm = new CadastroClienteForm(_clienteService);
            cadastroClienteForm.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroFornecedorForm = new CadastroFornecedorForm(_fornecedorService);
            cadastroFornecedorForm.ShowDialog();
        }

        private void produçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var cadastroProducaoForm = new CadastroProducaoForm(_producaoService, _itemService);
            cadastroProducaoForm.ShowDialog();

        }
    }
}

