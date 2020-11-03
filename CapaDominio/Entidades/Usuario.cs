using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Usuario
    {
        private string usuarioID;
        private string nombres;
        private string apellidos;
        private string dni;
        private string numeroDeTarjeta;
        private string clave;
        private bool estado;
        private Banco banco;
        private List<Cuenta> listaDeCuentas;


        public Usuario() { }

        public Usuario(string usuarioID, string nombres, string apellidos, string dni, string numeroDeTarjeta, string clave, bool estado, Banco banco, List<Cuenta> listaDeCuentas)
        {
            this.usuarioID = usuarioID;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dni = dni;
            this.numeroDeTarjeta = numeroDeTarjeta;
            this.clave = clave;
            this.estado = estado;
            this.banco = banco;
            this.listaDeCuentas = listaDeCuentas;
        }

        public string UsuarioID { get => usuarioID; set => usuarioID = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string NumeroDeTarjeta { get => numeroDeTarjeta; set => numeroDeTarjeta = value; }
        public string Clave { get => clave; set => clave = value; }
        public bool Estado { get => estado; set => estado = value; }
        public Banco Banco { get => banco; set => banco = value; }
        public List<Cuenta> ListaDeCuentas { get => listaDeCuentas; set => listaDeCuentas = value; }

        public float calcularComision()
        {
            //return 0.5f * dia;
            return 0.0f;
        }



        public bool validarUsuarioID(Usuario usuario)
        {
            if (usuario.UsuarioID == usuarioID)
                return true;
            else
            {
                return false;
            }
        }

        public bool validarNumeroTarjeta(Usuario usuario)
        {
            if (usuario.NumeroDeTarjeta == numeroDeTarjeta)
                return true;
            else
            {
                return false;
            }
        }

        public bool validarClave(Usuario usuario)
        {
            if (usuario.Clave == clave)
                return true;
            else
            {
                return false;
            }
        }
    }
}
