namespace ControleDeEstoque.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Quantidade { get; set; }

        public Estoque() { }

        public Estoque(int id, Item item, int quantidade)
        {
            Id = id;
            Item = item;
            Quantidade = quantidade;
        }
    }
}
