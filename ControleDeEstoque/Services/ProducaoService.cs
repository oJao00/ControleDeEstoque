using ControleDeEstoque.Models;
using ControleDeEstoque.Repositories.Interfaces;
using ControleDeEstoque.Services.Interfaces;

namespace ControleDeEstoque.Services
{
    public class ProducaoService : IProducaoService
    {
        private readonly IProducaoRepository _producaoRepository;

        public ProducaoService(IProducaoRepository producaoRepository)
        {
            _producaoRepository = producaoRepository;
        }

        public async Task<List<Producao>> GetAllProducoesAsync()
        {
            return await _producaoRepository.GetAllAsync();
        }

        public async Task<Producao> GetProducaoByIdAsync(int id)
        {
            return await _producaoRepository.GetByIdAsync(id);
        }

        public async Task AddProducaoAsync(Producao producao)
        {
            await _producaoRepository.AddAsync(producao);
        }

        public async Task UpdateProducaoAsync(Producao producao)
        {
            await _producaoRepository.UpdateAsync(producao);
        }

        public async Task DeleteProducaoAsync(int id)
        {
            await _producaoRepository.DeleteAsync(id);
        }
    }
}
