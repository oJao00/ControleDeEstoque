using ControleDeEstoque.Models;

namespace ControleDeEstoque.Repositories.Interfaces
{
    public interface IEstoqueRepository
    {
        Task<List<Estoque>> GetAllAsync();
        Task<Estoque> GetByIdAsync(int id);
        Task AddAsync(Estoque estoque);
        Task UpdateAsync(Estoque estoque);
        Task DeleteAsync(int id);
    }
}
