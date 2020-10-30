using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Contratos
{
    public class IUsuario
    {
        void guardarUsuario(Usuario usuario);
        List<Usuario> obtenerListaDeUsuarios();
        Usuario buscarPorDni(string dni);
    }
}
