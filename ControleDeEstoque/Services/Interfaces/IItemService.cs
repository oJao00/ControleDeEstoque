using ControleDeEstoque.Models;


namespace ControleDeEstoque.Services.Interfaces
{
    public interface IItemService
    {
        Task<List<Item>> GetAllItemsAsync();
        Task<Item> GetItemByIdAsync(int id);
        Task AddItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task DeleteItemAsync(int id);
        List<Item> BuscarItensPorNome(string nome);
        List<Item> ObterTodosItens();
        List<Item> ObterItensPorNome(string nome);
        Item ObterItemPorId(int id);
        void AtualizarItem(Item item);
        List<Item> ObterItensComBaixoEstoque(int limiteBaixoEstoque);
    }
}
