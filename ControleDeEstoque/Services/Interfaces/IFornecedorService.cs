using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeEstoque.Models;


namespace ControleDeEstoque.Services.Interfaces
{
    public interface IFornecedorService
    {
        Task<List<Fornecedor>> GetAllFornecedoresAsync();
        Task<Fornecedor> GetFornecedorByIdAsync(int id);
        Task AddFornecedorAsync(Fornecedor fornecedor);
        Task UpdateFornecedorAsync(Fornecedor fornecedor);
        Task DeleteFornecedorAsync(int id);
    }
}
