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
       

        public void validarTransaccion(Transaccion transaccion, Cuenta cuenta)
        {
            if (!transaccion.validarMonto(cuenta))
            {
                throw new Exception("El monto a transferir es mayor que el saldo que tiene");
            }

        

        }





    }
}
