using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Banco
    {
        private string bancoID;
        private string nombreBanco;

        private List<Usuario> listaDeUsuarios;

        public string BancoID { get => bancoID; set => bancoID = value; }
        public string NombreBanco { get => nombreBanco; set => nombreBanco = value; }
        public List<Usuario> ListaDeUsuarios { get => listaDeUsuarios; set => listaDeUsuarios = value; }

       
    }
}
