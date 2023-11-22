using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MercadoZe.Model
{
    internal class ConexaoBanco
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\francisco.holiveira3\source\repos\MercadoZe\MercadoZe\BancoDeDados\mercadobd.mdf;Integrated Security=True";
        }

    }
}
