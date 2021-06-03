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
    public class CuentaDAO : ICuenta
    {
        private GestorSQL gestorSQL;

        public CuentaDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public void guardarCuenta(Cuenta cuenta)
        {
  

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
                comando.Parameters.AddWithValue("@cuentaID", cuenta.CuentaID);
                comando.Parameters.AddWithValue("@saldo", cuenta.Saldo);
                comando.Parameters.AddWithValue("@moneda", cuenta.TipoMoneda);
                comando.Parameters.AddWithValue("@estado", cuenta.Estado);
                comando.ExecuteNonQuery();



            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar.", err);
            }

        }

        public List<Cuenta> obtenerListaDeCuentas(String usuarioID)
        {
            List<Cuenta> listaDecuentas = new List<Cuenta>();
            Cuenta cuenta;
            string consultaSQL = "select cuenta.cuentaID, cuenta.saldo, cuenta.tipoMoneda, cuenta.estado,cuenta.clave from Cuenta cuenta,Usuario usuario where cuenta.usuarioID=usuario.usuarioID and usuario.usuarioID='" + usuarioID + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultadoSQL.Read())
                {
                    cuenta = obtenerCuenta(resultadoSQL);
                    listaDecuentas.Add(cuenta);
                   
                }
            }

            catch (Exception err)
            {
                throw err;
            }
            return listaDecuentas;
        }








        public Usuario buscarUsuarioPorCuenta(string cuentaID)
        {
            Usuario usuario;
            string consultaSQL = "select usuario.usuarioID,usuario.nombres,usuario.apellidos,usuario.dni,usuario.numeroTarjeta,usuario.clave,usuario.estado from Cuenta cuenta,Usuario usuario where usuario.usuarioID=cuenta.usuarioID and cuenta.cuentaID= '" + cuentaID + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    usuario = obtenerUsuario(resultadoSQL);
               
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
            return usuario;
        }

        public Cuenta buscarCuentaPorUsuario(string usuarioID)
        {
            Cuenta cuenta;
            string consultaSQL = "select cuenta.cuentaID,cuenta.saldo,cuenta.tipoMoneda,cuenta.estado,cuenta.clave,cuenta.usuarioID from Cuenta cuenta,Usuario usuario where cuenta.usuarioID=usuario.usuarioID  and usuario.usuarioID= '" + usuarioID + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    cuenta = obtenerCuenta(resultadoSQL);

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


        public void GuardarNuevoSaldo(Cuenta cuenta)
        {
     
            string consultaSQL = "UPDATE Cuenta SET saldo = '" + cuenta.Saldo + "'WHERE cuentaID='" + cuenta.CuentaID + "'";
            try
            {
                SqlCommand comando;

                comando = gestorSQL.obtenerComandoSQL(consultaSQL);
                comando.Parameters.AddWithValue("@saldo", cuenta.Saldo);

                comando.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar insertar saldo.", err);
            }

        }
        public Cuenta buscarPorNumeroCuenta(string cuentaID)
        {
            Cuenta cuenta;
            string consultaSQL = "select * from Cuenta where cuentaID='" + cuentaID + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    cuenta = obtenerCuenta(resultadoSQL);

                }
                else
                {
                    throw new Exception("La cuenta no existe.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return cuenta;
        }


        public Cuenta buscarPorUsuario(string usuarioID)
        {
            Cuenta cuenta;
            string consultaSQL = "select cuenta.cuentaID, cuenta.saldo, cuenta.tipoMoneda, cuenta.estado, cuenta.usuarioID  from Cuenta cuenta,Usuario usuario where cuenta.usuarioID=usuario.usuarioID and usuario.usuarioID='" + usuarioID + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    cuenta = obtenerCuenta(resultadoSQL);

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


        public void InhabilitarCuenta(Cuenta cuenta)
        {
            
            string consultaSQL = "UPDATE Cuenta SET estado=0  where cuentaID='" + cuenta.CuentaID + "'";
            try
            {
                SqlCommand comando;

                comando = gestorSQL.obtenerComandoSQL(consultaSQL);
                comando.Parameters.AddWithValue("@estado", cuenta.Estado);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            
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
            cuenta.CuentaID = resultadoSQL.GetString(0);
            cuenta.Saldo = double.Parse(resultadoSQL.GetDecimal(1).ToString());
            cuenta.TipoMoneda = resultadoSQL.GetBoolean(2);
            cuenta.Estado = resultadoSQL.GetBoolean(3);
            cuenta.Clave = resultadoSQL.GetString(4);

            return cuenta;
        }

        private Usuario obtenerUsuario(SqlDataReader resultadoSQL)
        {
            Usuario usuario = new Usuario();

            usuario.UsuarioID = resultadoSQL.GetInt32(0).ToString();
            usuario.Nombres = resultadoSQL.GetString(1);
            usuario.Apellidos = resultadoSQL.GetString(2);
            usuario.Dni = resultadoSQL.GetString(3);
            usuario.NumeroDeTarjeta = resultadoSQL.GetString(4);
            usuario.Clave = resultadoSQL.GetString(5);
            usuario.Estado = resultadoSQL.GetBoolean(6);

            return usuario;
        }

    }
}
