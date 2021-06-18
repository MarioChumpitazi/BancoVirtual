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
    public partial class FormRegistrarCuenta : Form
    {
        /*private Cuenta cuenta;
        private Usuario usuario;*/
        public FormRegistrarCuenta()
        {
            InitializeComponent();
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
  
            try
            {
                string usuarioID = txtusuarioID.Text;
                Cuenta cuenta = new Cuenta();
                

                cuenta.Saldo = double.Parse(txtSaldoCuenta.Text.Trim());
                //cuenta.TipoMoneda = true;
                cuenta.Clave = txtClaveCuenta.Text;

                
                if (chkDolar.Checked==true)
                {
                    cuenta.TipoMoneda = false;
                }
                else
                {
                    cuenta.TipoMoneda = true;
                }



                MantenedorUsuarioServicio serivicioU = new MantenedorUsuarioServicio();
                Usuario usuario = serivicioU.buscarUsuario(usuarioID);
                cuenta.Usuario = usuario;

                MantenedorCuentaServicio servicio = new MantenedorCuentaServicio();
                cuenta.Estado = true;
                servicio.guardarCuenta(cuenta);
                


                if (cuenta != null)
                {
                    MessageBox.Show("Se guardo la cuenta");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema BancoVirtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkMostrarClaveCuenta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarClaveCuenta.Checked == true)
            {
                if (txtClaveCuenta.PasswordChar == '*')
                {
                    //cambiar passwordchar a nulo
                    txtClaveCuenta.PasswordChar = '\0';
                }
            }
            else
            {
                txtClaveCuenta.PasswordChar = '*';
            }
        }
    }
}
