
using SustitucionLiskov;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Principio de Sustitución de Liskov");

List<Figura> figuras = new List<Figura>();

figuras.Add(new Cuadrado{Lado=4});
figuras.Add(new Rectangulo{Ancho=5,Alto=3});

foreach(var figura in figuras)
{
    Console.WriteLine($"Area: {figura.CalcularArea()}");
}







