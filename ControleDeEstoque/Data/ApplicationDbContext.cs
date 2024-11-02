using ControleDeEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Item> Itens { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producao> Producao { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<ItemVenda> ItemVendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>()
                .Property(i => i.Preco)
                .HasColumnType("decimal(18,2)"); // 18 dígitos no total, 2 após a vírgula

            modelBuilder.Entity<Pedido>()
                .Property(p => p.ValorUnitario)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Pedido>()
                .Property(p => p.ValorTotal)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Venda>()
                .Property(v => v.ValorTotal)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ItemVenda>()
            .HasKey(iv => iv.Id);
        }

    }
}

