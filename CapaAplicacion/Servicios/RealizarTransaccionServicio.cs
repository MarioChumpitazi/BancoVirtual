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
    public class RealizarTransaccionServicio
    {
        private IGestorAccesoDatos gestorDatos;
        private ICuenta cuentaDAO;
        private IMovimiento movimientoDAO;
        private ITransaccion transaccionDAO;
        private IUsuario usarioDAO;

        public RealizarTransaccionServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();

            gestorDatos = fabricaAbstracta.crearGestorAccesoDatos();

            cuentaDAO = fabricaAbstracta.crearCuentaDAO(gestorDatos);

            movimientoDAO = fabricaAbstracta.crearMovimientoDAO(gestorDatos);

            transaccionDAO = fabricaAbstracta.crearTransaccionDAO(gestorDatos);

            usarioDAO = fabricaAbstracta.crearUsuarioDAO(gestorDatos);
        }

        public List<Cuenta> buscarCuentasUsuario(string usuarioID)
        {
            gestorDatos.abrirConexion();
            List<Cuenta> cuentas = cuentaDAO.buscarCuentasDelUsuario(usuarioID);
            gestorDatos.cerrarConexion();
            return cuentas;
        }

        public Cuenta buscarCuenta(string cuentaID)
        {
            gestorDatos.abrirConexion();
            Cuenta cuenta = cuentaDAO.buscarPorNumeroCuenta(cuentaID);
            gestorDatos.cerrarConexion();
            return cuenta;
        }

        /*public Movimiento buscarMovimiento(string codigo)
        {
            gestorDatos.abrirConexion();
            Movimiento movimiento = movimientoDAO.buscarPorCodigo(codigo);
            gestorDatos.cerrarConexion();
            return movimiento;
        }*/
        public Usuario buscarUsuario(string dni)
        {
            gestorDatos.abrirConexion();
            Usuario usuario = usarioDAO.buscarPorDni(dni);
            gestorDatos.cerrarConexion();
            return usuario;
        }
        public void guardarTransaccion(Transaccion transaccion)
        {
            RegistroTransaccion registroDeTransaccion = new RegistroTransaccion();
            registroDeTransaccion.validarTransaccion(transaccion);
            gestorDatos.iniciarTransaccion();
            transaccionDAO.guardarTransaccion(transaccion);
            gestorDatos.terminarTransaccion();
        }
    }
}
