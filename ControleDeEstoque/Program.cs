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

namespace ControleDeEstoque
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var mainForm = serviceProvider.GetRequiredService<Form1>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm);


        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Carregar a configuração do arquivo appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Adicionar o ApplicationDbContext com a string de conexão
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Registrar os formulários
            services.AddTransient<Form1>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IClienteService, ClienteService>();




        }
    }
}
