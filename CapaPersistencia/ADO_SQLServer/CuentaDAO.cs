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
    public class CuentaDAO
    {
        private GestorSQL gestorSQL;

        public CuentaDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public void guardarCuenta(Cuenta cuenta)
        {
            //string consultaSQL = String.Format("insert into Cuenta" +
                //"(numero, numeroInterbancario, saldo, moneda, estado) " +
                //"values(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\")",
                //cuenta.Numero, cuenta.Numero, cuenta.Saldo, cuenta.Moneda, cuenta.Estado);
            //try
            //{
                //IDbCommand resultadoSQL = gestorSQL.obtenerComandoSQL(consultaSQL);
                //resultadoSQL.ExecuteScalar();
                //resultadoSQL.Dispose();
            //}
            //catch (Exception err)
            //{
                //throw new Exception("Ocurrio un problema al intentar guardar.", err);
            //}


            // CREANDO LAS SENTENCIAS SQL
            string insertarCuentaSQL, insertarTransaccionSQL;

            insertarCuentaSQL = "insert into Cuenta(numero, saldo, moneda, estado ,usuario) " +
                 "values(@numero,@saldo,@moneda,@estado,@usuario)";

            insertarTransaccionSQL = "insert into Transaccion(codigo, fecha, monto, tipo, valoracion, codigoDeMovimiento) " +
                 "values(@codigo, @fecha, @monto, @tipo, @valoracion, @codigoDeMovimiento)";
         
            try
            {
                SqlCommand comando;

                // GUARDANDO EL OBJETO Cuenta
                { 
                    comando = gestorSQL.obtenerComandoSQL(insertarCuentaSQL);
                }
                comando.Parameters.AddWithValue("@numero", cuenta.Numero);
                comando.Parameters.AddWithValue("@saldo", cuenta.Saldo);
                comando.Parameters.AddWithValue("@moneda", cuenta.Moneda);
                comando.Parameters.AddWithValue("@estado", cuenta.Estado);
                comando.Parameters.AddWithValue("@usuario", cuenta.Usuario);
                comando.ExecuteNonQuery();


                 // GUARDANDO LOS OBJETOS TRANSACCIONES
                foreach (Transaccion transaccion in cuenta.listaDeTransacciones)
                {
                    // Agregando una transaccion
                    comando = gestorSQL.obtenerComandoSQL(insertarTransaccionSQL);
                    comando.Parameters.AddWithValue("@codigo", transaccion.Codigo);
                    comando.Parameters.AddWithValue("@fecha", transaccion.Fecha.Date);
                    comando.Parameters.AddWithValue("@monto", transaccion.Monto);
                    comando.Parameters.AddWithValue("@tipo", transaccion.Tipo);
                    comando.Parameters.AddWithValue("@valoracion", transaccion.Valoracion);
                    comando.Parameters.AddWithValue("@codigoDeMovimiento", transaccion.CodigoDeMovimiento);
                    comando.ExecuteNonQuery();
                }

            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar.", err);
            }

        }

        public List<Cuenta> obtenerListaDeCuentas()
        {
            List<Cuenta> listaDecuentas = new List<Cuenta>();
            Cuenta cuenta;
            string consultaSQL = "select * from Cuenta";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultadoSQL.Read())
                {
                    //listaDecuentas.Add(obtenerCuenta(resultadoSQL));
                    cuenta = obtenerCuenta(resultadoSQL);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaDecuentas;
        }

        public Cuenta buscarPorNumeroCuenta(string numero)
        {
            Cuenta cuenta;
            string consultaSQL = "select * from Cuenta where numero = \"" + numero + "\"";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    cuenta = obtenerCuenta(resultadoSQL);
                    //resultadoSQL.Close();
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
            return cuenta;
        }

        public Cuenta buscarPorNumeroInterbancario(string numero)
        {
            Cuenta cuenta;
            string consultaSQL = "select * from Cuenta where numeroInterbancario = \"" + numero + "\"";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    cuenta = obtenerCuenta(resultadoSQL);
                    resultadoSQL.Close();
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
            return cuenta;
        }

        private Cuenta obtenerCuenta(SqlDataReader resultadoSQL)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.Numero = resultadoSQL.GetString(0);
            cuenta.Saldo = resultadoSQL.GetFloat(1);
            string tipoMoneda = resultadoSQL.GetString(2);
            if (tipoMoneda == "Sol")
                cuenta.Moneda = Moneda.SOL;
            else
                cuenta.Moneda = Moneda.DOLAR;
            cuenta.Estado = resultadoSQL.GetInt32(3) == 1 ? true : false;
            return cuenta;
        }
    }
}
