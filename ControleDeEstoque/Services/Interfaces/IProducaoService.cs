using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeEstoque.Models;

namespace ControleDeEstoque.Services.Interfaces
{
    public interface IProducaoService
    {
        Task<List<Producao>> GetAllProducoesAsync();
        Task<Producao> GetProducaoByIdAsync(int id);
        Task AddProducaoAsync(Producao producao);
        Task UpdateProducaoAsync(Producao producao);
        Task DeleteProducaoAsync(int id);
    }
}

