using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDominio.Entidades;
using CapaDominio.Contratos;

namespace CapaPersistencia.ADO_SQLServer
{
    public class TransaccionDAO : ITransaccion
    {
        private GestorSQL gestorSQL;

        public TransaccionDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public void guardarTransaccion(Transaccion transaccion)
        {

            // CREANDO LAS SENTENCIAS SQL
            string insertarTransaccion1SQL;

            insertarTransaccion1SQL = "insert into Transaccion(codigo, fecha, monto, tipo, valoracion, codigoDeMovimiento) " +
                 "values(@codigo, @fecha, @monto, @tipo, @valoracion, @codigoDeMovimiento)";

            try
            {
                SqlCommand comando;

                // GUARDANDO EL OBJETO Transaccion
                {
                    comando = gestorSQL.obtenerComandoSQL(insertarTransaccion1SQL);
                }
                comando.Parameters.AddWithValue("@transaccionID", transaccion.TransaccionID);
                comando.Parameters.AddWithValue("@fecha", transaccion.Fecha.Date);
                comando.Parameters.AddWithValue("@monto", transaccion.Monto);
                comando.Parameters.AddWithValue("@tipo", transaccion.TipoTransaccion);
                comando.Parameters.AddWithValue("@valoracion", transaccion.Valoracion);
                comando.Parameters.AddWithValue("@codigoDeMovimiento", transaccion.CodigoDeMovimiento);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar.", err);
            }


        }

        public List<Transaccion> obtenerListaDeTransacciones()
        {
            List<Transaccion> transacciones = new List<Transaccion>();
            Transaccion transaccion;
            string consultaSQL = "select * from Transaccion";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultadoSQL.Read())
                {
                    //transacciones.Add(obtenerTransaccion(resultadoSQL));
                    transaccion = obtenerTransaccion(resultadoSQL);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return transacciones;
        }

        public Transaccion buscarPorID(string codigo)
        {
            Transaccion transaccion;
            string consultaSQL = "select * from Transaccion where codigo = \"" + codigo + "\"";
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
            transaccion.TransaccionID = resultadoSQL.GetString(0);
            transaccion.Fecha = resultadoSQL.GetDateTime(1);
            transaccion.Monto = resultadoSQL.GetFloat(2);
            transaccion.TipoTransaccion = resultadoSQL.GetInt32(3) == 1 ? true : false;
            transaccion.Valoracion = resultadoSQL.GetInt32(4);
            transaccion.CodigoDeMovimiento = resultadoSQL.GetInt32(5);
            return transaccion;
        }
    }
}
