using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDominio.Contratos;
using CapaDominio.Entidades;
using CapaDominio.Servicios;
using CapaPersistencia.FabricaDatos;

namespace CapaAplicacion.Servicios
{
    public class MantenedorUsuarioServicio
    {
        private IGestorAccesoDatos gestorDatos;
        private IUsuario usuarioDAO;

        public MantenedorUsuarioServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();
            gestorDatos = fabricaAbstracta.crearGestorAccesoDatos();
            usuarioDAO = fabricaAbstracta.crearUsuarioDAO(gestorDatos);
        }

        public void guardarUsuario(Usuario usuario)
        {
            RegistroUsuario registroUsuario = new RegistroUsuario();
            registroUsuario.validarUsuario(usuario);
            gestorDatos.iniciarTransaccion();
            usuarioDAO.guardarUsuario(usuario);
            gestorDatos.terminarTransaccion();
        }

        public Usuario buscarUsuario(string usuarioID)
        {
            gestorDatos.abrirConexion();
            Usuario usuario = usuarioDAO.buscarPorID(usuarioID);
            gestorDatos.cerrarConexion();
            return usuario;
        }

        public void editarUsuarioClave(Usuario usuario)
        {
            RegistroUsuario registroUsuario = new RegistroUsuario();
            gestorDatos.iniciarTransaccion();
            usuarioDAO.editarUsuarioClave(usuario);
            gestorDatos.terminarTransaccion();
        }

        public void anularUsuario(Usuario usuario)
        {
            RegistroUsuario registroUsuario = new RegistroUsuario();
            //registroUsuario.validarUsuario(usuario);
            gestorDatos.iniciarTransaccion();
            usuarioDAO.anularUsuario(usuario);
            gestorDatos.terminarTransaccion();
        }
        public Boolean validarNumeroDeTarjeta(string numeroDeTarjeta)
        {
            gestorDatos.abrirConexion();
            Usuario usuario = usuarioDAO.buscarPorID(numeroDeTarjeta);
            gestorDatos.cerrarConexion();
            return true;
        }
    }
}
