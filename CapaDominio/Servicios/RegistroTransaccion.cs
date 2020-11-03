using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Servicios
{
    public class RegistroTransaccion
    {
        Cuenta cuenta = new Cuenta ();
        public void validarTransaccion(Transaccion transaccion)
        {
            if (!transaccion.validarMonto(cuenta))
            {
                throw new Exception("ERROR en Transaccion");
            }
        }
    }
}
