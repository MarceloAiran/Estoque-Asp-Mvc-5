using Estoque.Dao;
using Estoque.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Estoque.Controllers
{
    public class CategoriaDoProdutoController : Controller
    {
        // GET: CategoriaDoProduto
        public ActionResult Index()
        {
            CategoriasDAO dao = new CategoriasDAO();
            IList<CategoriaDoProduto> categorias = dao.Lista();
            ViewBag.TesteCategoria = categorias;
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adiciona(CategoriaDoProduto categoria)
        {
            CategoriasDAO dao = new CategoriasDAO();
            dao.Adiciona(categoria);
            return RedirectToAction("Index");
        }
    }
}