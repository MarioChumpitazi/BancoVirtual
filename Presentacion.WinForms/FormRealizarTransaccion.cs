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
                    string cuentaorigenID;
                    string cuentadestinoID;
                    Transaccion transaccion = new Transaccion();
                    transaccion.Monto = double.Parse(txtMonto.Text.Trim());
                    transaccion.Fecha = DateTime.Now;
                    transaccion.TipoTransaccion = true;
                    transaccion.Valoracion = int.Parse(txtValoracion.Text.Trim());
                    cuentaorigenID= fila.Cells[0].Value.ToString();
                  

                   cuentadestinoID = text_idDestino.Text.Trim();


                    RealizarTransaccionServicio servicio = new RealizarTransaccionServicio();
                    Cuenta cuenta = servicio.buscarCuenta(cuentaorigenID);
                  

                    servicio.guardarTransaccion(transaccion,cuentaorigenID,cuentadestinoID,cuenta);

                    if (transaccion != null)
                    {

                        MessageBox.Show("Funciona");
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

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormRealizarTransaccion_Load(object sender, EventArgs e)
        {

        }
    }
}
