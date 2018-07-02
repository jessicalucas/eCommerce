using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Teste_eCommerce.Models.Dados;

namespace Teste_eCommerce.Models.Negocio
{
    public class ProdutoNegocio
    {
        public IEnumerable<Produto> Listar()
        {
            return new ProdutoDados().Listar();
        }
    }
}