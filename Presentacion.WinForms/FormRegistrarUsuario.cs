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
    public partial class FormRegistrarUsuario : Form
    {
        public FormRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
             
                usuario.Nombres = txtNombreUsuario.Text;
                usuario.Apellidos = txtApellidosUsuario.Text;
                usuario.Dni = txtDniUsuario.Text;


                usuario.Clave = txtClaveUsuario.Text;
                usuario.Estado = true;
                usuario.NumeroDeTarjeta = txtNumeroDeTarjeta.Text;
                //string numeroDeTarjeta = txtNumeroDeTarjeta.Text;
                MantenedorUsuarioServicio servicio = new MantenedorUsuarioServicio();
                servicio.guardarUsuario(usuario);
                if (usuario != null)
                {
                    MessageBox.Show("Se guardo el usuario");
                }
                /*if(usuario.validarNumeroDeTarjeta(numeroDeTarjeta))
                {
                    servicio.guardarUsuario(usuario);
                    if (usuario != null)
                    {
                        MessageBox.Show("Se guardo el usuario");
                    }
                }
                else
                {
                    throw new Exception("Error al ingresar el Numero de Tarjeta");
                }*/
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema BancoVirtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
