//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teste_eCommerce.Models
{
    using System;
    using System.Collections.Generic;
    using Teste_eCommerce.Enumerador;

    public partial class Promocao
    {
        public long ID_PROMO { get; set; }
        public Nullable<int> TIPO_PROMO { get; set; }
        public Nullable<int> QTD_LEVE_PROMO { get; set; }
        public Nullable<int> QTD_PAGUE_PROMO { get; set; }
        public Nullable<decimal> VLR_PAGUE { get; set; }
        public string DESC_PROMO { get; set; }

        public TipoPromocao TipoPromocao { get;set; }
    }
}