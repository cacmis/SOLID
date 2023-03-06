using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbiertoCerrado.Figuras
{
    public class Rectangulo : IFigura
    {
        public double Altura { get; set; }
        public double Ancho { get; set; }
        public double CalcularArea()
        {
            return Altura * Ancho;
        }
    }
}