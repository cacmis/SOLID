using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbiertoCerrado.OrdenCompra
{
    public class Orden
    {
        public List<Producto> Productos { get; set; }
        public decimal Total {get; set;}
    }
    public record Producto(string Nombre, string Descripcion, decimal Precio);
}