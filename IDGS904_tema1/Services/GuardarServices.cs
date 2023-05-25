using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class GuardarServices
    {
        public void GuardaArchivo(Maestros maes)
        {
            var nombre = maes.Nombre;
            var apterno = maes.Apaterno;
            var amaterno = maes.Apaterno;
            var edad=maes.Edad;
            var email=maes.Email;
            var datos=nombre+","+apterno+","+amaterno+","+edad+","+email+ Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            //File.WriteAllText(archivo, datos);
            File.AppendAllText(archivo, datos); 
        }

        public void GuardaArchivoTraductor(Traductor trad)
        {
            var espanol = trad.Español;
            var ingles = trad.Ingles;
            var datosTraductor = espanol + "," + ingles + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            //File.WriteAllText(archivo, datos);
            File.AppendAllText(archivo, datosTraductor);
        }
    }
}