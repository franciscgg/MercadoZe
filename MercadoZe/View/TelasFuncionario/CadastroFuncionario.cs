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
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Funcionario.NomeFunci = txb_nome.Text;
            Funcionario.EmailFunci = txb_email.Text;
            Funcionario.FoneFunci = txb_telefone.Text;

            ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
            manipulaFuncionario.AdicionaFuncionario();
        }
    }
}
