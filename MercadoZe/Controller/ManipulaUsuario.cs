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
    internal class ManipulaUsuario
    {

        public void InserirUsuario()
        { 
        
        }

        public void DeletarUsuario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarUsuarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdUsuario", Usuario.IdUsuario);
                cn.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Registro excluido com sucesso");
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void VisualizarCodigoUsuario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscaUsuarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@IdFunci", Usuario.IdUsuario);
                cn.Open();
                var dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    Usuario.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    Usuario.IdFunci_fk = Convert.ToInt32(dr["IdFunci_fk"]);
                    Usuario.Tipo = dr["Tipo"].ToString();
                    Usuario.Senha = dr["Senha"].ToString();
                    Usuario.DataAcesso = dr["DataAcesso"].ToString();
                    Funcionario.NomeFunci = dr["NomeFunci"].ToString();
                    Funcionario.EmailFunci = dr["EmailFunci"].ToString();
                    
                }
                else
                {
                    Usuario.IdUsuario = 0;
                    Usuario.Tipo = "";
                    Usuario.DataAcesso = "";
                    Usuario.IdFunci_fk = 0;
                    Usuario.Senha = "";
                    MessageBox.Show("Busca não Executada...");
                }
            }
            catch (Exception ex) { }
            
            

        }

        public void AlterarUsuario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarUsuarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {

                cmd.Parameters.AddWithValue("@IdUsuario", Usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@Tipo", Usuario.Tipo);
                cmd.Parameters.AddWithValue("@Senha", Usuario.Senha);
               cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Alterado com Sucesso");



            }
            catch (Exception ex) 
            
            {
                MessageBox.Show(ex.Message, "Usuario Não Alterado");
            
            
            }
            finally { cn.Close(); }
        }
        public static BindingSource VisualizarTipoUsuario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarTipoUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Tipo", Usuario.Tipo);
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
