using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDominio.Entidades;

namespace CapaDominio.Contratos
{
    public interface ITransaccion
    {
       
        void guardarTransaccion(Transaccion transaccion, String cuentaOrigenID, String cuentaDestinoID);
        List<Transaccion> obtenerListaDeTransacciones(string usuarioID, bool tipoTransaccion);
        Transaccion buscarPorID(string transaccionID);
        List<Transaccion> obtenerListaDeTransaccionesPorCuenta(string cuentaID);
        Transaccion buscarTransaccion(string usuarioID, bool tipoTransaccion);

    }
}
