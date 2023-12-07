using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class Pedidos
    {
        private static int IdPedido;
        private static int IdFunci_fk;
        private static int IdCliente_fk;
        private static int IdItensProduto_fk;
        private static DateTime DataCompra;
        private static int TotalPedido;

        public static int IdPedido1 { get => IdPedido; set => IdPedido = value; }
        public static int IdFunci_fk1 { get => IdFunci_fk; set => IdFunci_fk = value; }
        public static int IdCliente_fk1 { get => IdCliente_fk; set => IdCliente_fk = value; }
        public static int IdItensProduto_fk1 { get => IdItensProduto_fk; set => IdItensProduto_fk = value; }
        public static DateTime DataCompra1 { get => DataCompra; set => DataCompra = value; }
        public static int TotalPedido1 { get => TotalPedido; set => TotalPedido = value; }
    }
}
