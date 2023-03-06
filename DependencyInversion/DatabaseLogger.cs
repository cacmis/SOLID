using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class DatabaseLogger:ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Implementar logica para guiardar en BD");
        }
    }
}