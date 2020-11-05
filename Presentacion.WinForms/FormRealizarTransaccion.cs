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
            public static int intento=0;
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
                    Cuenta cuenta1 = servicio.buscarCuenta(cuentaOrigenID);
                    Cuenta cuenta2 = servicio.buscarCuenta(cuentaDestinoID);
                    Usuario usuario1 = servicio.buscarUsuarioPorCuenta(cuentaOrigenID);
                    Usuario usuario2 = servicio.buscarUsuarioPorCuenta(cuentaDestinoID);

                    if (usuario1.UsuarioID == usuario2.UsuarioID)
                    {
                        transaccion.TipoTransaccion = true;
                    }
                    else
                    {
                        transaccion.TipoTransaccion = false;
                    }
                  
                 
                    String cuentaaux = txtVerificarCuenta.Text;

                    if (Intentos.intento<3)
                    {
                        if (txtVerificarCuenta.Text != "")
                        {
                            if (cuenta1.verificarCuenta(cuentaaux) == true)
                            {
                                txtComision.Text = transaccion.calcularComision().ToString();
                                txtMontoDescontado.Text = transaccion.Monto.ToString();
                                double MontoAuxiliar = transaccion.calcularMontoTotal();
                                cuenta1.Saldo = cuenta1.Saldo - MontoAuxiliar;
                                transaccion.Monto = transaccion.calcularTransferencia(cuenta1, cuenta2);
                                txtMontoTransferido.Text = transaccion.Monto.ToString();
                                cuenta2.Saldo = cuenta2.Saldo + transaccion.Monto;


                                servicio.guardarTransaccion(transaccion, cuentaOrigenID, cuentaDestinoID, cuenta1);

                                servicio.GuardarNuevoSaldo(cuenta1);
                                servicio.GuardarNuevoSaldo(cuenta2);

                                fila.Cells[1].Value = cuenta1.Saldo;

                                foreach (DataGridViewRow filas in dataTransaccion.Rows)
                                {

                                   
                                    if (filas.Cells[0].Value.ToString() == cuenta2.CuentaID)
                                    {
                                        filas.Cells[1].Value = cuenta2.Saldo;

                                    }


                                }

                                txtCuentaOrigen.Text = cuenta1.CuentaID.ToString();
                                txtCuentaDestino.Text = cuenta2.CuentaID.ToString();
                                txtNombreUsuario.Text = usuario1.Nombres.ToString();
                                txtApellidosUsuario.Text = usuario1.Apellidos.ToString();
                                txtTipoMoneda.Text = cuenta1.TipoMoneda.ToString();

                                if (transaccion != null)
                                {

                                    MessageBox.Show("Transaccion exitosa");
                                }
                            }else
                        {
                            MessageBox.Show("Error al ingresar Codigocuenta");
                            Intentos.intento = Intentos.intento + 1;

                        }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese su clave de cuenta para realizar transaccion");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Ha excedido el numero de errores");

                    }
                } 
            }
            
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema BancoVirtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTercero_Click(object sender, EventArgs e)
        {

            txtComision.Text = dataTransaccion.Rows.Count.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormRealizarTransaccion_Load(object sender, EventArgs e)
        {

        }
    }
}
