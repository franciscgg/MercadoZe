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
    public partial class DeletarCliente : Form
    {
        public DeletarCliente()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Cliente.IdCliente = Convert.ToInt32(txb_Matricula.Text);
            ManipulaCliente manipula = new ManipulaCliente();
            manipula.VisualizarCodigoCliente();

            txb_Nome.Text = Funcionario.NomeFunci;
            txb_Email.Text = Funcionario.EmailFunci;
            Text = Usuario.Tipo;
            txb_NumeroUsuario.Text = Usuario.IdUsuario.ToString();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Cliente.IdCliente = Convert.ToInt32(txb_NumeroUsuario.Text);
            ManipulaCliente manipulaUsuario = new ManipulaCliente();
            manipulaUsuario.DeletarCliente();
            txb_Nome.Text = "";
            txb_Email.Text = "";
            
            txb_Matricula.Text = "";
            txb_NumeroUsuario.Text = "";
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            Cliente.IdCliente = Convert.ToInt32(txb_Matricula.Text);
            ManipulaCliente manipula = new ManipulaCliente();
            manipula.VisualizarCodigoCliente();

            txb_Nome.Text = Cliente.NomeCliente;
            txb_Email.Text = Cliente.EmailCliente;
            
            txb_NumeroUsuario.Text = Cliente.FoneCliente;
        }
    }
}

