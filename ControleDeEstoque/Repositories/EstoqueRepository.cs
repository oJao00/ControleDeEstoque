using ControleDeEstoque.Data;
using ControleDeEstoque.Models;
using ControleDeEstoque.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Repositories
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly ApplicationDbContext _context;

        public EstoqueRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Estoque>> GetAllAsync()
        {
            return await _context.Estoque.Include(e => e.Item).ToListAsync();
        }

        public async Task<Estoque> GetByIdAsync(int id)
        {
            return await _context.Estoque.Include(e => e.Item).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task AddAsync(Estoque estoque)
        {
            await _context.Estoque.AddAsync(estoque);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Estoque estoque)
        {
            _context.Estoque.Update(estoque);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var estoque = await _context.Estoque.FindAsync(id);
            if (estoque != null)
            {
                _context.Estoque.Remove(estoque);
                await _context.SaveChangesAsync();
            }
        }
    }
}
