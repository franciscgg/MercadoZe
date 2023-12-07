namespace MercadoZe.View.TelasCliente
{
    partial class DeletarCliente
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
            btn_Excluir = new Button();
            btn_Buscar = new Button();
            txb_Matricula = new TextBox();
            txb_NumeroUsuario = new TextBox();
            txb_Email = new TextBox();
            txb_Nome = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Excluir
            // 
            btn_Excluir.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btn_Excluir.Location = new Point(457, 461);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(94, 40);
            btn_Excluir.TabIndex = 26;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = true;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btn_Buscar.Location = new Point(353, 130);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(94, 40);
            btn_Buscar.TabIndex = 25;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click_1;
            // 
            // txb_Matricula
            // 
            txb_Matricula.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_Matricula.Location = new Point(128, 137);
            txb_Matricula.Name = "txb_Matricula";
            txb_Matricula.Size = new Size(205, 29);
            txb_Matricula.TabIndex = 24;
            // 
            // txb_NumeroUsuario
            // 
            txb_NumeroUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_NumeroUsuario.Location = new Point(234, 417);
            txb_NumeroUsuario.Margin = new Padding(5, 6, 5, 6);
            txb_NumeroUsuario.Name = "txb_NumeroUsuario";
            txb_NumeroUsuario.Size = new Size(202, 29);
            txb_NumeroUsuario.TabIndex = 22;
            // 
            // txb_Email
            // 
            txb_Email.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_Email.Location = new Point(113, 290);
            txb_Email.Margin = new Padding(5, 6, 5, 6);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(323, 29);
            txb_Email.TabIndex = 21;
            // 
            // txb_Nome
            // 
            txb_Nome.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_Nome.Location = new Point(113, 226);
            txb_Nome.Margin = new Padding(5, 6, 5, 6);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(323, 29);
            txb_Nome.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(35, 413);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(189, 30);
            label6.TabIndex = 19;
            label6.Text = "Número do Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(35, 286);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 17;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(35, 222);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 16;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(31, 95);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(312, 30);
            label2.TabIndex = 15;
            label2.Text = "Digite a Matricula do Funcionário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(211, 8);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 37);
            label1.TabIndex = 14;
            label1.Text = "Excluir Usuário";
            // 
            // DeletarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 510);
            Controls.Add(btn_Excluir);
            Controls.Add(btn_Buscar);
            Controls.Add(txb_Matricula);
            Controls.Add(txb_NumeroUsuario);
            Controls.Add(txb_Email);
            Controls.Add(txb_Nome);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeletarCliente";
            Text = "DeletarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Excluir;
        private Button btn_Buscar;
        private TextBox txb_Matricula;
        private TextBox txb_NumeroUsuario;
        private TextBox txb_Email;
        private TextBox txb_Nome;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}