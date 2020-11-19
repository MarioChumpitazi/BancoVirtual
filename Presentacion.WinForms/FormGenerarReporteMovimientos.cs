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

        /*
        private void btnBuscarTransaccionesCuentaPropia_Click(object sender, EventArgs e)
        {

            try
            {
                string usuarioID=txtusuarioID.Text;
                string cuentaID = txt_cuentaID.Text;
                double totalTransferidoSoles = 0;
                double totalTransferidoDolares = 0;
                GenerarReporteMovimientosServicio servicioMovimientos = new GenerarReporteMovimientosServicio();
                Movimiento movimiento = new Movimiento();
                RealizarTransaccionServicio servicio = new RealizarTransaccionServicio();
                movimiento.ListaTransacciones = servicioMovimientos.obtenerListaDeTransacciones(cuentaID, true);
                dataMovimientosEntreCuentas.Rows.Clear();

                foreach (Transaccion transaccion in movimiento.ListaTransacciones)
                {

                     Object[] fila = { transaccion.TransaccionID, transaccion.Fecha,  transaccion.Monto, transaccion.Valoracion, transaccion.CuentaOrigen.CuentaID, transaccion.CuentaDestino.CuentaID };

                    Cuenta cuentaDestino = servicio.buscarCuenta(transaccion.CuentaDestino.CuentaID);
                    if (movimiento.ValidarTipoDeMoneda(cuentaDestino))
                    {
                        totalTransferidoSoles = transaccion.Monto + totalTransferidoSoles;
                    }
                    else
                    {
                        totalTransferidoDolares = transaccion.Monto + totalTransferidoDolares;
                    }

                    dataMovimientosEntreCuentas.Rows.Add(fila);
                            dataMovimientosEntreCuentas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                         

                }

                txt_TotalTransferidoSoles.Text = totalTransferidoSoles.ToString();
                txt_TotalTransferidoDolares.Text = totalTransferidoDolares.ToString();
                txt_promedioValorización.Text = movimiento.calcularNivelDeValoracion().ToString();
                txt_NivelMovimiento.Text = movimiento.calcularNivelMovimiento();

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
                double totalTransferidoSoles = 0;
                double totalTransferidoDolares = 0;
                Movimiento movimiento = new Movimiento();
                GenerarReporteMovimientosServicio servicioMovimientos = new GenerarReporteMovimientosServicio();
                DataGridViewRow filas = dataMovimientosEntreCuentas.CurrentRow;
                RealizarTransaccionServicio servicio = new RealizarTransaccionServicio();

                movimiento.ListaTransacciones = servicioMovimientos.obtenerListaDeTransacciones(cuentaID, false);
                dataMovimientosEntreCuentas.Rows.Clear();

                foreach (Transaccion transaccion in movimiento.ListaTransacciones)
                {

                    Object[] fila = { transaccion.TransaccionID, transaccion.Fecha, transaccion.Monto, transaccion.Valoracion, transaccion.CuentaOrigen.CuentaID, transaccion.CuentaDestino.CuentaID };
                    Cuenta cuentaDestino = servicio.buscarCuenta(transaccion.CuentaDestino.CuentaID);
                    if (movimiento.ValidarTipoDeMoneda(cuentaDestino))
                    {
                        totalTransferidoSoles = transaccion.Monto + totalTransferidoSoles;
                    }
                    else
                    {
                        totalTransferidoDolares = transaccion.Monto + totalTransferidoDolares;
                    }

                    dataMovimientosEntreCuentas.Rows.Add(fila);
                    dataMovimientosEntreCuentas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }

                txt_TotalTransferidoSoles.Text = totalTransferidoSoles.ToString();
                txt_TotalTransferidoDolares.Text = totalTransferidoDolares.ToString();
                txt_promedioValorización.Text = movimiento.calcularNivelDeValoracion().ToString();
                txt_NivelMovimiento.Text = movimiento.calcularNivelMovimiento();

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema BancoVirtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      */
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cuentaID = txt_cuentaID.Text;
                string usuarioID = txtusuarioID.Text;
                Movimiento movimiento = new Movimiento();
                GenerarReporteMovimientosServicio servicioMovimientos = new GenerarReporteMovimientosServicio();
                DataGridViewRow filas = dataMovimientosEntreCuentas.CurrentRow;
                RealizarTransaccionServicio servicio = new RealizarTransaccionServicio();
                Cuenta cuenta = new Cuenta();
                String tipoDeMoneda;
                List<Cuenta> listaDeCuentas = servicio.buscarCuentasUsuario(usuarioID);
                int cont = 0;
                foreach (Cuenta cuentaAux in listaDeCuentas)
                {
                    if (cuentaID == cuentaAux.CuentaID)
                    {
                        cont++;
                    }

                }
                cuenta = servicio.buscarCuenta(cuentaID);

                if (cuenta != null)
                {
                    if (cont > 0)
                    {
                        movimiento.ListaTransacciones = servicioMovimientos.obtenerListaDeTransaccionesPorCuenta(cuentaID);

                        dataMovimientosEntreCuentas.Rows.Clear();

                        foreach (Transaccion transaccion in movimiento.ListaTransacciones)
                        {
                            Cuenta cuentaDestino = servicio.buscarCuenta(transaccion.CuentaDestino.CuentaID);
                            if (cuentaDestino.TipoMoneda == true)
                            {
                                tipoDeMoneda = "Sol";
                            }
                            else
                            {
                                tipoDeMoneda = "Dolar";
                            }
                        

                            Object[] fila = { transaccion.TransaccionID, transaccion.Fecha, transaccion.Monto, transaccion.Valoracion, transaccion.CuentaOrigen.CuentaID, transaccion.CuentaDestino.CuentaID,tipoDeMoneda };
                            dataMovimientosEntreCuentas.Rows.Add(fila);
                            dataMovimientosEntreCuentas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        }


                    }
                    else
                    {
                        throw new Exception("La cuenta no esta registrada por el usuario");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema BancoVirtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            string cuentaID = txt_cuentaID.Text;
         
            Movimiento movimiento = new Movimiento();
           
            GenerarReporteMovimientosServicio servicioMovimientos = new GenerarReporteMovimientosServicio();
            RealizarTransaccionServicio servicio = new RealizarTransaccionServicio();
            double totalTransferidoSoles = 0;
            double totalTransferidoDolares = 0;
            movimiento.ListaTransacciones =  servicioMovimientos.obtenerListaDeTransaccionesPorCuenta(cuentaID);
            dataMovimientosEntreCuentas.Rows.Clear();
            String tipoDeMoneda;
            foreach (Transaccion transaccion in movimiento.ListaTransacciones)
            {
                Cuenta cuentaDestino = servicio.buscarCuenta(transaccion.CuentaDestino.CuentaID);
                if (cuentaDestino.TipoMoneda == true)
                {
                    tipoDeMoneda = "Sol";
                }
                else
                {
                    tipoDeMoneda = "Dolar";
                }

                Object[] fila = { transaccion.TransaccionID, transaccion.Fecha, transaccion.Monto, transaccion.Valoracion, transaccion.CuentaOrigen.CuentaID, transaccion.CuentaDestino.CuentaID,tipoDeMoneda };
              //  Cuenta cuentaDestino = servicio.buscarCuenta(transaccion.CuentaDestino.CuentaID);
                    if(movimiento.ValidarTipoDeMoneda(cuentaDestino))
                {
                    totalTransferidoSoles = transaccion.Monto + totalTransferidoSoles;
                }
                else
                {
                    totalTransferidoDolares= transaccion.Monto + totalTransferidoDolares;
                }

                dataMovimientosEntreCuentas.Rows.Add(fila);
                dataMovimientosEntreCuentas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }

            txt_TotalTransferidoSoles.Text = totalTransferidoSoles.ToString();
            txt_TotalTransferidoDolares.Text = totalTransferidoDolares.ToString();

            txt_promedioValorización.Text = movimiento.calcularNivelDeValoracion().ToString();
            txt_NivelMovimiento.Text = movimiento.calcularNivelMovimiento();
        }

        private void FormGenerarReporteMovimientos_Load(object sender, EventArgs e)
        {

        }

        private void dataMovimientosEntreCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
