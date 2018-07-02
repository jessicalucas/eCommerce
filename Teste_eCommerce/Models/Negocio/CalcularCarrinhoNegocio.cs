using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Teste_eCommerce.Models.Dados;

namespace Teste_eCommerce.Models.Negocio
{
    public class CalcularCarrinhoNegocio
    {
        public decimal CalcularComPromocao(int idProduto, int quantidade)
        {
            return new CalcularCarrinhoDados().CalcularComPromocao(idProduto, quantidade);
        }
    }
}