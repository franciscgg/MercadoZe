namespace MercadoZe.View.TelasCliente
{
    partial class CadastroCliente
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
            txb_email = new TextBox();
            btn_Cadastrar = new Button();
            mtxb_telefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(85, 71);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(85, 144);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(85, 235);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 3;
            label4.Text = "Celular";
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nome.Location = new Point(85, 104);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(331, 29);
            txb_nome.TabIndex = 4;
            // 
            // txb_email
            // 
            txb_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_email.Location = new Point(85, 177);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(331, 29);
            txb_email.TabIndex = 5;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn_Cadastrar.Location = new Point(222, 364);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(130, 34);
            btn_Cadastrar.TabIndex = 7;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // mtxb_telefone
            // 
            mtxb_telefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtxb_telefone.Location = new Point(85, 268);
            mtxb_telefone.Mask = "(999) 000-0000";
            mtxb_telefone.Name = "mtxb_telefone";
            mtxb_telefone.Size = new Size(156, 29);
            mtxb_telefone.TabIndex = 8;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(574, 450);
            Controls.Add(mtxb_telefone);
            Controls.Add(btn_Cadastrar);
            Controls.Add(txb_email);
            Controls.Add(txb_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txb_nome;
        private TextBox txb_email;
        private Button btn_Cadastrar;
        private MaskedTextBox mtxb_telefone;
    }
}