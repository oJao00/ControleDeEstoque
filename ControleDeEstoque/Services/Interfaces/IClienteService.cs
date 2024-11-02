using ControleDeEstoque.Models;


namespace ControleDeEstoque.Services.Interfaces
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetAllClientesAsync();
        Task<Cliente> GetClienteByIdAsync(int id);
        Task AddClienteAsync(Cliente cliente);
        Task UpdateClienteAsync(Cliente cliente);
        Task DeleteClienteAsync(int id);
        IEnumerable<Cliente> ObterTodosClientes();
    }
}
