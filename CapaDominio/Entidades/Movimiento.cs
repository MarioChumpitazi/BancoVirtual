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
        private DateTime hora;
        private bool tipoMoneda;
        private float monto;
        private Usuario usuario;

        public string MovimientoID { get => movimientoID; set => movimientoID = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public bool TipoMoneda { get => tipoMoneda; set => tipoMoneda = value; }
        public float Monto { get => monto; set => monto = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
    }
}
