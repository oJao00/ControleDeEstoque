using ControleDeEstoque.Models;

namespace ControleDeEstoque.Services.Interfaces
{
    public interface IProducaoService
    {
        Task<List<Producao>> GetAllProducoesAsync();
        Task<Producao> GetProducaoByIdAsync(int id);
        Task AddProducaoAsync(Producao producao);
        Task UpdateProducaoAsync(Producao producao);
        Task DeleteProducaoAsync(int id);
    }
}

