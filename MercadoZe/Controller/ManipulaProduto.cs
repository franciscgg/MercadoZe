using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        public void DeletarProduto ()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarProduto", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {

                cmd.Parameters.AddWithValue("@IdProduto", Produto.IdProduto1);
                cn.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Registro excluido com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void VisualisarCodigoProduto()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarProduto", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdProudto", Produto.IdProduto1);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Produto.IdProduto1 = Convert.ToInt32(dr["IdProduto"]);
                    Produto.NomeProduto_fk = dr["nomeProduto"].ToString();
                    Produto.MarcaProduto_fk = dr["marcaProduto"].ToString();
                    Produto.ValorProduto = dr["valorProduto"].ToString();
                }
                else
                {
                    Produto.IdProduto1 = 0;
                    Produto.NomeProduto_fk = "";
                    Produto.MarcaProduto_fk = "";
                    Produto.ValorProduto = "";
                    MessageBox.Show("Busca não Executada...");
                }
            }
            catch (Exception) { }
        }

        public void AlterarProduto()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarProduto", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdProduto", Produto.IdProduto1);
                cmd.Parameters.AddWithValue("@nomeProduto", Produto.NomeProduto_fk);
                cmd.Parameters.AddWithValue("@marcaProduto", Produto.MarcaProduto_fk);
                cmd.Parameters.AddWithValue("@valorProduto", Produto.ValorProduto);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Alterado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Produto Não Alterado");

            }
            finally { cn.Close(); }
        }
        public static BindingSource BuscarProdutoCodigo()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscaProdutosCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdProduto", Produto.IdProduto1);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;



        }

    }
}
