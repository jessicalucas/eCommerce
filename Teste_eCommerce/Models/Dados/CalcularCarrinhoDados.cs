using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste_eCommerce.Models.Dados
{
    public class CalcularCarrinhoDados
    {
        public decimal CalcularComPromocao(int idProduto, int quantidade)
        {
            decimal valorASerPago = 0;
            if (quantidade == 0)
                return valorASerPago;

            var produto = new ProdutoDados().BuscarProdutoPorChave(idProduto);

            switch (produto.Promocao.TIPO_PROMO.Value)
            {
                case 1:
                    valorASerPago = LeveProdutosPagueValorFixo(produto, quantidade);
                    break;
                case 2:
                    valorASerPago = LeveMaisProdutosPagueMenosProdutos(produto, quantidade);
                    break;
                default:
                    break;
            }

            return valorASerPago;

        }

        public decimal LeveProdutosPagueValorFixo(Produto produto, int quantidade)
        {
            int totalDeProdutosNaPromocao = quantidade / produto.Promocao.QTD_LEVE_PROMO.Value;

            decimal valorDosProdutosNaPromocao = totalDeProdutosNaPromocao * produto.Promocao.VLR_PAGUE.Value;

            int totalDeProdutosForaDaPromocao = quantidade % produto.Promocao.QTD_LEVE_PROMO.Value;
            decimal valorDosProdutosForaDaPromocao = totalDeProdutosForaDaPromocao * produto.PRECO.Value;

            decimal total = valorDosProdutosNaPromocao + valorDosProdutosForaDaPromocao;

            return total;
        }


        public decimal LeveMaisProdutosPagueMenosProdutos(Produto produto, int quantidade)
        {
            int totalDeProdutosNaPromocao = quantidade / produto.Promocao.QTD_LEVE_PROMO.Value;
            decimal valorDosProdutosNaPromocao = totalDeProdutosNaPromocao * (produto.PRECO.Value * produto.Promocao.QTD_PAGUE_PROMO.Value);

            int totalDeProdutosForaDaPromocao = quantidade % produto.Promocao.QTD_LEVE_PROMO.Value;
            decimal valorDosProdutosForaDaPromocao = totalDeProdutosForaDaPromocao * produto.PRECO.Value;

            decimal total = valorDosProdutosNaPromocao + valorDosProdutosForaDaPromocao;

            return total;
        }

    }
}