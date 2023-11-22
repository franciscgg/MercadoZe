namespace MercadoZe.View.TelasProduto
{
    partial class CadastroProduto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txb_nome = new TextBox();
            txb_marca = new TextBox();
            txb_valor = new TextBox();
            btn_cadastrar = new Button();
            label5 = new Label();
            txb_qtd = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(109, 81);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(109, 143);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(109, 267);
            label4.Name = "label4";
            label4.Size = new Size(60, 30);
            label4.TabIndex = 3;
            label4.Text = "Valor";
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nome.Location = new Point(114, 111);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(338, 29);
            txb_nome.TabIndex = 4;
            // 
            // txb_marca
            // 
            txb_marca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_marca.Location = new Point(114, 176);
            txb_marca.Name = "txb_marca";
            txb_marca.Size = new Size(338, 29);
            txb_marca.TabIndex = 5;
            // 
            // txb_valor
            // 
            txb_valor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_valor.Location = new Point(114, 300);
            txb_valor.Name = "txb_valor";
            txb_valor.Size = new Size(338, 29);
            txb_valor.TabIndex = 6;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn_cadastrar.Location = new Point(236, 353);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(112, 37);
            btn_cadastrar.TabIndex = 7;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(109, 208);
            label5.Name = "label5";
            label5.Size = new Size(47, 30);
            label5.TabIndex = 8;
            label5.Text = "Qtd";
            // 
            // txb_qtd
            // 
            txb_qtd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_qtd.Location = new Point(114, 241);
            txb_qtd.Name = "txb_qtd";
            txb_qtd.Size = new Size(338, 29);
            txb_qtd.TabIndex = 9;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 450);
            Controls.Add(txb_qtd);
            Controls.Add(label5);
            Controls.Add(btn_cadastrar);
            Controls.Add(txb_valor);
            Controls.Add(txb_marca);
            Controls.Add(txb_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroProduto";
            Text = "CadastroProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txb_nome;
        private TextBox txb_marca;
        private TextBox txb_valor;
        private Button btn_cadastrar;
        private Label label5;
        private TextBox txb_qtd;
    }
}