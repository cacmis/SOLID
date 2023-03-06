using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceSegregation.Figuras.Interfaces;

namespace InterfaceSegregation.Figuras
{
    public class Rectangulo: IRectangulo
    {
        public double Alto { get; set; }
        public double Ancho { get; set; } 

        public CalcularArea()
        {
            return Ancho*Alto;
        }       
    }
}