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
        private float monto;
        private bool tipoTransaccion;
        private int valoracion;
        private int codigoDeMovimiento;
        private Cuenta cuenta;

        public string TransaccionID { get => transaccionID; set => transaccionID = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Monto { get => monto; set => monto = value; }
        public bool TipoTransaccion { get => tipoTransaccion; set => tipoTransaccion = value; }
        public int Valoracion { get => valoracion; set => valoracion = value; }
        public int CodigoDeMovimiento { get => codigoDeMovimiento; set => codigoDeMovimiento = value; }
        public Cuenta Cuenta { get => cuenta; set => cuenta = value; }

        public void realizarTransaccion()
        {

        }
        public bool validarMonto(Cuenta cuenta)
        {

            return monto <= cuenta.Saldo;
        }



        public float calcularComision()
        {
            float comision = 0.0f;

            comision += tipoTransaccion ? 0.5f : 0.0f;
            comision +=  tipoTransaccion? monto * 0.15f : 0.0f;

            return comision;
        }
        public float calcularMontoTotal()
        {

            return monto + calcularComision();
        }
        public bool validarValoracion()
        {
            return valoracion >= 1 && valoracion <= 5;
        }

        public float calcularTransferencia(Cuenta cuenta)
        {
            float transferencia = 0.0f;
            transferencia += cuenta.TipoMoneda? monto : 0.0f;
            transferencia += cuenta.TipoMoneda ? monto * 3.45f : 0.0f;

            return transferencia;
        }

    }
}
