using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDominio.Entidades;

namespace CapaDominio.Contratos
{
    public interface IMovimiento
    {
        void guardarMovimiento(Movimiento movimiento, String transaccionID);
     
        Movimiento buscarPorCodigo(string movimientoID);



    }
}
