using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models
{
    public class ItemVenda
    {
        public int Id { get; set; }

        public int ItemId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        // Navegação para a entidade Item
        public Item Item { get; set; }
    }

}
