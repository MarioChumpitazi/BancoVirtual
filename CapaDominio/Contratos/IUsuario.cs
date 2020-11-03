﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Contratos
{
    public interface IUsuario
    {

        Usuario buscarPorID(string ID);
        Usuario buscarPorDni(string dni);
        Cuenta buscarCuentaID(Cuenta cuenta);
    }
}
