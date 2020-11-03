using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Transaccion
    {

        private string transaccionID;
        private DateTime fecha;
        private double monto;
        private bool tipoTransaccion;
        private int valoracion;
        private Cuenta cuentaOrigen;
        private Cuenta cuentaDestino;

        public string TransaccionID { get => transaccionID; set => transaccionID = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Monto { get => monto; set => monto = value; }
        public bool TipoTransaccion { get => tipoTransaccion; set => tipoTransaccion = value; }
        public int Valoracion { get => valoracion; set => valoracion = value; }
        public Cuenta CuentaOrigen { get => cuentaOrigen; set => cuentaOrigen = value; }
        public Cuenta CuentaDestino { get => cuentaDestino; set => cuentaDestino = value; }

        public void realizarTransaccion()
        {

        }
        public bool validarMonto(Cuenta cuenta)
        {

            return monto <= cuenta.Saldo;
        }


        public double calcularComision()
        {
            double comision = 0;

            comision += tipoTransaccion ? 0.5 : 0.0;
            comision +=  tipoTransaccion? monto * 0.15 : 0.0;

            return comision;
        }
        public double calcularMontoTotal()
        {

            return monto + calcularComision();
        }
        public bool validarValoracion()
        {
            return valoracion >= 1 && valoracion <= 5;
        }

        public double calcularTransferencia(Cuenta cuenta)
        {
            double transferencia = 0.0f;
            transferencia += cuenta.TipoMoneda? monto : monto * 3.45;
          

            return transferencia;
        }

    }
}
