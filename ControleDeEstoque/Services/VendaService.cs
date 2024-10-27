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
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _vendaRepository;

        public VendaService(IVendaRepository vendaRepository)
        {
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
    }
}
