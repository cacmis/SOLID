using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResponsabilidadUnica
{
    public class ValidarCliente
    {
        public bool Validar(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nombre))
            {
                return false;
            }
            if (string.IsNullOrEmpty(cliente.Apellidos))
            {
                return false;
            }
            if (string.IsNullOrEmpty(cliente.Direccion))
            {
                return false;
            }
            return true;
        }
    }
}