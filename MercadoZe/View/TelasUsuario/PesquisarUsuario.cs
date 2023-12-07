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
    public partial class PesquisarUsuario : Form
    {
        public PesquisarUsuario()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario.IdUsuario = Convert.ToInt32(txb_Matricula.Text);
            ManipulaUsuario manipula = new ManipulaUsuario();
            manipula.VisualizarCodigoUsuario();

            txb_Nome.Text = Funcionario.NomeFunci;
            txb_Email.Text = Funcionario.EmailFunci;
            cbx_Tipo.Text = Usuario.Tipo;
            txb_NumeroUsuario.Text = Usuario.IdUsuario.ToString();
        }

        private void BuscarTipoUsuario_Click(object sender, EventArgs e)
        {
            Usuario.Tipo = cbx_TipoUsu.Text;
            dataGridView1.DataSource = ManipulaUsuario.VisualizarTipoUsuario();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderCell.Value = "Código do Usuário";
            dataGridView1.Columns[4].HeaderCell.Value = "Função";
            dataGridView1.Columns[5].HeaderCell.Value = "Data Acesso";
            dataGridView1.Columns[6].HeaderCell.Value = "Matricula Funcionário";
            dataGridView1.Columns[7].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
