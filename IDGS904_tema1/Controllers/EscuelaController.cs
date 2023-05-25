using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public JsonResult Index()
        {
            //return Content("<h1>Paula </br> Valencia</h1>");
            var pulque = new Producto()
            {
                nombre = "pulque1",
                descripcion = "fresa",
                cantidad = 10,
                produccion = new DateTime(2023, 11, 2)
            };
            return Json(pulque, JsonRequestBehavior.AllowGet);
            //return View();
        }
        public RedirectResult Vista()
        {
            return Redirect("https://google.com.mx");
        }
        public RedirectToRouteResult Vista2()
        {
            TempData["Nombre"] = "Adrian";
            return RedirectToAction("Index2");
        }
        public ActionResult Index2()
        {
            ViewBag.Grupo = "IDGS904";
            ViewData["Materia"] = "DWI";
            string nombre = "";
            if (TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"] as string;
            }
            ViewBag.valor = nombre;

            return View();
        }


    }
}


        