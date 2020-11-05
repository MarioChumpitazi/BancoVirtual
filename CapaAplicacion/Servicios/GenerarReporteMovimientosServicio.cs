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
    public class GenerarReporteMovimientosServicio
    {
        private IGestorAccesoDatos gestorDatos;
        private ICuenta cuentaDAO;
        private IMovimiento movimientoDAO;
        private ITransaccion transaccionDAO;
        private IUsuario usarioDAO;


        public GenerarReporteMovimientosServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();

            gestorDatos = fabricaAbstracta.crearGestorAccesoDatos();

            cuentaDAO = fabricaAbstracta.crearCuentaDAO(gestorDatos);

            movimientoDAO = fabricaAbstracta.crearMovimientoDAO(gestorDatos);

            transaccionDAO = fabricaAbstracta.crearTransaccionDAO(gestorDatos);

            usarioDAO = fabricaAbstracta.crearUsuarioDAO(gestorDatos);
        }

        public Movimiento buscarMovimientoPorCodigo(string codigoDeMovimiento)
        {
            gestorDatos.abrirConexion();
            Movimiento movimiento = movimientoDAO.buscarPorCodigo(codigoDeMovimiento);
            gestorDatos.cerrarConexion();
            return movimiento;
        }

        public Transaccion buscarTransaccion(string usuarioID, bool tipoTransaccion)
        {
            gestorDatos.abrirConexion();
            Transaccion transaccion = transaccionDAO.buscarTransaccion(usuarioID,tipoTransaccion);
            gestorDatos.cerrarConexion();
            return transaccion;
        }

        public void guardarMovimiento(Movimiento movimiento, string transaccionID)
        {
            gestorDatos.abrirConexion();
            movimientoDAO.guardarMovimiento(movimiento, transaccionID);
            gestorDatos.cerrarConexion();
        }

        public List<Transaccion> obtenerListaDeTransacciones(string usuarioID, bool tipoTransaccion)
        {
            gestorDatos.abrirConexion();
            List<Transaccion> transaccion = transaccionDAO.obtenerListaDeTransacciones(usuarioID, tipoTransaccion);
            gestorDatos.cerrarConexion();
            return transaccion;
        }



    }
}
