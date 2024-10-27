using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeEstoque.Data;
using ControleDeEstoque.Models;
using ControleDeEstoque.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly ApplicationDbContext _context;

        public VendaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Venda>> GetAllAsync()
        {
            return await _context.Vendas.Include(v => v.Cliente).Include(v => v.ItensVendidos).ToListAsync();
        }

        public async Task<Venda> GetByIdAsync(int id)
        {
            return await _context.Vendas.Include(v => v.Cliente).Include(v => v.ItensVendidos).FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task AddAsync(Venda venda)
        {
            await _context.Vendas.AddAsync(venda);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Venda venda)
        {
            _context.Vendas.Update(venda);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var venda = await _context.Vendas.FindAsync(id);
            if (venda != null)
            {
                _context.Vendas.Remove(venda);
                await _context.SaveChangesAsync();
            }
        }
    }
}

