using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Movimiento
    {
        private string movimientoID;
        private DateTime fecha;
        private bool moneda;
        private float monto;
        private string nombreDestinatario;

        

        public string MovimientoID { get => movimientoID; set => movimientoID = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public bool Moneda { get => moneda; set => moneda = value; }
        public float Monto { get => monto; set => monto = value; }
        public string NombreDestinatario { get => nombreDestinatario; set => nombreDestinatario = value; }

        private List<Transaccion> listaTransacciones;


        public bool verificarMes(Movimiento movimiento)
        {
            if(movimiento.Fecha.Month<=12 && movimiento.Fecha.Month >= 1)
            {
                return true;
            }
            return false;
        }

        public bool existeTransaccion(Transaccion transaccionAux)
        {
            string existenteID;
            foreach (Transaccion transaccion in listaTransacciones)
            {
                existenteID = transaccion.TransaccionID;
                if (existenteID == transaccionAux.TransaccionID)
                {
                    return true;
                }
            }
            return false;
        }

        public double calcularTotalTransaccionSoles()
        {
            return ;
        }

        public double calcularTotalTransaccionDolares()
        {
            return;
        }

        public double calcularTotalGeneral()
        {

        }

        public float calcularNivelValorizacion()
        {

        }

        public float calcularNivelMovimiento()
        {

        }
    }
}
