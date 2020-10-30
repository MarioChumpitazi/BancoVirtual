using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDominio.Contratos
{
    public class ITransaccion
    {
        void guardarTransaccion(Transaccion transaccion);
        List<Transaccion> obtenerListaDeTransacciones();
        Transaccion buscarPorCodigo(string codigo);
    }
}
