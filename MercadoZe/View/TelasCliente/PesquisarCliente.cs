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

namespace MercadoZe.View.TelasCliente
{
    public partial class PesquisarCliente : Form
    {
        public PesquisarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente.IdCliente = Convert.ToInt32(txb_Matricula.Text);
            ManipulaCliente manipula = new ManipulaCliente();
            manipula.VisualizarCodigoCliente();

            txb_Nome.Text = Cliente.NomeCliente;
            txb_Email.Text = Cliente.EmailCliente;

            txb_NumeroUsuario.Text = Cliente.FoneCliente;
        }

        private void BuscarTipoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
