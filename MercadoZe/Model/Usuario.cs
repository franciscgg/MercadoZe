using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Usuario
    {
        private static int idUsuario;
        private static string tipo;
        private static string senha;
        private static int idFunci_fk;
        private static string dataAcesso;

        public static int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public static string Tipo { get => tipo; set => tipo = value; }
        public static string Senha { get => senha; set => senha = value; }
        public static int IdFunci_fk { get => idFunci_fk; set => idFunci_fk = value; }
        public static string DataAcesso { get => dataAcesso; set => dataAcesso = value; }
    }
}
