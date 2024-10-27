using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeEstoque.Models;
using ControleDeEstoque.Repositories.Interfaces;
using ControleDeEstoque.Services.Interfaces;

namespace ControleDeEstoque.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task<List<Pedido>> GetAllPedidosAsync()
        {
            return await _pedidoRepository.GetAllAsync();
        }

        public async Task<Pedido> GetPedidoByIdAsync(int id)
        {
            return await _pedidoRepository.GetByIdAsync(id);
        }

        public async Task AddPedidoAsync(Pedido pedido)
        {
            await _pedidoRepository.AddAsync(pedido);
        }

        public async Task UpdatePedidoAsync(Pedido pedido)
        {
            await _pedidoRepository.UpdateAsync(pedido);
        }

        public async Task DeletePedidoAsync(int id)
        {
            await _pedidoRepository.DeleteAsync(id);
        }
    }
}

