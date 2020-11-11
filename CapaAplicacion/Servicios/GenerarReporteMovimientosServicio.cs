﻿using System;
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

        //sobrescrito de rama mario prueba 1
        public GenerarReporteDeMovimientosServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();

            gestorDatos = fabricaAbstracta.crearGestorAccesoDatos();

            cuentaDAO = fabricaAbstracta.crearCuentaDAO(gestorDatos);

            movimientoDAO = fabricaAbstracta.crearMovimientoDAO(gestorDatos);

            transaccionDAO = fabricaAbstracta.crearTransaccionDAO(gestorDatos);

            usarioDAO = fabricaAbstracta.crearUsuarioDAO(gestorDatos);
        }

        public Movimiento buscarMovimiento(string codigoDeMovimiento)
        {
            gestorDatos.abrirConexion();
            Movimiento movimiento = movimientoDAO.buscarPorCodigo(codigoDeMovimiento);
            gestorDatos.cerrarConexion();
            return movimiento;
        }

        public Transaccion buscarTransaccion(string codigo)
        {
            gestorDatos.abrirConexion();
            Transaccion transaccion = transaccionDAO.buscarPorCodigo(codigo);
            gestorDatos.cerrarConexion();
            return transaccion;
        }

        public void guardarMovimiento(Movimiento movimiento)
        {
            gestorDatos.abrirConexion();
            movimientoDAO.guardarMovimiento(movimiento);
            gestorDatos.cerrarConexion();
        }
    }
}
