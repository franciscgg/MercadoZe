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
        }
    }

