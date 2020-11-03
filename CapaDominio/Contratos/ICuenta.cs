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
      //  Cuenta buscarPorNumeroInterbancario(string numero);
        Cuenta buscarPorNumeroCuenta(string numero);
        List<Cuenta> buscarCuentasDelUsuario(string usuarioID);
    }
}
