using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDominio.Entidades;

namespace CapaDominio.Contratos
{
    public interface ICuenta
    {
        void guardarCuenta(Cuenta cuenta);
        List<Cuenta> obtenerListaDeCuentas(string usuarioID);
        Usuario buscarUsuarioPorCuenta(string cuentaID);

        void GuardarNuevoSaldo(Cuenta cuenta);
        Cuenta buscarPorNumeroCuenta(string cuentaID);
        Cuenta buscarPorNumeroInterbancario(string numero);
    }
}
