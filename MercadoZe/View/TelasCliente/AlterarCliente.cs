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
    public partial class AlterarCliente : Form
    {
        public AlterarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Cliente.IdCliente = Convert.ToInt32(txb_MatriculaFunci.Text);
            ManipulaCliente manipula = new ManipulaCliente();
            manipula.VisualizarCodigoCliente();

            txb_NomeFunci.Text = Cliente.NomeCliente;
            txb_EmailFunci.Text = Cliente.EmailCliente;

            txb_NumeroUsuario.Text = Cliente.FoneCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cliente.IdCliente = Convert.ToInt32(txb_NumeroUsuario.Text);
            Cliente.NomeCliente = txb_NomeFunci.Text;
            Cliente.EmailCliente = txb_EmailFunci.Text;
            Cliente.FoneCliente = txb_NumeroUsuario.Text;

            ManipulaCliente manipula = new ManipulaCliente();
            manipula.AlterarClientes();

        }
    }
}
