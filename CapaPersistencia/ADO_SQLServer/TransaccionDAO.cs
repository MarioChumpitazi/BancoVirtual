using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDominio.Entidades;
using CapaDominio.Contratos;
using System.Diagnostics;

namespace CapaPersistencia.ADO_SQLServer
{
    public class TransaccionDAO : ITransaccion
    {
        private GestorSQL gestorSQL;

        public TransaccionDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public void guardarTransaccion(Transaccion transaccion, String cuentaOrigenID, String cuentaDestinoID)
        {

            // CREANDO LAS SENTENCIAS SQL
            string insertarTransaccion1SQL;

            insertarTransaccion1SQL = "insert into Transaccion(fechaTransaccion, monto, tipoTransaccion, valoracion, cuentaOrigenID, cuentaDestinoID) " +
                 "values(@fechaTransaccion, @monto, @tipoTransaccion, @valoracion, @cuentaOrigenID,@cuentaDestinoID)";

            try
            {
                SqlCommand comando;

                // GUARDANDO EL OBJETO Transaccion
                {
                    comando = gestorSQL.obtenerComandoSQL(insertarTransaccion1SQL);
                }
                comando.Parameters.AddWithValue("@fechaTransaccion", transaccion.Fecha);
                comando.Parameters.AddWithValue("@monto", transaccion.Monto);
                comando.Parameters.AddWithValue("@tipoTransaccion", transaccion.TipoTransaccion);
                comando.Parameters.AddWithValue("@valoracion", transaccion.Valoracion);
                comando.Parameters.AddWithValue("@cuentaOrigenID", cuentaOrigenID);
                comando.Parameters.AddWithValue("@cuentaDestinoID", cuentaDestinoID);


                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar.", err);
            }


        }

        public List<Transaccion> obtenerListaDeTransaccionesPorCuenta(String cuentaID)
        {
            List<Transaccion> listaDeTransacciones = new List<Transaccion>();
            Transaccion transaccion;
            string consultaSQL = "select t.transaccionID,t.fechaTransaccion,t.monto,t.tipoTransaccion,t.valoracion,t.cuentaOrigenID,cuentaDestinoID from Transaccion t,Cuenta c where t.cuentaOrigenID=c.cuentaID and cuentaID='" + cuentaID + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultadoSQL.Read())
                {
                    transaccion = obtenerTransaccion(resultadoSQL);
                    listaDeTransacciones.Add(transaccion);

                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaDeTransacciones;
        }



        public List<Transaccion> obtenerListaDeTransacciones(String cuentaID, bool tipoTransaccion)
        {
            List<Transaccion> listaDeTransacciones = new List<Transaccion>();
            Transaccion transaccion;
            string consultaSQL = "select t.transaccionID,t.fechaTransaccion,t.monto,t.tipoTransaccion,t.valoracion,t.cuentaOrigenID,cuentaDestinoID from Transaccion t,Cuenta c where t.cuentaOrigenID=c.cuentaID and  cuentaID='" + cuentaID + "' and t.tipoTransaccion='" + tipoTransaccion + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultadoSQL.Read())
                {
                    transaccion = obtenerTransaccion(resultadoSQL);
                    listaDeTransacciones.Add(transaccion);

                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaDeTransacciones;
        }
       

        public Transaccion buscarTransaccion(string usuarioID, bool tipoTransaccion)
        {
            Transaccion transaccion;
            string consultaSQL = "select t.transaccionID,t.fechaTransaccion,t.monto,t.tipoTransaccion,t.valoracion,t.cuentaOrigenID,cuentaDestinoID from Transaccion t,Usuario u,Cuenta c where t.cuentaOrigenID=c.cuentaID and c.usuarioID=u.usuarioID and u.usuarioID='" + usuarioID + "' and t.tipoTransaccion= '" + tipoTransaccion + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    transaccion = obtenerTransaccion(resultadoSQL);

                }
                else
                {
                    throw new Exception("No existe cuenta.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return transaccion;
        }





        public Transaccion buscarPorID(string transaccionID)
        {
            Transaccion transaccion;
            string consultaSQL = "select * from Transaccion where transaccionID = '" + transaccionID + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    transaccion = obtenerTransaccion(resultadoSQL);
                    //resultadoSQL.Close();
                }
                else
                {
                    throw new Exception("No existe transaccion.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return transaccion;
        }

        private Transaccion obtenerTransaccion(SqlDataReader resultadoSQL)
        {
            Transaccion transaccion = new Transaccion();
            Cuenta cuenta1 = new Cuenta();
            Cuenta cuenta2 = new Cuenta();
            transaccion.TransaccionID= resultadoSQL.GetInt32(0).ToString();
            transaccion.Fecha = resultadoSQL.GetDateTime(1);
            transaccion.Monto = double.Parse(resultadoSQL.GetDecimal(2).ToString());
            transaccion.TipoTransaccion = resultadoSQL.GetBoolean(3);
            transaccion.Valoracion = resultadoSQL.GetInt32(4);
            cuenta1.CuentaID= resultadoSQL.GetString(5);
            transaccion.CuentaOrigen = cuenta1;
            cuenta2.CuentaID = resultadoSQL.GetString(6);
            transaccion.CuentaDestino = cuenta2;
            return transaccion;
        }
    }
}
