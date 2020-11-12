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
        private Transaccion transaccion;
        private List<Transaccion> listaTransacciones;

        public string MovimientoID { get => movimientoID; set => movimientoID = value; }
        public DateTime Mes { get => mes; set => mes = value; }
        public Transaccion Transaccion { get => transaccion; set => transaccion = value; }
        public List<Transaccion> ListaTransacciones { get => listaTransacciones; set => listaTransacciones = value; }

        public double calcularTotalMontoTransferido()
        {
            double totalMontoTransferido = 0;
            foreach (Transaccion transaccion in listaTransacciones)
            {
                totalMontoTransferido += transaccion.Monto;
            }

            return totalMontoTransferido;
        }

        public String calcularNivelDeValoracion()
        {
            double puntosValoracion = 0;
            int cont = 0;
            foreach (Transaccion transaccion in listaTransacciones)
            {
                puntosValoracion += transaccion.Valoracion;
                cont = cont + 1;
            }
            double promedioValoracion = (puntosValoracion / cont);
            if (promedioValoracion < 2)
            {
                return "bajo";
            }
            else if (promedioValoracion < 4)
            {
                return "medio";
            }
            else
            {
                return "alto";
            }
        }


        public String calcularNivelMovimiento()
        {

            int cont = 0;
            foreach (Transaccion transaccion in listaTransacciones)
            {
                cont++;
            }
            if (cont < 4)
            {
                return "bajo";
            }
            else if (cont < 7)
            {
                return "medio";
            }
            else
            {
                return "alto";
            }
        }

    }
}

