using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Conversion
    {
        public double Grados { get; set; }

        public double Fahrenheit { get; set; }

        public double Calculo_G_F()
        {
            double resultado = 0;

            resultado = ((this.Fahrenheit) - 32) * 5 / 9;

            return resultado;

        }

        public double Calculo_F_G()
        {
            double resultado = 0;

        //resultado = (this.Grados * 9 / 5) + 32 = 32 °F


            return resultado;

        }


    }
}