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
        public void validarTransaccion(Transaccion transaccion, Usuario usuario, Cuenta cuenta, float monto)
        {
            if (!transaccion.validarMonto(monto,cuenta))
            {
                throw new Exception("El monto a transferir es superior al saldo de la Cuenta");
            }
            if (!transaccion.existeUsuario(usuario))
            {
                throw new Exception("El Usuario no existe");
            }
        }
        //12312
        //123
    }
}
