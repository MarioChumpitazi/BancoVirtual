using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Servicios
{
    public class RegistroUsuario
    {
        public void validarUsuario(Usuario usuario)
        {
            if (!usuario.validarUsuarioID(usuario))
            {
                throw new Exception("ERROR en Usuario ID");
            }

            if (!usuario.validarNumeroTarjeta(usuario))
            {
                throw new Exception("ERROR en Numero de Tarjeta");
            }

            if (!usuario.validarClave(usuario))
            {
                throw new Exception("ERROR en Clave Usuario");
            }


        }
    }
}
