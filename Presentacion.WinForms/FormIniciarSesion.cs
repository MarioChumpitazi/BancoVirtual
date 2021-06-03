using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAplicacion.Servicios;
using CapaDominio.Entidades;

namespace Presentacion.WinForms
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
          
        }

        

        public void btnIngresar_Click(object sender, EventArgs e)
        {
            
            string usuarioID = txtUsuario.Text;
            string clave = txtContrasenia.Text.Trim();
            
            try
            {
               
                RealizarTransaccionServicio servicio = new RealizarTransaccionServicio();
                Usuario usuario = servicio.buscarUsuario(usuarioID);
                if (usuario!= null)
                {
                    if (usuario.Clave == clave && usuario.Estado!=false)
                    {
                        FormMenu formMenu = new FormMenu();
                  
                        formMenu.txtusuarioID.Text = usuario.UsuarioID;
                       
                        formMenu.ShowDialog();
                        
                    }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema BancoVirtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

     


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario formRegistrarUsuario = new FormRegistrarUsuario();

            formRegistrarUsuario.ShowDialog();
        }

        private void chcbContraseñaUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chcbContraseñaUsuario.Checked == true)
            {
                if (txtContrasenia.PasswordChar == '*')
                {
                    //cambiar passwordchar a nulo
                    txtContrasenia.PasswordChar = '\0';
                }
            }
            else
            {
                txtContrasenia.PasswordChar = '*';
            }
        }
    }
}
