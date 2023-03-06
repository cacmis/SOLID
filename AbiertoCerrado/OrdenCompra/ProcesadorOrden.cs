using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbiertoCerrado.OrdenCompra
{
    public class ProcesadorOrden : IProcesadorOrden
    {
        public void Procesar(Orden orden)
        {
            foreach(var producto in orden.Productos)
            {
                orden.Total += producto.Precio;
            }
            orden.Total = orden.Productos.Sum(p => p.Precio);
        }
    }
}