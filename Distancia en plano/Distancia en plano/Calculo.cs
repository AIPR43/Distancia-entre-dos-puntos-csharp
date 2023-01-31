using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia_en_plano
{
    internal class Calculo
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double resultado { get; set; }


        public Calculo (double x1, double x2, double y1, double y2, double resultado)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.resultado = resultado;
        }

        public Calculo()
        {
        }

        public double operacion(double x1, double x2, double y1, double y2)
        {
            this.resultado = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
            return resultado;
        }
    }
}
