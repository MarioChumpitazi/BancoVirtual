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
                throw new Exception("ERROR Usuario ID");
            }

            if (!usuario.validarNumeroTarjeta(usuario))
            {
                throw new Exception("ERROR Numero de Tarjeta");
            }

            if (!usuario.validarClave(usuario))
            {
                throw new Exception("ERROR Clave Usuario");
            }


        }
    }
}
