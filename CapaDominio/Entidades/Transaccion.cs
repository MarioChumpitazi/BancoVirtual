using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{

    public class Transaccion
    {
        private string transaccionID;
        private DateTime fecha;
        private float monto;
        private bool tipo;  //0 entre cuentas y 1 a terceros
        private int valoracion;
        private int codigoDeMovimiento;

        private Cuenta cuenta;

        private List<Usuario> listaUsuarios;

        public string TransaccionID { get => transaccionID; set => transaccionID = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Monto { get => monto; set => monto = value; }
        public bool Tipo { get => tipo; set => tipo = value; }
        public int Valoracion { get => valoracion; set => valoracion = value; }
        public int CodigoDeMovimiento { get => codigoDeMovimiento; set => codigoDeMovimiento = value; }
        public Cuenta Cuenta { get => cuenta; set => cuenta = value; }
        public List<Usuario> ListaUsuario { get { return listaUsuarios; } set { listaUsuarios = value; } }

        
        public void realizarTransaccion()
        {

        }
        public bool validarMonto(float monto, Cuenta cuenta)
        {
            if (monto <= cuenta.Saldo)
                return true;
            else
                return false;
        }


        public float calcularComision(bool tipo, float montoAux)
        {
            float comision = 0f;
            if (tipo == false)  //entre cuentas
                comision = 0.50f;

            else   //a terceros
                comision = montoAux * 0.15f;

            return comision;
        }

        public float verificarComision(bool tipo)
        {
            float comision = 0f;
            if (tipo == false)
                comision = 0.50f;
            else
                comision = 0.15f;
            return comision;
        }
        public float calcularMontoTotal(bool tipo, float montoAux)
        {
            float montoTotal= 0f;
            if (tipo== false)
            {
                montoTotal = montoAux + verificarComision(tipo);
            }
            else
            {
                montoTotal = montoAux * verificarComision(tipo);
            }

            return montoTotal;
        }

        public bool validarValoracion(int valorizacion)
        {
            if (valoracion >= 1 && valoracion <= 5)
                return true;
            else
                return false;
        }

        /*
        public float calcularTransferencia(float monto, string tipomoneda1)
        {
            if (tipomoneda1.Equals("DOLAR"))
            {
                monto *= 3.45f;
            }
            return monto;
        }

        

        public bool verificarCodigo(string codigoaux, string transaccionID2)
        {
            transaccionID = transaccionID2;
            return (transaccionID == transaccionID2);
        }
        */
        public bool existeUsuario(Usuario usuarioAux)
        {
            string existenteID;
            foreach (Usuario usuario in listaUsuarios)
            {
                existenteID = usuario.UsuarioID;
                if (existenteID == usuarioAux.UsuarioID)
                {
                    return true;
                }
            }
            return false;
        }

        public Usuario buscarUsuarioID(Usuario usuario)
        {
            if (existeUsuario(usuario))
            {
                return usuario;
            }

            return null;
        }

        public bool verificarIntentos()
        {
            return false;
        }

        public void generarClaveTransaccion()
        {

        }

        public void verificarClaveTransaccion()
        { 
        }
    }
}
