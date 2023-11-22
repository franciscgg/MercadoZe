namespace MercadoZe.View.TelasFuncionario
{
    partial class CadastroFuncionario
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
            txb_telefone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(170, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro De Funcionario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(49, 103);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(49, 197);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(49, 292);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 3;
            label4.Text = "Celular";
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nome.Location = new Point(49, 136);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(337, 29);
            txb_nome.TabIndex = 4;
            // 
            // txb_email
            // 
            txb_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_email.Location = new Point(49, 230);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(337, 29);
            txb_email.TabIndex = 5;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn_Cadastrar.Location = new Point(220, 373);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(109, 38);
            btn_Cadastrar.TabIndex = 7;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // txb_telefone
            // 
            txb_telefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_telefone.Location = new Point(49, 325);
            txb_telefone.Name = "txb_telefone";
            txb_telefone.Size = new Size(147, 29);
            txb_telefone.TabIndex = 8;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 450);
            Controls.Add(txb_telefone);
            Controls.Add(btn_Cadastrar);
            Controls.Add(txb_email);
            Controls.Add(txb_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroFuncionario";
            Text = "CadastroFuncionario";
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
        private TextBox txb_telefone;
    }
}