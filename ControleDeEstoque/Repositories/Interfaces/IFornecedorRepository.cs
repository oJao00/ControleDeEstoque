using ControleDeEstoque.Models;

namespace ControleDeEstoque.Repositories.Interfaces
{
    public interface IFornecedorRepository
    {
        Task<List<Fornecedor>> GetAllAsync();
        Task<Fornecedor> GetByIdAsync(int id);
        Task AddAsync(Fornecedor fornecedor);
        Task UpdateAsync(Fornecedor fornecedor);
        Task DeleteAsync(int id);
    }
}

