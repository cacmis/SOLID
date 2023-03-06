using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbiertoCerrado.OrdenCompra
{
    public interface IProcesadorOrden
    {
        void Procesar(Orden orden);
    }
}