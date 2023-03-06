using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SustitucionLiskov
{
    public class Cuadrado : Figura
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}