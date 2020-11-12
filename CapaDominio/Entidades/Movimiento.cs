using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Movimiento
    {
        private string movimientoID;
        public DateTime mes;


        public string MovimientoID { get => movimientoID; set => movimientoID = value; }
        public DateTime Mes { get => mes; set => mes = value; }

        private List<Transaccion> listaTransacciones;
        public List<Transaccion> ListaTransacciones { get => listaTransacciones; set => listaTransacciones = value; }



        //regla 3
        public bool verificarMes(Movimiento movimiento)
        {
            if (movimiento.Mes.Month <= 12 && movimiento.Mes.Month >= 1)
            {
                return true;
            }
            return false;
        }

        public Transaccion existeTransaccion()
        {
            foreach (Transaccion transaccion in listaTransacciones)
            {
                return transaccion;
            }
            return null;
        }

        //regla 11
        public float calcularTotalTransaccionSoles()
        {
            float totalSoles = 0f;
            foreach (Transaccion transaccion in listaTransacciones)
            {
                if (transaccion.Moneda == false)
                    totalSoles += transaccion.calcularMontoTotal();
            }

            return totalSoles;
        }

        //regla 12
        public float calcularTotalTransaccionDolares()
        {
            float totalDolares = 0f;
            foreach (Transaccion transaccion in listaTransacciones)
            {
                if (transaccion.Moneda == true)
                    totalDolares += transaccion.calcularMontoTotal();
            }

            return totalDolares;
        }

        //regla 13
        public double calcularTotalGeneral()
        {
            return calcularTotalTransaccionSoles() + (calcularTotalTransaccionDolares() * 3.45);
        }

        // regla 9
        public float calcularNivelValorizacion()
        {
            float nivelValorizacion = 0f;
            float sumaValoracion = 0f;
            int cont = 0;
            foreach (Transaccion transaccion in listaTransacciones)
            {
                cont = 0;
                sumaValoracion += transaccion.Valoracion;
            }
            nivelValorizacion = sumaValoracion / cont;
            return nivelValorizacion;
        }

        //regla 10
        public float calcularNivelMovimiento()
        {
            float nivelMovimiento = 0f;
            int cont = 0, contPorMes = 0;
            DateTime fechaActual = DateTime.Today;
            foreach (Transaccion transaccion in listaTransacciones)
            {
                cont++;
                if (fechaActual.Month == transaccion.Fecha.Month)
                {
                    contPorMes++;
                }

            }
            nivelMovimiento = cont / contPorMes;
            return nivelMovimiento;
        }
    }
}
