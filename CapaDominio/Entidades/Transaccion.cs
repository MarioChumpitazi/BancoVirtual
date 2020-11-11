using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
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
        private bool moneda;
        private int valoracion;


        public bool Moneda { get => moneda; set => moneda = value; }

        public string TransaccionID { get => transaccionID; set => transaccionID = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Monto { get => monto; set => monto = value; }
        public bool Tipo { get => tipo; set => tipo = value; }
        public int Valoracion { get => valoracion; set => valoracion = value; }

        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private int clave;

        //regla 4
        public bool verificarMonto(float monto, Cuenta cuenta)
        {
            if (monto <= cuenta.Saldo)
                return true;
            else
                return false;
        }

        //regla 2
        public float verificarComision(bool tipo)
        {
            float comision = 0f;
            if (tipo == false)
                comision = 0.50f;
            else
                comision = 0.15f;
            return comision;
        }
        //regla 7
        public float calcularMontoTotal()
        {
            float montoAux=0f;
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

        //regla 14
        public bool validarValoracion(int valorizacion)
        {
            if (valoracion >= 1 && valoracion <= 5)
                return true;
            else
                return false;
        }

       

        //regla 5
        public float verificarMoneda(Transaccion transaccion, Cuenta cuentaDestino)
        {
            if(transaccion.moneda = false  && cuentaDestino.Moneda==false)
                return monto;
            else
            {
                return monto *= 3.45f;
            }
        }
        /*

        public bool verificarCodigo(string codigoaux, string transaccionID2)
        {
            transaccionID = transaccionID2;
            return (transaccionID == transaccionID2);
        }
        
        public bool existeUsuario(Usuario usuario)
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
        public Usuario buscarUsuario(Usuario usuario)
        {
            return banco.buscarUsuarioID(usuario);

        }
        */
        public int generarClaveTransaccion()
        {
            var rand = new Random();
            return clave=rand.Next(1000, 9999); //genera clave entre 1000 y 9999
        }

        //regla 6
        public void verificarIntentos(Cuenta cuenta, int intentos)
        {
            if (intentos >= 3)
                cuenta.Estado = false;
        }
        
        public void verificarClaveTransaccion(Banco banco, Cuenta cuenta, Cuenta cuentaDestino, int clave, int intentos)
        {
            if (cuenta.Estado == true)
            {
                if (clave == generarClaveTransaccion())
                {
                    realizarTransaccion(banco,cuenta,cuentaDestino,monto);
                }
                else
                {
                    intentos++;
                    verificarIntentos(cuenta, intentos);
                }
            }
            
        }

        //regla 1
        public Cuenta buscarCuenta(Banco banco, Cuenta cuenta)
        {
            if (tipo == true)
            {
                usuario = banco.buscarUsuario(usuario);
                cuenta = usuario.buscarCuentaID(cuenta);
            }
            else
            {
                cuenta = usuario.buscarCuentaID(cuenta);
            }
            
            return cuenta;
        }
        public void realizarTransaccion(Banco banco, Cuenta cuenta, Cuenta cuentaDestino, float monto)
        {
            buscarCuenta(banco, cuenta);
            //verificarClaveTransaccion(banco,cuenta,cuentaDestino,clave,intentos)
            actualizarSaldos(cuenta, cuentaDestino,monto);

        }
        public void actualizarSaldos(Cuenta cuenta, Cuenta cuentaDestino, float montoTransferir)
        {
            float monto=calcularMontoTotal();
            float saldoCuenta = cuenta.Saldo - monto;
            float saldoCuentaDestino = cuentaDestino.Saldo + monto;
        }
    }
}
