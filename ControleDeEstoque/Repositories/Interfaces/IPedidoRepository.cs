using ControleDeEstoque.Models;

namespace ControleDeEstoque.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        Task<List<Pedido>> GetAllAsync();
        Task<Pedido> GetByIdAsync(int id);
        Task AddAsync(Pedido pedido);
        Task UpdateAsync(Pedido pedido);
        Task DeleteAsync(int id);
    }
}
