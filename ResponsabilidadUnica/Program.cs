// See https://aka.ms/new-console-template for more information
using ResponsabilidadUnica;

Console.WriteLine("Hello, World!");

// clase que nos represente cliente (nombre, apellido, direccion)
// validar que los datos de entrada sean valido
//

var cliente = new Cliente();
cliente.Nombre="Misael";
cliente.Apellidos="Cazarez";

var validadorCliente= new ValidarCliente();
var resultado=validadorCliente.Validar(cliente);
