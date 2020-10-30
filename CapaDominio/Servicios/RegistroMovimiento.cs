using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Servicios
{
    public class RegistroMovimiento
    {
        public void validarUsuario(Usuario usuario)
        {
            if (!usuario.validarInicioSesion(usuario))
            {
                throw new Exception("ERROR");
            }

        }
    }
}
