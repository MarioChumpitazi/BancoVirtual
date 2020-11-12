using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAplicacion.Servicios;
using CapaDominio.Entidades;


namespace Presentacion.WinForms
{
    public partial class FormGenerarReporteMovimientos : Form
    {
        public FormGenerarReporteMovimientos()
        {
            InitializeComponent();

        }


        private void btnBuscarTransaccionesCuentaPropia_Click(object sender, EventArgs e)
        {

            try
            {
                string usuarioID=txtusuarioID.Text;
                string cuentaID = txt_cuentaID.Text;
                GenerarReporteMovimientosServicio servicioMovimientos = new GenerarReporteMovimientosServicio();

                Movimiento movimiento= new Movimiento();
                DataGridViewRow filas = dataMovimientosEntreCuentas.CurrentRow;
                RealizarTransaccionServicio servicio = new RealizarTransaccionServicio();

                List<Cuenta> listaDeCuentas = servicio.buscarCuentasUsuario(usuarioID);
                dataMovimientosEntreCuentas.Rows.Clear();
                List<Transaccion> listadeTransacciones = servicioMovimientos.obtenerListaDeTransacciones(cuentaID, true);
                dataMovimientosEntreCuentas.Rows.Clear();

   
                    foreach (Transaccion transaccion in listadeTransacciones)
                    {

                            Object[] fila = { transaccion.TransaccionID, transaccion.Fecha,  transaccion.Monto, transaccion.Valoracion, transaccion.CuentaOrigen.CuentaID, transaccion.CuentaDestino.CuentaID };
                            dataMovimientosEntreCuentas.Rows.Add(fila);
                            dataMovimientosEntreCuentas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
               

                }

                // movimiento.mes = DateTime.Now;
               // servicioMovimientos.guardarMovimiento(movimiento, transaccion.TransaccionID);


            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema BancoVirtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscarTransaccionesOtraCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioID = txtusuarioID.Text;
                string cuentaID = txt_cuentaID.Text;
                Movimiento movimiento = new Movimiento();
                GenerarReporteMovimientosServicio servicioMovimientos = new GenerarReporteMovimientosServicio();

                DataGridViewRow filas = dataMovimientosEntreCuentas.CurrentRow;
                RealizarTransaccionServicio servicio = new RealizarTransaccionServicio();

             
                movimiento.ListaTransacciones = servicioMovimientos.obtenerListaDeTransacciones(cuentaID, false);
                dataMovimientosEntreCuentas.Rows.Clear();


                foreach (Transaccion transaccion in movimiento.ListaTransacciones)
                {

                    Object[] fila = { transaccion.TransaccionID, transaccion.Fecha, transaccion.Monto, transaccion.Valoracion, transaccion.CuentaOrigen.CuentaID, transaccion.CuentaDestino.CuentaID };
                    dataMovimientosEntreCuentas.Rows.Add(fila);
                    dataMovimientosEntreCuentas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema BancoVirtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string cuentaID = txt_cuentaID.Text;
            Movimiento movimiento = new Movimiento();
            GenerarReporteMovimientosServicio servicioMovimientos = new GenerarReporteMovimientosServicio();


            DataGridViewRow filas = dataMovimientosEntreCuentas.CurrentRow;
            RealizarTransaccionServicio servicio = new RealizarTransaccionServicio();

           movimiento.ListaTransacciones = servicioMovimientos.obtenerListaDeTransaccionesPorCuenta(cuentaID);
            dataMovimientosEntreCuentas.Rows.Clear();


            foreach (Transaccion transaccion in movimiento.ListaTransacciones)
            {

                Object[] fila = { transaccion.TransaccionID, transaccion.Fecha, transaccion.Monto, transaccion.Valoracion, transaccion.CuentaOrigen.CuentaID, transaccion.CuentaDestino.CuentaID };
                dataMovimientosEntreCuentas.Rows.Add(fila);
                dataMovimientosEntreCuentas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            string cuentaID = txt_cuentaID.Text;
         
            Movimiento movimiento = new Movimiento();
            GenerarReporteMovimientosServicio servicioMovimientos = new GenerarReporteMovimientosServicio();

            movimiento.ListaTransacciones =  servicioMovimientos.obtenerListaDeTransaccionesPorCuenta(cuentaID);
            dataMovimientosEntreCuentas.Rows.Clear();
            foreach (Transaccion transaccion in movimiento.ListaTransacciones)
            {

                Object[] fila = { transaccion.TransaccionID, transaccion.Fecha, transaccion.Monto, transaccion.Valoracion, transaccion.CuentaOrigen.CuentaID, transaccion.CuentaDestino.CuentaID };
                dataMovimientosEntreCuentas.Rows.Add(fila);
                dataMovimientosEntreCuentas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }


            txt_TotalTransferido.Text = movimiento.calcularTotalMontoTransferido().ToString();
            txt_promedioValorización.Text = movimiento.calcularNivelDeValoracion();
            txt_NivelMovimiento.Text = movimiento.calcularNivelMovimiento();
        }
    }
}
