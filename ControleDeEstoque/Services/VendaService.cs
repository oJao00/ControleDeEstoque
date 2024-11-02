using ControleDeEstoque.Data;
using ControleDeEstoque.Models;
using ControleDeEstoque.Repositories.Interfaces;
using ControleDeEstoque.Services.Interfaces;

namespace ControleDeEstoque.Services
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly ApplicationDbContext _context;

        public VendaService(ApplicationDbContext context, IVendaRepository vendaRepository)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _vendaRepository = vendaRepository;
        }

        public async Task<List<Venda>> GetAllVendasAsync()
        {
            return await _vendaRepository.GetAllAsync();
        }

        public async Task<Venda> GetVendaByIdAsync(int id)
        {
            return await _vendaRepository.GetByIdAsync(id);
        }

        public async Task AddVendaAsync(Venda venda)
        {
            await _vendaRepository.AddAsync(venda);
        }

        public async Task UpdateVendaAsync(Venda venda)
        {
            await _vendaRepository.UpdateAsync(venda);
        }

        public async Task DeleteVendaAsync(int id)
        {
            await _vendaRepository.DeleteAsync(id);
        }

        public void SalvarVenda(Venda venda)
        {
            if (venda == null)
                throw new ArgumentNullException(nameof(venda));

            venda.ValorTotal = 0;

            foreach (var vendaItem in venda.ItensVendidos)
            {
                var item = _context.Itens.Find(vendaItem.ItemId);
                if (item == null)
                    throw new InvalidOperationException($"Item com ID {vendaItem.ItemId} não encontrado.");

                vendaItem.PrecoUnitario = item.Preco; // Atualiza o preço do item
                venda.ValorTotal += vendaItem.PrecoUnitario * vendaItem.Quantidade;
            }

            _context.Vendas.Add(venda);
            _context.SaveChanges();
        }





    }
}
