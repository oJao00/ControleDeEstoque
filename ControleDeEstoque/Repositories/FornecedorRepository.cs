using ControleDeEstoque.Data;
using ControleDeEstoque.Models;
using ControleDeEstoque.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace ControleDeEstoque.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly ApplicationDbContext _context;

        public FornecedorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Fornecedor>> GetAllAsync()
        {
            return await _context.Fornecedores.ToListAsync();
        }

        public async Task<Fornecedor> GetByIdAsync(int id)
        {
            return await _context.Fornecedores.FindAsync(id);
        }

        public async Task AddAsync(Fornecedor fornecedor)
        {
            await _context.Fornecedores.AddAsync(fornecedor);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Fornecedor fornecedor)
        {
            _context.Fornecedores.Update(fornecedor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var fornecedor = await GetByIdAsync(id);
            if (fornecedor != null)
            {
                _context.Fornecedores.Remove(fornecedor);
                await _context.SaveChangesAsync();
            }
        }
    }
}

