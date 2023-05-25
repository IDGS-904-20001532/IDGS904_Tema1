using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Triangulo
    {
        public double X1 { get; set; }

        public double Y1 { get; set; }

        public double X2 { get; set; }

        public double Y2 { get; set; }

        public double X3 { get; set; }

        public double Y3 { get; set; }

        public string Resultado { get; set; }


        public string CalcularTriangulo()
        {
            double resultP1_P2 = 0;
            resultP1_P2 = Math.Round(Math.Sqrt(Math.Pow(this.X2 - this.X1, 2) + Math.Pow(this.Y2 - this.Y1, 2)),1);

            double resultP2_P3 = 0;
            resultP2_P3 = Math.Round(Math.Sqrt(Math.Pow(this.X3 - this.X2, 2) + Math.Pow(this.Y3 - this.Y2, 2)), 1);

            double resultP1_P3 = 0;
            resultP1_P3 = Math.Round(Math.Sqrt(Math.Pow(this.X1 - this.X3, 2) + Math.Pow(this.Y1 - this.Y3, 2)), 1);

            if (resultP1_P2 < resultP2_P3 + resultP1_P3 && resultP2_P3 < resultP1_P2 + resultP1_P3 && resultP1_P3 < resultP1_P2 + resultP2_P3)
            {
                if (resultP1_P2 == resultP2_P3 && resultP2_P3 == resultP1_P3)
                {
                    double semiperimetro = (resultP1_P2 + resultP2_P3 + resultP1_P3) / 2;
                    double area = Math.Sqrt(semiperimetro * (semiperimetro - resultP1_P2) * (semiperimetro - resultP2_P3) * (semiperimetro - resultP1_P3));
                    return "Los puntos forman un triángulo equilátero. Área: " + area;
                }
                else if (resultP1_P2 == resultP2_P3 || resultP2_P3 == resultP1_P3 || resultP1_P2 == resultP1_P3)
                {
                    double semiperimetro = (resultP1_P2 + resultP2_P3 + resultP1_P3) / 2;
                    double area = Math.Sqrt(semiperimetro * (semiperimetro - resultP1_P2) * (semiperimetro - resultP2_P3) * (semiperimetro - resultP1_P3));
                    return "Los puntos forman un triángulo isósceles. Área: " + area;
                }
                else if (resultP1_P2 != resultP2_P3 && resultP2_P3 != resultP1_P3 && resultP1_P2 != resultP1_P3)
                {
                    double semiperimetro = (resultP1_P2 + resultP2_P3 + resultP1_P3) / 2;
                    double area = Math.Sqrt(semiperimetro * (semiperimetro - resultP1_P2) * (semiperimetro - resultP2_P3) * (semiperimetro - resultP1_P3));
                    return "Los puntos forman un triángulo escaleno. Área: " + area;
                }

            }
            else if (resultP1_P2 == resultP2_P3 || resultP2_P3 == resultP1_P3 || resultP1_P2 == resultP1_P3)
            {
                return "Los puntos no forman un triángulo";
            }
            else
            {
                return "Los puntos no forman un triángulo";
            }
            return "";
           // return "Triangulo: P1_P2"+ resultP1_P2 + " P2_P3: "+ resultP2_P3+ " P1_P2: "+ resultP1_P3;
        }


    }
}