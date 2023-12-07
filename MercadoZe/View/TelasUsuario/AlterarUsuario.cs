using MercadoZe.Controller;
using MercadoZe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoZe.View.TelasUsuario
{
    public partial class AlterarUsuario : Form
    {
        public AlterarUsuario()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Usuario.IdUsuario = Convert.ToInt32(txb_MatriculaFunci.Text);
            ManipulaUsuario manipula = new ManipulaUsuario();
            manipula.VisualizarCodigoUsuario();

            txb_NomeFunci.Text = Funcionario.NomeFunci;
            txb_EmailFunci.Text = Funcionario.EmailFunci;
            cbx_TipoFunci.Text = Usuario.Tipo;
            txb_SenhaFunci.Text = Usuario.Senha;
            txb_NumeroUsuario.Text = Usuario.IdUsuario.ToString();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            Usuario.IdUsuario = Convert.ToInt32(txb_NumeroUsuario.Text);
            Usuario.Tipo = cbx_TipoFunci.Text;
            Usuario.Senha = txb_SenhaFunci.Text;
            ManipulaUsuario manipula = new ManipulaUsuario();
            manipula.AlterarUsuario();


        }

        private void txb_NumeroUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
