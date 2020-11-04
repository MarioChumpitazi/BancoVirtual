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

                    if (usuario1.UsuarioID == usuario2.UsuarioID) { 
                        transaccion.TipoTransaccion = true;
                       }  else
                         {
                        transaccion.TipoTransaccion = false;
                           }
                    cuenta1.Saldo = cuenta1.Saldo - transaccion.Monto;
                    txtMontoDescontado.Text = transaccion.Monto.ToString();
                    transaccion.Monto = transaccion.calcularMontoTotal();
                    transaccion.Monto = transaccion.calcularTransferencia(cuenta1,cuenta2);
                    txtMontoTransferido.Text= transaccion.Monto.ToString();
                    cuenta2.Saldo = cuenta2.Saldo + transaccion.Monto;
                    servicio.guardarTransaccion(transaccion,cuentaOrigenID,cuentaDestinoID, cuenta1);
                    servicio.GuardarNuevoSaldo(cuenta1);
                    servicio.GuardarNuevoSaldo(cuenta2);
                   
                    fila.Cells[1].Value = cuenta1.Saldo;
                  
                    int cont = 0;
                   
                        foreach (DataGridViewRow filas in dataTransaccion.Rows)
                        {
                      
                            cont = cont + 1;
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
                    txtComision.Text = transaccion.calcularComision().ToString();



                    if (transaccion != null)
                    {

                        MessageBox.Show("Transaccion exitosa");
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
