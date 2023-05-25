using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class DistanciaPuntosController : Controller
    {
        // GET: DistanciaPuntos
         public ActionResult DistanciaPuntos(CalcularPuntos op)
         {
            //var model = new CalcularPuntos();
            //model.Res = op.resultado();
            //return View(model);
            if (op.x1 == 0)
            {
                return View();
            }
            else {
                return RedirectToAction("calcularDistanciaPuntos", "DistanciaPuntos", op);
            }
            
         }

        public ActionResult calcularDistanciaPuntos(CalcularPuntos cp)
        {
            double distancia = cp.resultado();
            TempData["ResultadoDistancia"]= distancia.ToString();
            return Redirect("ResultadoDistancia");
        }

        public ViewResult ResultadoDistancia()
        {
            if (TempData.ContainsKey("ResultadoDistancia")) 
            {
                ViewBag.ResultadoDistancia = TempData["ResultadoDistancia"] as string;
                
            }
            return View();
        }
       
    }
}