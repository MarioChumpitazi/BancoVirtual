﻿using System;
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
        List<Transaccion> obtenerListaDeTransacciones();
        Transaccion buscarPorID(string transaccionID);
    }
}
