using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste_eCommerce.Models
{
    public class ItemProduto
    {
        public Produto Item { get; set; }
        public int Quantidade { get; set; }
        public decimal? Total { get; set; }
    }
}