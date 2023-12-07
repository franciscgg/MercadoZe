using MercadoZe.Model;
using MercadoZe.View.TelasCliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class ManipulaCliente
    {

        public void AdicionaCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirClientes", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeCliente", Cliente.NomeCliente);
                cmd.Parameters.AddWithValue("@foneCliente", Cliente.FoneCliente);
                cmd.Parameters.AddWithValue("@emailCliente", Cliente.EmailCliente);


                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeletarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarCliente", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idCliente", Cliente.IdCliente);
                cn.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Registro excluido com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void VisualizarCodigoCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscaClienteCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdCliente", Cliente.IdCliente);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Cliente.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    Cliente.NomeCliente = dr["nomeCliente"].ToString();
                    Cliente.FoneCliente = dr["foneCliente"].ToString();
                    Cliente.EmailCliente = dr["emailCliente"].ToString();
                }
                else
                {
                    Cliente.IdCliente = 0;
                    Cliente.EmailCliente = "";
                    Cliente.FoneCliente = "";
                    Cliente.NomeCliente = "";
                    MessageBox.Show("Busca não Executada...");
                }


            }
            catch (Exception ex) { }
        }

        public void AlterarClientes()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarClientes", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdCliente", Cliente.IdCliente);
                cmd.Parameters.AddWithValue("@nomeCliente", Cliente.NomeCliente);
                cmd.Parameters.AddWithValue("@foneCliente", Cliente.FoneCliente);
                cmd.Parameters.AddWithValue("@emailCliente", Cliente.EmailCliente);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Alterado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cliente Não Alterado");
            }
            finally { cn.Close(); }
        }

    }
}

