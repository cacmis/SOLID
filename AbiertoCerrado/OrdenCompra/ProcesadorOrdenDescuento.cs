
namespace AbiertoCerrado.OrdenCompra
{
    public class ProcesadorOrdenDescuento : IProcesadorOrden
    {
        public decimal PorcentajeDescuento { get; set; }
        public void Procesar(Orden orden)
        {
            orden.Total = orden.Productos.Sum(p => p.Precio);
            orden.Total *= (1-PorcentajeDescuento)/100;
        }
    }
}