using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Produto
    {
        private static int IdProduto;
        private static string nomeProduto_fk;
        private static string marcaProduto_fk;
        private static string valorProduto;
        private static string qtdeProduto;

        public static int IdProduto1 { get => IdProduto; set => IdProduto = value; }
        public static string NomeProduto_fk { get => nomeProduto_fk; set => nomeProduto_fk = value; }
        public static string MarcaProduto_fk { get => marcaProduto_fk; set => marcaProduto_fk = value; }
        public static string ValorProduto { get => valorProduto; set => valorProduto = value; }
        public static string QtdeProduto { get => qtdeProduto; set => qtdeProduto = value; }
    }
}
