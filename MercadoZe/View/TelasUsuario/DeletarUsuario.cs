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
    public partial class DeletarUsuario : Form
    {
        public DeletarUsuario()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Usuario.IdUsuario = Convert.ToInt32(txb_Matricula.Text);
            ManipulaUsuario manipula = new ManipulaUsuario();
            manipula.VisualizarCodigoUsuario();

            txb_Nome.Text = Funcionario.NomeFunci;
            txb_Email.Text = Funcionario.EmailFunci;
            cbx_Tipo.Text = Usuario.Tipo;
            txb_NumeroUsuario.Text = Usuario.IdUsuario.ToString();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Usuario.IdUsuario = Convert.ToInt32(txb_NumeroUsuario.Text);
            ManipulaUsuario manipulaUsuario = new ManipulaUsuario();
            manipulaUsuario.DeletarUsuario();
            txb_Nome.Text = "";
            txb_Email.Text = "";
            cbx_Tipo.Text = "";
            txb_Matricula.Text = "";
            txb_NumeroUsuario.Text = "";
        }
    }
}
