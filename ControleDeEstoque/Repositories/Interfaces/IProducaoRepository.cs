using ControleDeEstoque.Models;

namespace ControleDeEstoque.Repositories.Interfaces
{
    public interface IProducaoRepository
    {
        Task<List<Producao>> GetAllAsync();
        Task<Producao> GetByIdAsync(int id);
        Task AddAsync(Producao producao);
        Task UpdateAsync(Producao producao);
        Task DeleteAsync(int id);
    }
}

