using ControleDeEstoque.Models;

namespace ControleDeEstoque.Services.Interfaces
{
    public interface IEstoqueService
    {
        Task<List<Estoque>> GetAllEstoquesAsync();
        Task<Estoque> GetEstoqueByIdAsync(int id);
        Task AddEstoqueAsync(Estoque estoque);
        Task UpdateEstoqueAsync(Estoque estoque);
        Task DeleteEstoqueAsync(int id);
    }
}
