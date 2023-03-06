using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SustitucionLiskov
{
    public class Rectangulo: Figura
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public override double CalcularArea()
        {
            return Ancho * Alto;
        }
    }
}