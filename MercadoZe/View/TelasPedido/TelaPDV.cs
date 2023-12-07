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

namespace MercadoZe.View.TelasPedido
{
    public partial class TelaPDV : Form
    {
        public TelaPDV()
        {
            InitializeComponent();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {   
            
            
            ManipulaProduto manipulaProduto = new ManipulaProduto();
            ManipulaProduto.BuscarProdutoCodigo();
            
            lbl_codbarras.Text = 
            lbl_produto.Text = Produto.NomeProduto_fk;
            lbl_qtd.Text = lbl_qtd.Text;
            lbl_valorunitario.Text = Produto.ValorProduto;
            //dgv_PDV.Columns[1].HeaderCell.Value = "Produto";
            //dgv_PDV.Columns[2].HeaderCell.Value = "Marca";
            //dgv_PDV.Columns[3].HeaderCell.Value = "Valor";
            //dgv_PDV.Columns[4].HeaderCell.Value = "Quantidade";
            //dgv_PDV.Columns[3].HeaderCell.Value = "Total";
        }

        private void dgv_PDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
