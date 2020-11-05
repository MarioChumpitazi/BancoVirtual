using CapaDominio.Entidades;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            

            InitializeComponent();
        }

        private void btnRealizarTransferencia_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            FormRealizarTransaccion formRealizarTransaccion = new FormRealizarTransaccion();

            usuario.UsuarioID = txtusuarioID.Text;
            formRealizarTransaccion.txtusuarioID.Text = usuario.UsuarioID;
            formRealizarTransaccion.dataTransaccion.Visible = true;
            DataGridViewRow filas = formRealizarTransaccion.dataTransaccion.CurrentRow;
          

            usuario.UsuarioID = txtusuarioID.Text;
            RealizarTransaccionServicio servicio = new RealizarTransaccionServicio();
            List<Cuenta> listaDeCuentas = servicio.buscarCuentasUsuario(usuario.UsuarioID);
            formRealizarTransaccion.dataTransaccion.Rows.Clear();

            foreach (Cuenta cuenta in listaDeCuentas)
            {
                String moneda = cuenta.TipoMoneda ? "Sol" : "Dolar";
                String estado = cuenta.Estado ? "Habilitado" : "Inhabilitado";
                Object[] fila = { cuenta.CuentaID, cuenta.Saldo, moneda, estado };
                formRealizarTransaccion.dataTransaccion.Rows.Add(fila);
                formRealizarTransaccion.dataTransaccion.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            formRealizarTransaccion.ShowDialog();
        }

        private void btnGenerarReporteMovimientos_Click(object sender, EventArgs e)
        {
             FormGenerarReporteMovimientos formGenerarReporteMovimientos = new FormGenerarReporteMovimientos();
            formGenerarReporteMovimientos.ShowDialog();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
