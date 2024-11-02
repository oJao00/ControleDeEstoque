using ControleDeEstoque.Models;

namespace ControleDeEstoque.Services.Interfaces
{
    public interface IPedidoService
    {
        Task<List<Pedido>> GetAllPedidosAsync();
        Task<Pedido> GetPedidoByIdAsync(int id);
        Task AddPedidoAsync(Pedido pedido);
        Task UpdatePedidoAsync(Pedido pedido);
        Task DeletePedidoAsync(int id);
    }
}

