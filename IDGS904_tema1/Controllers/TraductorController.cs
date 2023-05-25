using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult Traductor()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult LeerDatos()
        {
            

                var arch = new LeerService();
                ViewBag.ArchivoTraductor = arch.LeerArchivoTraductor();
                return View("Traductor");
        }

        [HttpPost]
        public ActionResult Traductor(Traductor trad)
        {
            var ope1 = new GuardarServices();
            ope1.GuardaArchivoTraductor(trad);
            return RedirectToAction("TraducirPalabras", "Traductor");
        }



        public ActionResult TraducirPalabras(Traductor trad)
        {

            if (Request.HttpMethod == "POST")
            {
                var model = new Traductor();
                model.Resultado = trad.TraducirResultado();

                return View(model);
            }
            return View();


        }

    }
}