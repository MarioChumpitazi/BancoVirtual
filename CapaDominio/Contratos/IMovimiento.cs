using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Contratos
{
    public class IMovimiento
    {
        void guardarMovimiento(Movimiento movimiento);
        List<Movimiento> obtenerListaDeMovimientos();
        Movimiento buscarPorCodigo(string codigo);
    }
}
