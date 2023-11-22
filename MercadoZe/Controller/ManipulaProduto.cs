using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class ManipulaProduto
    {
        public void AdicionaProduto()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirProdutos", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeProduto_fk", Produto.NomeProduto_fk);
                cmd.Parameters.AddWithValue("@marcaProduto_fk", Produto.MarcaProduto_fk);
                cmd.Parameters.AddWithValue("@valorProduto", Produto.ValorProduto);
                cmd.Parameters.AddWithValue("@qtdProduto", Produto.QtdeProduto);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
