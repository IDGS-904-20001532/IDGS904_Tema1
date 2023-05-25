using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class LeerService
    {
        public Array LeerArchivo()
        {
            Array datos = null;
            var inforMaes = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if (File.Exists(inforMaes))
            {
                datos = File.ReadAllLines(inforMaes);
            }
            return datos;
        }

        public Array LeerArchivoTraductor()
        {
            Array traductor = null;
            var inforMaes = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            if (File.Exists(inforMaes))
            {
                traductor = File.ReadAllLines(inforMaes);
            }
            return traductor;
        }

    }
}