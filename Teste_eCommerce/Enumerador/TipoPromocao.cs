using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Teste_eCommerce.Enumerador
{
    public enum TipoPromocao
    {
        [Description("Leve N Produtos e Pague um Valor Fixo")]
        LeveProdutosPagueValorFixo = 1,
        [Description("Leve Mais Produtos e Pague Menos Produtos")]
        LeveMaisProdutosPagueMenosProdutos = 2
    }
}