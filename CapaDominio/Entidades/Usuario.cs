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

        private List<Cuenta> listaDeCuentas;

        public Usuario() { }

        public Usuario(string usuarioID, string nombres, string apellidos, string dni, string numeroDeTarjeta, string clave)
        {
            listaDeCuentas = new List<Cuenta>();
            this.usuarioID = usuarioID;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.dni = dni;
            this.numeroDeTarjeta = numeroDeTarjeta;
            this.clave = clave;
            this.estado = true;
        }

        public string UsuarioID { get => usuarioID; set => usuarioID = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string NumeroDeTarjeta { get => numeroDeTarjeta; set => numeroDeTarjeta = value; }
        public string Clave { get => clave; set => clave = value; }
        public bool Estado { get => estado; set => estado = value; }
        public List<Cuenta> ListaDeCuentas { get => listaDeCuentas; set => listaDeCuentas = value; }

        /*
        public float calcularComision()
        {
            //return 0.5f * dia;
            return 0.0f;
        }

        /*
        public float calcularComisionCuentas()
        {
            float comision = 0.0f;
            foreach (var cuenta in listaDeCuentas)
            {
                comision += cuenta.calcularComision();
            }
            return comision;
        }

        /*
        public bool validarInicioSesion(Usuario usuario)
        {
            return usuario.UsuarioID == dni && usuario.NumeroDeTarjeta == numeroDeTarjeta && usuario.Clave == clave;
        }
        */

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

        

        public bool existeCuenta(Cuenta cuentaAux)
        {
            string existenteID;
            foreach(Cuenta cuenta in listaDeCuentas)
            {
                existenteID = cuenta.CuentaID;
                if(existenteID == cuentaAux.CuentaID)
                {
                    return true;
                }
            }
            return false;
        }

        public Cuenta buscarCuentaID(Cuenta cuenta)
        {
            if (existeCuenta(cuenta))
            {
               return cuenta;
            }
            
            return null;
        }
        
    }
}
