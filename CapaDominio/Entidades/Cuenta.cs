using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{

    public class Cuenta
    {
        private string cuentaID;
        private double saldo;
        private bool tipoMoneda;
        private bool estado;
        private Usuario usuario;



        public Cuenta() { }

        public Cuenta(string cuentaID, double saldo, bool tipoMoneda, bool estado, Usuario usuario)
        {
            this.cuentaID = cuentaID;
            this.saldo = saldo;
            this.tipoMoneda = tipoMoneda;
            this.estado = estado;
            this.usuario = usuario;
        }

        public string CuentaID { get => cuentaID; set => cuentaID = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public bool TipoMoneda { get => tipoMoneda; set => tipoMoneda = value; }
        public bool Estado { get => estado; set => estado = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }


        public Boolean ValidarCuenta()
        {
            if (estado == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }


}
