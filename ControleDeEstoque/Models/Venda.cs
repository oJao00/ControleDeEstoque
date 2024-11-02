namespace ControleDeEstoque.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public string MetodoDePagamento { get; set; }


        public List<ItemVenda> ItensVendidos { get; set; } = new List<ItemVenda>();

        public void AdicionarItem(int itemId, int quantidade, decimal precoUnitario)
        {
            // Cria um novo ItemVenda
            var itemVenda = new ItemVenda
            {
                ItemId = itemId,
                Quantidade = quantidade,
                PrecoUnitario = precoUnitario
            };

            // Adiciona o item à lista de itens vendidos
            ItensVendidos.Add(itemVenda);

            // Atualiza o valor total da venda
            ValorTotal += quantidade * precoUnitario;
        }

    }
}
