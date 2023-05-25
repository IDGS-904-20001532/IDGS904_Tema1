using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult Triangulo(Triangulo tr)
        {
            var model = new Triangulo();
            model.Resultado = tr.CalcularTriangulo();

            return View(model);
        }
    }
}