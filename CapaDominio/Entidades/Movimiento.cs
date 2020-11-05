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

        public string MovimientoID { get => movimientoID; set => movimientoID = value; }
        public DateTime Mes { get => mes; set => mes = value; }
     
        public Transaccion Transaccion { get => transaccion; set => transaccion = value; }
    }
}
