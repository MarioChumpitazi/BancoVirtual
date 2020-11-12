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
                throw new Exception("El monto ingresado no es el correcto");
            }
            if (!transaccion.validarValoracion())
            {
                throw new Exception("La valoracion debe ser entre 1 y 5");
            }
        }
        public void verificarMontoDestinatario(Transaccion transaccion, Cuenta cuenta)
        {
            if (!transaccion.verificarMontoDestino(cuenta))
            {
                throw new Exception("El monto del destinatario ah superado la maxima cantidad");
            }

        }
        
    }





}

