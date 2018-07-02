using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste_eCommerce.Models.Dados
{
    public class ProdutoDados
    {
        private testesPSEntities db = new testesPSEntities();

        public Produto BuscarProdutoPorChave(long? id)
        {
            Produto produto = db.Produtoes.Find(id);
            return produto;
        }


        public IEnumerable<Produto> Listar()
        {
            IEnumerable<Produto> produto = db.Produtoes.ToList();

            return produto ?? produto;
        }

    }
}