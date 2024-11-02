﻿using ControleDeEstoque.Models;


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
