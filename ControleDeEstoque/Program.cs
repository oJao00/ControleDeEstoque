using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ControleDeEstoque.Data;
using ControleDeEstoque.Repositories.Interfaces;
using ControleDeEstoque.Repositories;
using ControleDeEstoque.Services.Interfaces;
using ControleDeEstoque.Services;
using ControleDeEstoque.Forms;

namespace ControleDeEstoque
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm);


        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Carregar a configura��o do arquivo appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Adicionar o ApplicationDbContext com a string de conex�o
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            // Registrar os formul�rios
            services.AddTransient<MainForm>();

            // Registrar os reposit�rios
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IVendaRepository, VendaRepository>();          // Registro do VendaRepository
            services.AddScoped<IPedidoRepository, PedidoRepository>();        // Registro do PedidoRepository
            services.AddScoped<IProducaoRepository, ProducaoRepository>();    // Registro do ProducaoRepository
            services.AddScoped<IEstoqueRepository, EstoqueRepository>();      // Registro do EstoqueRepository

            // Registrar os servi�os
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IVendaService, VendaService>();                // Registro do VendaService
            services.AddScoped<IPedidoService, PedidoService>();              // Registro do PedidoService
            services.AddScoped<IProducaoService, ProducaoService>();          // Registro do ProducaoService
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddTransient<CadastroItemForm>();



        }
    }
}
