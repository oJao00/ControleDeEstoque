using ControleDeEstoque.Data;
using ControleDeEstoque.Models;
using ControleDeEstoque.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Repositories
{
    public class ProducaoRepository : IProducaoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProducaoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Producao>> GetAllAsync()
        {
            return await _context.Producao.Include(p => p.Produto).ToListAsync();
        }

        public async Task<Producao> GetByIdAsync(int id)
        {
            return await _context.Producao.Include(p => p.Produto).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddAsync(Producao producao)
        {
            await _context.Producao.AddAsync(producao);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Producao producao)
        {
            _context.Producao.Update(producao);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var producao = await _context.Producao.FindAsync(id);
            if (producao != null)
            {
                _context.Producao.Remove(producao);
                await _context.SaveChangesAsync();
            }
        }
    }
}
