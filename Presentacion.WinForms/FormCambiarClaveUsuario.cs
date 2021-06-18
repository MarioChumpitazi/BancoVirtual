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
    public partial class FormCambiarClaveUsuario : Form
    {
        public FormCambiarClaveUsuario()
        {
            InitializeComponent();
        }

        private void FormCambiarClaveUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                string usuarioID = txtusuarioID.Text.Trim();
                string claveActual = txtClaveActualUsuario.Text;
                MantenedorUsuarioServicio servicio = new MantenedorUsuarioServicio();
                Usuario usuario = servicio.buscarUsuario(usuarioID);
                usuario.Clave = txtClaveNuevaUsuario.Text;
                servicio.editarUsuarioClave(usuario);
                MessageBox.Show(this, "Se cambio la clave exitosamente.", "Sistema BancoVirtual", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*if (usuario.validarClave(claveActual))
                {
                    MantenedorUsuarioServicio servicio = new MantenedorUsuarioServicio();
                    usuario.Clave= txtClaveNuevaUsuario.Text;
                    servicio.editarUsuarioClave(usuario);
                    MessageBox.Show(this, "Se cambio la clave exitosamente.", "Sistema BancoVirtual", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Error al ingresar clave de Usuario");
                }
                */
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
                if (txtClaveNuevaUsuario.PasswordChar == '*')
                {
                    //cambiar passwordchar a nulo
                    txtClaveNuevaUsuario.PasswordChar = '\0';
                }
            }
            else
            {
                txtClaveNuevaUsuario.PasswordChar = '*';
            }
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
