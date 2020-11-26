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


        public void validarTransaccion(Transaccion transaccion, Cuenta cuentaOrigen, Cuenta cuentaDestino, String clave)
        {
            if(!cuentaOrigen.compararCuentasID(cuentaOrigen.CuentaID, cuentaDestino.CuentaID))
            {
                throw new Exception("Cuenta destino debe ser diferente a la cuenta origen");
            }

            if (!transaccion.validarMonto(cuentaOrigen))
            {
                throw new Exception("El monto ingresado no es el correcto");
            }
            if (!transaccion.validarValoracion())
            {
                throw new Exception("La valoracion debe ser entre 1 y 5");
            }
            if (!cuentaOrigen.validarCuenta())
            {
                throw new Exception("Su cuenta está Inhabilitada");
            }
            if (!cuentaDestino.validarCuenta())
            {
                throw new Exception("Cuenta Del Destinatario Inhabilitada");
            }
       
        }
        public void verificarMontoDestinatario(Transaccion transaccion, Cuenta cuenta)
        {
            if (!transaccion.validarMontoDestino(cuenta))
            {
                throw new Exception("El monto del destinatario ah superado la maxima cantidad");
            }

        }
        
    }





}

