using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Contratos
{
    public class ICuenta
    {
        void guardarCuenta(Cuenta cuenta);
        List<Cuenta> obtenerListaDeCuentas();
        Cuenta buscarPorNumeroCuenta(string numero);
        Cuenta buscarPorNumeroInterbancario(string numero);
    }
}
