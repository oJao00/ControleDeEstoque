namespace ControleDeEstoque.Models
{
    public class Item
    {
        public int Id { get; set; }

        private string _nome;
        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nome não pode ser vazio ou nulo.");
                _nome = value;
            }
        }

        public CategoriaItem Categoria { get; set; }

        private decimal _preco;
        public decimal Preco
        {
            get => _preco;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Preço não pode ser negativo.");
                _preco = value;
            }
        }

        private int _quantidadeEstoque;
        public int QuantidadeEstoque
        {
            get => _quantidadeEstoque;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantidade em estoque não pode ser negativa.");
                _quantidadeEstoque = value;
            }
        }

        public int FornecedorId { get; set; }
    }

    public enum CategoriaItem
    {
        GraosECereais,
        LegumesEVegetais,
        Frutas,
        ProdutosLacteos,
        CarnesEAves,
        SementesEMudas,
        FerramentasEEquipamentos,
        AdubosEFertilizantes,
        RacoesESuplementos
    }



}

