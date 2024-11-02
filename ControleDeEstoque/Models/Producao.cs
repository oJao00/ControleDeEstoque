namespace ControleDeEstoque.Models
{
    public class Producao
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public DateTime DataDeProducao { get; set; }
        public int QuantidadeProduzida { get; set; }
        public int QuantidadePerdida { get; set; }
        public string CondicoesAmbientais { get; set; }
        public string MetodoDeProducao { get; set; }
        public string EquipamentoUtilizado { get; set; }
        public string Observacoes { get; set; }

        public Producao() { }

        public Producao(int id, string produto, DateTime dataDeProducao, int quantidadeProduzida, int quantidadePerdida, string condicoesAmbientais, string metodoDeProducao, string equipamentoUtilizado, string observacoes)
        {
            Id = id;
            Produto = produto;
            DataDeProducao = dataDeProducao;
            QuantidadeProduzida = quantidadeProduzida;
            QuantidadePerdida = quantidadePerdida;
            CondicoesAmbientais = condicoesAmbientais;
            MetodoDeProducao = metodoDeProducao;
            EquipamentoUtilizado = equipamentoUtilizado;
            Observacoes = observacoes;
        }
    }
}


