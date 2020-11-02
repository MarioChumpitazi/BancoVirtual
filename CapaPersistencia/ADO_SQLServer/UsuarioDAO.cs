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
    public class UsuarioDAO
    {
        private GestorSQL gestorSQL;
        public UsuarioDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public void guardarUsuario(Usuario usuario)
        {
            //string consultaSQL = String.Format("insert into Usuario(nombres, apellidos, dni, numeroTarjeta, clave) values(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\")", usuario.Nombres, usuario.Apellidos, usuario.Dni, usuario.NumeroDeTarjeta, usuario.Clave);
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
            string insertarUsuarioSQL;

            insertarUsuarioSQL = "insert into Usuario(nombres, apellidos, dni, numeroTarjeta, clave, estado) " +
                 "values(@nombres, @apellidos, @dni, @numeroTarjeta, @clave, @estado)";
         
            try
            {
                SqlCommand comando;

                // GUARDANDO EL OBJETO Usuario
                { 
                    comando = gestorSQL.obtenerComandoSQL(insertarUsuarioSQL);
                }
                comando.Parameters.AddWithValue("@nombres", usuario.Nombres);
                comando.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                comando.Parameters.AddWithValue("@dni", usuario.Dni);
                comando.Parameters.AddWithValue("@numeroTarjeta", usuario.NumeroDeTarjeta);
                comando.Parameters.AddWithValue("@clave", usuario.Clave);
                comando.Parameters.AddWithValue("@estado", usuario.Estado);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar.", err);
            }
        }

        public List<Usuario> obtenerListaDeUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;
            string consultaSQL = "select * from Usuario";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    //usuarios.Add(obtenerUsuario(resultadoSQL));
                    usuario = obtenerUsuario(resultadoSQL);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return usuarios;
        }

        public Usuario buscarPorDni(string dni)
        {
            Usuario usuario;
            string consultaSQL = "select * from Usuario where dni = \"" + dni + "\"";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    usuario = obtenerUsuario(resultadoSQL);
                    //resultadoSQL.Close();
                }
                else
                {
                    throw new Exception("No existe usuario.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return usuario;
        }

        private Usuario obtenerUsuario(SqlDataReader resultadoSQL)
        {
            Usuario usuario = new Usuario();
            usuario.Nombres = resultadoSQL.GetString(0);
            usuario.Apellidos = resultadoSQL.GetString(1);
            usuario.Dni = resultadoSQL.GetString(2);
            usuario.NumeroDeTarjeta = resultadoSQL.GetString(3);
            usuario.Clave = resultadoSQL.GetString(4);
            usuario.Estado = resultadoSQL.GetInt16(5) == 1 ? true : false;
            return usuario;
        }
    }
}
