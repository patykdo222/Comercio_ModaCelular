using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModaCel.Controllers
{
    public class HomeController : Controller
    {
        private Models.BDCelularesEntities bd = new Models.BDCelularesEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar(string id="")
        {
            //logica acceso a BD
            var productos = bd.Producto
                .Where(x => x.Denominacion.Contains(id))
                .Take(10)
                .ToList();
            //devuelve lista de productos
            ViewBag.clave = id;
            return View(productos);
        }
    }
}