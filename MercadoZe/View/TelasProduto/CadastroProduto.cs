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

namespace MercadoZe.View.TelasProduto
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto.NomeProduto_fk = txb_nome.Text;
            Produto.MarcaProduto_fk = txb_marca.Text;
            Produto.ValorProduto = txb_valor.Text;
            Produto.QtdeProduto = txb_qtd.Text;

            ManipulaProduto manipulaProduto = new ManipulaProduto();
            manipulaProduto.AdicionaProduto();
        }
    }
}
