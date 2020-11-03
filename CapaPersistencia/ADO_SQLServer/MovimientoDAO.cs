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

        public void guardarMovimiento(Movimiento movimiento)
        {
  
            // CREANDO LAS SENTENCIAS SQL
            string insertarMovimientoSQL;

            insertarMovimientoSQL = "insert into Movimiento(codigo, hora, moneda, monto, nombreDestinatario) " +
                 "values(@codigo, @hora, @moneda, @monto, @nombreDestinatario)";

            try
            {
                SqlCommand comando;

                // GUARDANDO EL OBJETO Movimiento
                {
                    comando = gestorSQL.obtenerComandoSQL(insertarMovimientoSQL);
                }
                comando.Parameters.AddWithValue("@movimientoID", movimiento.MovimientoID);
                comando.Parameters.AddWithValue("@hora", movimiento.Hora.Date);
                comando.Parameters.AddWithValue("@moneda", movimiento.Moneda);
                comando.Parameters.AddWithValue("@monto", movimiento.Monto);
                comando.Parameters.AddWithValue("@nombreDestinatario", movimiento.NombreDestinatario);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar.", err);
            }

        }

        public List<Movimiento> obtenerListaDeMovimientos()
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            Movimiento movimiento;
            string consultaSQL = "select * from Movimiento";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultadoSQL.Read())
                {
                    //movimientos.Add(obtenerMovimiento(resultadoSQL));
                    movimiento = obtenerMovimiento(resultadoSQL);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return movimientos;
        }

        public Movimiento buscarPorCodigo(string movimientoID)
        {
            Movimiento movimiento;
            string consultaSQL = "select * from Movimiento where movimientoID = '" + movimientoID + "'";
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
            movimiento.MovimientoID = resultadoSQL.GetString(0);
            movimiento.Hora = resultadoSQL.GetDateTime(1);
            movimiento.Moneda = resultadoSQL.GetString(2);
            movimiento.Monto = resultadoSQL.GetFloat(3);
            movimiento.NombreDestinatario = resultadoSQL.GetString(4);
            return movimiento;
        }
    }
}
