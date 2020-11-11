using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Banco
    {
        private string bancoID;
        private string nombreBanco;

        private List<Usuario> listaDeUsuarios;

        public Banco(string bancoID, string nombreBanco)
        {
            listaDeUsuarios = new List<Usuario>();
            this.bancoID = bancoID;
            this.nombreBanco = nombreBanco;
        }

        public string BancoID { get => bancoID; set => bancoID = value; }
        public string NombreBanco { get => nombreBanco; set => nombreBanco = value; }
        public List<Usuario> ListaDeUsuarios { get => listaDeUsuarios; set => listaDeUsuarios = value; }

        public Usuario buscarUsuario(Usuario usuarioAux)
        {
            Usuario existente=usuarioAux;
            foreach (Usuario usuario in listaDeUsuarios)
            {
                if (usuario.UsuarioID == existente.UsuarioID)
                    return usuario;
            }
            return null;
        }
        public bool validarUsuario(Usuario usuario)
        {
            foreach (var user in listaDeUsuarios)
            {
                if (user == usuario)
                    return false;
            }
            return true;
        }
        public void agregarUsuario(Usuario usuario)
        {
            listaDeUsuarios.Add(usuario);
        }

        public Usuario iniciarSesion(string numeroTajeta, string usuarioID, string clave)
        {
            foreach (var usuario in listaDeUsuarios)
            {
                if (usuario.NumeroDeTarjeta == numeroTajeta && usuario.UsuarioID == usuarioID && usuario.Clave == clave)
                    return usuario;
            }
            return null;
        }
    }
}
