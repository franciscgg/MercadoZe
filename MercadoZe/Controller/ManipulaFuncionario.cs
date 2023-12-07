using MercadoZe.Model;
using MercadoZe.View.TelasFuncionario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoZe.Controller
{
    internal class ManipulaFuncionario
    {
        public void AdicionaFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_InserirFunci", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeFunci", Funcionario.NomeFunci);
                cmd.Parameters.AddWithValue("@emailFunci", Funcionario.EmailFunci);
                cmd.Parameters.AddWithValue("@foneFunci", Funcionario.FoneFunci);



                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario Cadastrado com sucesso");

            }
            catch (Exception)
            {

                throw;

            }

        }

        public void DeletarFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarFunci", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {

                cmd.Parameters.AddWithValue("@Idfunci", Funcionario.IdFunci);
                cn.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Registro excluido com sucesso");
            }
            catch (Exception)
            {
                throw;
            }


        }

        public void VisualizarCodigoFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscaFunciCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdFunci", Funcionario.IdFunci);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Funcionario.IdFunci = Convert.ToInt32(dr["IdFunci"]);
                    Funcionario.NomeFunci = dr["nomefunci"].ToString();
                    Cliente.FoneCliente = dr["foneCliente"].ToString();
                    Cliente.EmailCliente = dr["emailFunci"].ToString();
                }
                else
                {
                    Funcionario.IdFunci = 0;
                    Funcionario.EmailFunci = "";
                    Funcionario.FoneFunci = "";
                    Funcionario.NomeFunci = "";
                    MessageBox.Show("Busca não Executada...");
                }
            }
            catch (Exception) { }
        }

        public void AlterarFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarFunci", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdFunci", Funcionario.IdFunci);
                cmd.Parameters.AddWithValue("@nomeFunci", Funcionario.NomeFunci);
                cmd.Parameters.AddWithValue("@foneFunci", Funcionario.FoneFunci);
                cmd.Parameters.AddWithValue("@emailFunci", Funcionario.EmailFunci);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario Alterado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Funcionario Não Alterado");

            }
            finally { cn.Close(); }

        }

    }
}


