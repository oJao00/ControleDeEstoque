namespace ControleDeEstoque.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Status { get; set; } // Exemplo: "Em Andamento", "Concluído", etc.
        public DateTime Data { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public List<Item> ItensDoPedido { get; set; }

        public Pedido()
        {
            ItensDoPedido = new List<Item>();
        }

        public Pedido(int id, Cliente cliente, string status, DateTime data, decimal valorUnitario, decimal valorTotal, List<Item> itensDoPedido)
        {
            Id = id;
            Cliente = cliente;
            Status = status;
            Data = data;
            ValorUnitario = valorUnitario;
            ValorTotal = valorTotal;
            ItensDoPedido = itensDoPedido;
        }
    }
}


