namespace MercadoZe.View.TelasPedido
{
    partial class TelaPDV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_PDV = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbx_codbarra = new TextBox();
            tbx_qtd = new TextBox();
            lbl_codbarras = new Label();
            lbl_qtd = new Label();
            lbl_valortotal = new Label();
            lbl_valorunitario = new Label();
            label12 = new Label();
            btn_fecharvenda = new Button();
            btn_buscar = new Button();
            lbl_produto = new Label();
            label8 = new Label();
            btn_confirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_PDV).BeginInit();
            SuspendLayout();
            // 
            // dgv_PDV
            // 
            dgv_PDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_PDV.Location = new Point(93, 220);
            dgv_PDV.Margin = new Padding(5, 6, 5, 6);
            dgv_PDV.Name = "dgv_PDV";
            dgv_PDV.RowTemplate.Height = 25;
            dgv_PDV.Size = new Size(377, 300);
            dgv_PDV.TabIndex = 0;
            dgv_PDV.CellContentClick += dgv_PDV_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(349, 18);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 37);
            label1.TabIndex = 1;
            label1.Text = "PDV Mercado do Zé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(131, 97);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 30);
            label3.TabIndex = 3;
            label3.Text = "Código de barras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(601, 189);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(155, 30);
            label4.TabIndex = 4;
            label4.Text = "Código de barra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(637, 345);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 30);
            label5.TabIndex = 5;
            label5.Text = "Quantidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(361, 97);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 30);
            label6.TabIndex = 6;
            label6.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(645, 571);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(111, 30);
            label7.TabIndex = 7;
            label7.Text = "Valor Total";
            // 
            // tbx_codbarra
            // 
            tbx_codbarra.Location = new Point(93, 141);
            tbx_codbarra.Name = "tbx_codbarra";
            tbx_codbarra.Size = new Size(201, 35);
            tbx_codbarra.TabIndex = 8;
            // 
            // tbx_qtd
            // 
            tbx_qtd.Location = new Point(370, 141);
            tbx_qtd.Name = "tbx_qtd";
            tbx_qtd.Size = new Size(100, 35);
            tbx_qtd.TabIndex = 9;
            // 
            // lbl_codbarras
            // 
            lbl_codbarras.BackColor = Color.White;
            lbl_codbarras.Location = new Point(560, 231);
            lbl_codbarras.Name = "lbl_codbarras";
            lbl_codbarras.Size = new Size(196, 34);
            lbl_codbarras.TabIndex = 10;
            // 
            // lbl_qtd
            // 
            lbl_qtd.BackColor = Color.White;
            lbl_qtd.Location = new Point(560, 385);
            lbl_qtd.Name = "lbl_qtd";
            lbl_qtd.Size = new Size(196, 34);
            lbl_qtd.TabIndex = 11;
            // 
            // lbl_valortotal
            // 
            lbl_valortotal.BackColor = Color.White;
            lbl_valortotal.Location = new Point(560, 612);
            lbl_valortotal.Name = "lbl_valortotal";
            lbl_valortotal.Size = new Size(196, 34);
            lbl_valortotal.TabIndex = 12;
            // 
            // lbl_valorunitario
            // 
            lbl_valorunitario.BackColor = Color.White;
            lbl_valorunitario.Location = new Point(560, 467);
            lbl_valorunitario.Name = "lbl_valorunitario";
            lbl_valorunitario.Size = new Size(196, 34);
            lbl_valorunitario.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(618, 427);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(138, 30);
            label12.TabIndex = 13;
            label12.Text = "Valor Unitário";
            // 
            // btn_fecharvenda
            // 
            btn_fecharvenda.Location = new Point(93, 552);
            btn_fecharvenda.Name = "btn_fecharvenda";
            btn_fecharvenda.Size = new Size(171, 38);
            btn_fecharvenda.TabIndex = 15;
            btn_fecharvenda.Text = "Fechar Venda";
            btn_fecharvenda.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(585, 138);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(171, 38);
            btn_buscar.TabIndex = 16;
            btn_buscar.Text = "Confirmar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_confirmar_Click;
            // 
            // lbl_produto
            // 
            lbl_produto.BackColor = Color.White;
            lbl_produto.Location = new Point(560, 308);
            lbl_produto.Name = "lbl_produto";
            lbl_produto.Size = new Size(196, 34);
            lbl_produto.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(671, 267);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 30);
            label8.TabIndex = 17;
            label8.Text = "Produto";
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(384, 595);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(120, 37);
            btn_confirmar.TabIndex = 19;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            // 
            // TelaPDV
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(806, 684);
            Controls.Add(btn_confirmar);
            Controls.Add(lbl_produto);
            Controls.Add(label8);
            Controls.Add(btn_buscar);
            Controls.Add(btn_fecharvenda);
            Controls.Add(lbl_valorunitario);
            Controls.Add(label12);
            Controls.Add(lbl_valortotal);
            Controls.Add(lbl_qtd);
            Controls.Add(lbl_codbarras);
            Controls.Add(tbx_qtd);
            Controls.Add(tbx_codbarra);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgv_PDV);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TelaPDV";
            Text = "TelaPDV";
            ((System.ComponentModel.ISupportInitialize)dgv_PDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_PDV;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbx_codbarra;
        private TextBox tbx_qtd;
        private Label lbl_codbarras;
        private Label lbl_qtd;
        private Label lbl_valortotal;
        private Label lbl_valorunitario;
        private Label label12;
        private Button btn_fecharvenda;
        private Button btn_buscar;
        private Label lbl_produto;
        private Label label8;
        private Button btn_confirmar;
    }
}