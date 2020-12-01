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
    public partial class FormRealizarTransaccion : Form
    {
        public FormRealizarTransaccion()
        {
           
            InitializeComponent();

            }
        static class Intentos
        {
            public static int intento = 0;
        }
        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            string idCuentaDestino = text_idDestino.Text.Trim();
            try
            {
                RealizarTransaccionServicio servicio = new RealizarTransaccionServicio();
                Cuenta cuenta = servicio.buscarCuenta(idCuentaDestino);
                Usuario usuario = servicio.buscarUsuarioPorCuenta(idCuentaDestino);
               

                textNombre.Text = usuario.Nombres;
                String estado = cuenta.Estado ? "Habilitado" : "Inhabilitado";
                textEstado.Text = estado;

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema BancoVirtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnEntreCuentas_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = dataTransaccion.CurrentRow;
                if (fila != null)
                {
                    string cuentaOrigenID;
                    string cuentaDestinoID;

                    Transaccion transaccion = new Transaccion();
                    transaccion.Monto = double.Parse(txtMonto.Text.Trim());
                    transaccion.Fecha = DateTime.Now;
                    transaccion.Valoracion = int.Parse(txtValoracion.Text.Trim());

                    cuentaOrigenID = fila.Cells[0].Value.ToString();
                    cuentaDestinoID = text_idDestino.Text.Trim();
                    RealizarTransaccionServicio servicio = new RealizarTransaccionServicio();
                    Cuenta cuentaOrigen = servicio.buscarCuenta(cuentaOrigenID);
                    Cuenta cuentaDestino = servicio.buscarCuenta(cuentaDestinoID);
                    Usuario usuario1 = servicio.buscarUsuarioPorCuenta(cuentaOrigenID);
                    Usuario usuario2 = servicio.buscarUsuarioPorCuenta(cuentaDestinoID);
                    transaccion.TipoTransaccion = transaccion.validarTipoTransaccion(usuario1.UsuarioID,usuario2.UsuarioID);

                   String clave = txtVerificarClave.Text;
                   if (Intentos.intento < 3)
                      {
                        if (cuentaOrigen.validarClave(clave))
                        {
                            double MontoAuxiliar = transaccion.calcularMontoTotal();
                            cuentaOrigen.Saldo = cuentaOrigen.Saldo - MontoAuxiliar;
                            transaccion.Monto = transaccion.calcularTransferencia(cuentaOrigen, cuentaDestino);
                            cuentaDestino.Saldo = cuentaDestino.Saldo + transaccion.Monto;

                            servicio.guardarTransaccion(transaccion, cuentaOrigenID, cuentaDestinoID, cuentaOrigen, cuentaDestino,clave);
                            servicio.GuardarNuevoSaldo(cuentaOrigen);
                            servicio.GuardarNuevoSaldo(cuentaDestino);
                            fila.Cells[1].Value = cuentaOrigen.Saldo;
                            foreach (DataGridViewRow filas in dataTransaccion.Rows)
                            {
                                if (filas.Cells[0].Value.ToString() == cuentaDestino.CuentaID)
                                {
                                    filas.Cells[1].Value = cuentaDestino.Saldo;
                                }
                            }

                            txtComision.Text = transaccion.calcularComision().ToString();
                            txtMontoDescontado.Text = transaccion.Monto.ToString();
                            txtMontoTransferido.Text = transaccion.Monto.ToString();
                            txtCuentaOrigen.Text = cuentaOrigen.CuentaID.ToString();
                            txtCuentaDestino.Text = cuentaDestino.CuentaID.ToString();
                            txtNombreUsuario.Text = usuario1.Nombres.ToString();
                            txtApellidosUsuario.Text = usuario1.Apellidos.ToString();
                            String monedaOrigen = cuentaOrigen.TipoMoneda ? "Sol" : "Dolar";
                            txtTipoMoneda.Text = monedaOrigen;
                            String monedaDestino = cuentaDestino.TipoMoneda ? "Sol" : "Dolar";
                            txtMonedaDestino.Text = monedaDestino;
                            if (transaccion != null)
                            {
                                MessageBox.Show("Se realizo la transferencia");
                            }
                        }else{
                            Intentos.intento++;
                            txtintento.Text = Intentos.intento.ToString();
                            throw new Exception("Error al ingresar clave de cuenta");
                        }
                   }else{
                        servicio.InhabilitarCuenta(cuentaOrigen);
                        if (Intentos.intento >= 3)
                        {
                            Intentos.intento = 0;
                        }
                        throw new Exception("Ha excedido el numero de errores, Su cuenta ah sido inhabilitada por el momento");
                    }
                }
            } catch (Exception err)
            {

                MessageBox.Show(this, err.Message, "Sistema BancoVirtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
