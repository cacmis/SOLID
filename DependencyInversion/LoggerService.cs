using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class LoggerService
    {
        private ILogger logger;

        public LoggerService(ILogger log)
        {
            logger= log;
        }

        public void RegistrarEventos(string message)
        {
            logger.Log(message);
        }
    }
}