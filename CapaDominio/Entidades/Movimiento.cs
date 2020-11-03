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
        private DateTime mes;
        private bool moneda;
        private float monto;
        private string nombreDestinatario;

        public string MovimientoID { get => movimientoID; set => movimientoID = value; }
        public DateTime Mes { get => mes; set => mes = value; }
        public bool Moneda { get => moneda; set => moneda = value; }
        public float Monto { get => monto; set => monto = value; }
        public string NombreDestinatario { get => nombreDestinatario; set => nombreDestinatario = value; }

        public bool verificarMes(Movimiento movimiento)
        {
            if(movimiento.mes.Month<=12 && movimiento.mes.Month >= 1)
            {
                return true;
            }
            return false;
        }
    }
}
