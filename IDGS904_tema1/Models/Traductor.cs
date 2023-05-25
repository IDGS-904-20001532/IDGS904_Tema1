using IDGS904_tema1.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace IDGS904_tema1.Models
{
    public class Traductor
    {
            public string Ingles { get; set; }

            public string Español { get; set; }

            public int Option { get; set; }

            public string Resultado { get; set; }

        public string TraducirResultado()
        {
            var arch = new LeerService();
            var palabras = arch.LeerArchivoTraductor();

            if (string.IsNullOrEmpty(this.Ingles.ToLower()))
            {
                return "Debes ingresar en el cuadro de texto la palabra a traducir";
            }

            if (Option == 0)
            {
                return "Debes seleccionar la opción de Ingles o Español";
            }
            else if (Option == 1)
            {
                foreach (string item in palabras)
                {
                    string[] palabrasTraductor = item.Split(',');

                    if (palabrasTraductor.Length == 2 && palabrasTraductor[0].Trim().ToLower() == Ingles.Trim().ToLower())
                    {
                        return "La palabra en Ingles es: " + palabrasTraductor[1].Trim();
                    }
                }

                return "La palabra '" + this.Ingles + "' no fue encontrada. Vuelve a intentarlo";
            }
            else if (Option == 2)
            {
                foreach (string item in palabras)
                {
                    string[] palabrasTraductor = item.Split(',');

                    if (palabrasTraductor.Length == 2 && palabrasTraductor[1].Trim().ToLower() == Ingles.Trim().ToLower())
                    {
                        return "La palabra en Español es: " + palabrasTraductor[0].Trim();
                    }
                }

                return "La palabra '" + this.Ingles.ToLower() + "' no fue encontrada. Vuelve a intentarlo";
            }

            return "";
        }



    }
}