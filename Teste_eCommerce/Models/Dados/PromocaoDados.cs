using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste_eCommerce.Models.Dados
{
    public class PromocaoDados
    {
        private testesPSEntities db = new testesPSEntities();

        public Promocao BuscarPromocaoPorChave(long? id)
        {
            Promocao promocao = db.Promocaos.Find(id);
            return promocao;
        }

        public IEnumerable<Promocao> Listar()
        {
            IEnumerable<Promocao> promocao = db.Promocaos.ToList();

            return promocao ?? promocao;
        }

    }
}