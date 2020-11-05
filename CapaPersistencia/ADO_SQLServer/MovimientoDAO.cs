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
    public class MovimientoDAO: IMovimiento
    {
        private GestorSQL gestorSQL;
        public MovimientoDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }
        public void guardarMovimiento(Movimiento movimiento, String transaccionID )
        {
            // CREANDO LAS SENTENCIAS SQL
            string insertarMovimientoSQL;

            insertarMovimientoSQL = "insert into Movimiento(mes,transaccionID) " +
                 "values(@mes,@transaccionID)";

            try
            {
                SqlCommand comando;

                // GUARDANDO EL OBJETO Movimiento
                {
                    comando = gestorSQL.obtenerComandoSQL(insertarMovimientoSQL);
                }
                comando.Parameters.AddWithValue("@mes", movimiento.mes);
                comando.Parameters.AddWithValue("@transaccionID",transaccionID);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar.", err);
            }

        }
       
        public Movimiento buscarPorCodigo(string codigo)
        {
            Movimiento movimiento;
            string consultaSQL = "select * from Movimiento where codigo = \"" + codigo + "\"";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    movimiento = obtenerMovimiento(resultadoSQL);
                    //resultadoSQL.Close();
                }
                else
                {
                    throw new Exception("No existe movimiento.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return movimiento;
        }

        private Movimiento obtenerMovimiento(SqlDataReader resultadoSQL)
        {
            Movimiento movimiento = new Movimiento();
            Transaccion transaccion = new Transaccion();
            movimiento.MovimientoID = resultadoSQL.GetInt32(0).ToString();
            movimiento.mes = resultadoSQL.GetDateTime(1);
            transaccion.TransaccionID= resultadoSQL.GetString(2);
            movimiento.Transaccion = transaccion;
            return movimiento;
        }
    }
}
