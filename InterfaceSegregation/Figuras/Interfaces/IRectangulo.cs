using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregation.Figuras.Interfaces
{
    public interface IRectangulo:IFigura
    {
        double Ancho{get;set;}
         double Alto { get; set; }
    }
}