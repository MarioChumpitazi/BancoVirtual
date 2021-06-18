using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDominio.Contratos;
using CapaDominio.Entidades;
using CapaDominio.Servicios;
using CapaPersistencia.ADO_SQLServer;
using CapaPersistencia.FabricaDatos;

namespace CapaAplicacion.Servicios
{
    public class MantenedorCuentaServicio
    {
        private IGestorAccesoDatos gestorDatos;
        private ICuenta cuentaDAO;
        private IUsuario usarioDAO;

        public MantenedorCuentaServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();

            gestorDatos = fabricaAbstracta.crearGestorAccesoDatos();

            cuentaDAO = fabricaAbstracta.crearCuentaDAO(gestorDatos);

            usarioDAO = fabricaAbstracta.crearUsuarioDAO(gestorDatos);
        }

        public void guardarCuenta(Cuenta cuenta)
        {
            RegistroCuenta registrocuenta = new RegistroCuenta();
            //registrocuenta.guardarCuenta(cuenta);
            gestorDatos.iniciarTransaccion();
            cuentaDAO.guardarCuenta(cuenta);
            gestorDatos.terminarTransaccion();
        }

        public Cuenta buscarCuenta(string cuentaID)
        {
            gestorDatos.abrirConexion();
            Cuenta cuenta = cuentaDAO.buscarPorID(cuentaID);
            gestorDatos.cerrarConexion();
            return cuenta;
        }

        public void editarCuentaClave(Cuenta cuenta)
        {
            RegistroCuenta registroCuenta = new RegistroCuenta();
            gestorDatos.iniciarTransaccion();
            cuentaDAO.editarCuentaClave(cuenta);
            gestorDatos.terminarTransaccion();
        }

        public void anularCuenta(Cuenta cuenta)
        {
            RegistroCuenta registroCuenta = new RegistroCuenta();
            //registroUsuario.validarUsuario(usuario);
            gestorDatos.iniciarTransaccion();
            cuentaDAO.anularCuenta(cuenta);
            gestorDatos.terminarTransaccion();
        }
    }
}
