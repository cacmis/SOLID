using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class FileLogger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Implementar la logica para registrar los usceso en el archivo");
        }
    }
}