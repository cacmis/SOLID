
namespace AbiertoCerrado.Figuras
{
    public class Circulo: IFigura
    {
        public  double Radio {get;set;}
        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }
}