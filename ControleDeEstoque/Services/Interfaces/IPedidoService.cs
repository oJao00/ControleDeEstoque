using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

