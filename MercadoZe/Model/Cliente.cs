using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Cliente
    {
        private static int idCliente;
        private static string nomeCliente;
        private static string foneCliente;
        private static string emailCliente;

        public static int IdCliente { get => idCliente; set => idCliente = value; }
        public static string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public static string FoneCliente { get => foneCliente; set => foneCliente = value; }
        public static string EmailCliente { get => emailCliente; set => emailCliente = value; }
    }
}
