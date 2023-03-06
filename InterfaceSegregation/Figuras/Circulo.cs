using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  InterfaceSegregation.Figuras.Interfaces;

namespace InterfaceSegregation.Figuras
{
    public class Circulo: ICirculo
    {
        public double Radio {get;set;}

        public double CalcularArea()
        {
            return Radio*Radio*Math.PI;
        }
    }
}