using ControleDeEstoque.Data;
using ControleDeEstoque.Models;
using ControleDeEstoque.Repositories.Interfaces;
using ControleDeEstoque.Services.Interfaces;


namespace ControleDeEstoque.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly ApplicationDbContext _context;


        public ItemService(IItemRepository itemRepository, ApplicationDbContext context)
        {
            _itemRepository = itemRepository;
            _context = context;
        }

        public List<Item> ObterTodosItens()
        {
            return _context.Itens.ToList();
        }

        public List<Item> ObterItensPorNome(string nome)
        {
            return _context.Itens
                           .Where(i => i.Nome.Contains(nome))
                           .ToList();
        }

        public Item ObterItemPorId(int id)
        {
            return _context.Itens.Find(id);
        }

        public void AtualizarItem(Item item)
        {
            var itemExistente = _context.Itens.Find(item.Id);
            if (itemExistente != null)
            {
                itemExistente.Preco = item.Preco;
                itemExistente.QuantidadeEstoque = item.QuantidadeEstoque;
                _context.SaveChanges();
            }
        }

        public async Task<List<Item>> GetAllItemsAsync()
        {
            return await _itemRepository.GetAllAsync();
        }

        public async Task<Item> GetItemByIdAsync(int id)
        {
            return await _itemRepository.GetByIdAsync(id);
        }

        public async Task AddItemAsync(Item item)
        {
            // Aqui você pode adicionar lógica adicional antes de salvar, como validações
            await _itemRepository.AddAsync(item);
        }

        public async Task UpdateItemAsync(Item item)
        {
            await _itemRepository.UpdateAsync(item);
        }

        public async Task DeleteItemAsync(int id)
        {
            await _itemRepository.DeleteAsync(id);
        }
        public List<Item> BuscarItensPorNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return new List<Item>(); // Retorne uma lista vazia se o nome for nulo ou vazio
            }

            return _context.Itens
                .Where(i => i.Nome != null && i.Nome.Contains(nome))
                .ToList();
        }
        public List<Item> ObterItensComBaixoEstoque(int limiteBaixoEstoque)
        {
            return _context.Itens.Where(item => item.QuantidadeEstoque < limiteBaixoEstoque).ToList();
        }

    }
}
