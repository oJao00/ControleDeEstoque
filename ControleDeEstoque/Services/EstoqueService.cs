using ControleDeEstoque.Models;
using ControleDeEstoque.Repositories.Interfaces;
using ControleDeEstoque.Services.Interfaces;

namespace ControleDeEstoque.Services
{
    public class EstoqueService : IEstoqueService
    {
        private readonly IEstoqueRepository _estoqueRepository;

        public EstoqueService(IEstoqueRepository estoqueRepository)
        {
            _estoqueRepository = estoqueRepository;
        }

        public async Task<List<Estoque>> GetAllEstoquesAsync()
        {
            return await _estoqueRepository.GetAllAsync();
        }

        public async Task<Estoque> GetEstoqueByIdAsync(int id)
        {
            return await _estoqueRepository.GetByIdAsync(id);
        }

        public async Task AddEstoqueAsync(Estoque estoque)
        {
            await _estoqueRepository.AddAsync(estoque);
        }

        public async Task UpdateEstoqueAsync(Estoque estoque)
        {
            await _estoqueRepository.UpdateAsync(estoque);
        }

        public async Task DeleteEstoqueAsync(int id)
        {
            await _estoqueRepository.DeleteAsync(id);
        }
    }
}

