using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Teste_eCommerce.Models;
using Teste_eCommerce.Models.Negocio;

namespace Teste_eCommerce.Controllers
{
    public class ItemProdutoController : Controller
    {
        public static List<ItemProduto> listaItens = new List<ItemProduto>();

        public ActionResult Checkout(int? id)
        {
            var item = new ItemProduto();

            return View(item);
        }

        [HttpPost]
        public decimal Atualizar(int id, int quantidade)
        {
            try
            {
                return new CalcularCarrinhoNegocio().CalcularComPromocao(id, quantidade);
            }
            catch (Exception)
            {

                throw;
            }

        }


        [HttpPost, ActionName("Index")]
        public ActionResult Index(decimal? id)
        {
            testesPSEntities db = new testesPSEntities();

            var item = new ItemProduto();

            Produto produto = db.Produtoes.Find(id);

            item.Item = produto;
            item.Quantidade = 1;

            listaItens.Add(item);

            return View();

        }

        public ActionResult Details()
        {
            return View();

        }


        public ActionResult Listar()
        {
            try
            {
                List<ItemProduto> listaItem = new List<ItemProduto>();

                var produtos = new ProdutoNegocio().Listar();

                foreach (var prodItem in produtos)
                {
                    ItemProduto item = new ItemProduto();
                    item.Item = prodItem;
                    item.Quantidade = 0;

                    listaItem.Add(item);

                }

                return Json(listaItem, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}