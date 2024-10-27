using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public List<Item> ItensVendidos { get; set; }
        public decimal ValorTotal { get; set; }
        public string MetodoDePagamento { get; set; } // Exemplo: "Cartão", "Dinheiro", etc.

        public Venda()
        {
            ItensVendidos = new List<Item>();
        }

        public Venda(int id, DateTime data, Cliente cliente, List<Item> itensVendidos, decimal valorTotal, string metodoDePagamento)
        {
            Id = id;
            Data = data;
            Cliente = cliente;
            ItensVendidos = itensVendidos;
            ValorTotal = valorTotal;
            MetodoDePagamento = metodoDePagamento;
        }
    }
}

