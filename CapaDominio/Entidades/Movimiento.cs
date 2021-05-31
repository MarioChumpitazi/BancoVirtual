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


        public bool validarTipoDeMoneda(Cuenta cuentaDestino)
        {
            if (cuentaDestino.TipoMoneda == true)
            {
                return true;
            }
            else
            { 
                return false;
            }

        }

      

        
        public double calcularTotalGeneral(Cuenta cuentaOrigen,Cuenta cuentaDestino,double monto)
        {
            double totalGeneral = 0;
            
                if (cuentaOrigen.TipoMoneda == true && cuentaDestino.TipoMoneda == true)
                {
                    totalGeneral = monto + totalGeneral;
                }
                else if (cuentaOrigen.TipoMoneda == true && cuentaDestino.TipoMoneda == false)
                {
                    totalGeneral = monto * 3.45 + totalGeneral;

                }
                else if (cuentaOrigen.TipoMoneda == false && cuentaDestino.TipoMoneda == true)
                {
                    totalGeneral = monto / 3.45 + totalGeneral;

                }
                else
                {
                    totalGeneral = monto + totalGeneral;
                }

            

            return totalGeneral;
        }
        

    public int calcularNivelDeValoracion()
        {
            double puntosValoracion = 0;
            int cont = 0;
            foreach (Transaccion transaccion in listaTransacciones)
            {
                puntosValoracion += transaccion.Valoracion;
                cont = cont + 1;
            }
            if (puntosValoracion!= 0)
            {
                double promedioValoracion = (puntosValoracion / cont);

                double verificar = promedioValoracion - (int)promedioValoracion;
                if (verificar >= 0.5)
                {
                    return (int)promedioValoracion + 1;
                }
                else
                {
                    return (int)promedioValoracion;
                }
            }
            else
            {
                return 0;
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

