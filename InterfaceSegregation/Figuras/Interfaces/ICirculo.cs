using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregation.Figuras.Interfaces
{
    public interface ICirculo:IFigura
    {
        double  Radio {get; set;}
    }
}