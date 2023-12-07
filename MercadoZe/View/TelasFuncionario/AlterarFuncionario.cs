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

namespace MercadoZe.View.TelasFuncionario
{
    public partial class AlterarFuncionario : Form
    {
        public AlterarFuncionario()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Funcionario.IdFunci = Convert.ToInt32(txb_MatriculaFunci.Text);
            ManipulaFuncionario manipula = new ManipulaFuncionario();
            manipula.VisualizarCodigoFuncionario();

            txb_NomeFunci.Text = Funcionario.NomeFunci;
            txb_EmailFunci.Text = Funcionario.EmailFunci;
            cbx_TipoFunci.Text = Usuario.Tipo;
            txb_SenhaFunci.Text = Usuario.Senha;
            txb_NumeroUsuario.Text = Usuario.IdUsuario.ToString();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
