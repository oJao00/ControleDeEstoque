using ControleDeEstoque.Data;
using ControleDeEstoque.Forms;
using ControleDeEstoque.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace ControleDeEstoque
{
    public partial class MainForm : Form
    {
        private readonly IItemService _itemService;
        private readonly IFornecedorService _fornecedorService;
        private readonly IClienteService _clienteService;
        private readonly IProducaoService _producaoService;
        private readonly IVendaService _vendaService;
        private readonly ApplicationDbContext _context;

        public MainForm(IItemService itemService, IFornecedorService fornecedorService, IClienteService clienteService, IProducaoService producaoService, IVendaService vendaService, ApplicationDbContext context)
        {
            InitializeComponent();
            _itemService = itemService ?? throw new ArgumentNullException(nameof(itemService));
            _fornecedorService = fornecedorService ?? throw new ArgumentNullException(nameof(fornecedorService));
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
            _producaoService = producaoService ?? throw new ArgumentNullException(nameof(producaoService));
            _vendaService = vendaService ?? throw new ArgumentNullException(nameof(vendaService));
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-32RL4S3;Database=ControleDeEstoqueDB;Trusted_Connection=True;TrustServerCertificate=True;"); // Substitua por sua string de conexão

            _context = new ApplicationDbContext(optionsBuilder.Options);
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

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var vendaForm = new NovaVendaForm(_itemService, _clienteService, _vendaService, _context);

            vendaForm.ShowDialog();

        }

        private void consultarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultarVendasForm = new ConsultarVendasForm(_context, _vendaService);
            consultarVendasForm.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estoqueForm = new EstoqueForm(_itemService);
            estoqueForm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exibir uma mensagem de confirmação antes de sa
                Application.Exit(); // Fecha a aplicação
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja sair?", "Confirmar saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

