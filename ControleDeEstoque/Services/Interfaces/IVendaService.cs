using ControleDeEstoque.Models;

namespace ControleDeEstoque.Services.Interfaces
{
    public interface IVendaService
    {
        Task<List<Venda>> GetAllVendasAsync();
        Task<Venda> GetVendaByIdAsync(int id);
        Task AddVendaAsync(Venda venda);
        Task UpdateVendaAsync(Venda venda);
        Task DeleteVendaAsync(int id);
        void SalvarVenda(Venda venda);

    }
}

