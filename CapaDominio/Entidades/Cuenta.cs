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
        private string clave;
        private Usuario usuario;



        public Cuenta() { }

        public Cuenta(string cuentaID, double saldo, bool tipoMoneda, bool estado, string clave, Usuario usuario)
        {
            this.cuentaID = cuentaID;
            this.saldo = saldo;
            this.tipoMoneda = tipoMoneda;
            this.estado = estado;
            this.clave = clave;
            this.usuario = usuario;
        }

        public string CuentaID { get => cuentaID; set => cuentaID = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public bool TipoMoneda { get => tipoMoneda; set => tipoMoneda = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string Clave { get => clave; set => clave = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        public Boolean ValidarCuenta()
        {
            if (Estado == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool verificarCuenta(String cuentaaux)
        {
             if (clave == cuentaaux)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CompararCuentasID(String cuentaOrigenID, string cuentaDestinoID)
        {
            if (cuentaOrigenID == cuentaDestinoID)
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
