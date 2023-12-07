namespace MercadoZe.View.TelasUsuario
{
    partial class AlterarUsuario
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
            txb_MatriculaFunci = new TextBox();
            txb_NomeFunci = new TextBox();
            txb_EmailFunci = new TextBox();
            txb_SenhaFunci = new TextBox();
            txb_NumeroUsuario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            btn_Alterar = new Button();
            btn_Buscar = new Button();
            label5 = new Label();
            cbx_TipoFunci = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 0;
            label1.Text = "Alterar Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(30, 60);
            label2.Name = "label2";
            label2.Size = new Size(312, 30);
            label2.TabIndex = 1;
            label2.Text = "Digite a Matricula do Funcionario";
            // 
            // txb_MatriculaFunci
            // 
            txb_MatriculaFunci.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_MatriculaFunci.Location = new Point(146, 94);
            txb_MatriculaFunci.Name = "txb_MatriculaFunci";
            txb_MatriculaFunci.Size = new Size(176, 29);
            txb_MatriculaFunci.TabIndex = 2;
            // 
            // txb_NomeFunci
            // 
            txb_NomeFunci.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_NomeFunci.Location = new Point(101, 149);
            txb_NomeFunci.Name = "txb_NomeFunci";
            txb_NomeFunci.Size = new Size(241, 29);
            txb_NomeFunci.TabIndex = 3;
            // 
            // txb_EmailFunci
            // 
            txb_EmailFunci.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_EmailFunci.Location = new Point(101, 189);
            txb_EmailFunci.Name = "txb_EmailFunci";
            txb_EmailFunci.Size = new Size(241, 29);
            txb_EmailFunci.TabIndex = 4;
            // 
            // txb_SenhaFunci
            // 
            txb_SenhaFunci.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_SenhaFunci.Location = new Point(104, 272);
            txb_SenhaFunci.Name = "txb_SenhaFunci";
            txb_SenhaFunci.Size = new Size(238, 29);
            txb_SenhaFunci.TabIndex = 5;
            // 
            // txb_NumeroUsuario
            // 
            txb_NumeroUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_NumeroUsuario.Location = new Point(207, 349);
            txb_NumeroUsuario.Name = "txb_NumeroUsuario";
            txb_NumeroUsuario.Size = new Size(100, 29);
            txb_NumeroUsuario.TabIndex = 6;
            txb_NumeroUsuario.TextChanged += txb_NumeroUsuario_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(30, 145);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 8;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(30, 185);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(30, 268);
            label6.Name = "label6";
            label6.Size = new Size(68, 30);
            label6.TabIndex = 11;
            label6.Text = "Senha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(12, 345);
            label7.Name = "label7";
            label7.Size = new Size(189, 30);
            label7.TabIndex = 12;
            label7.Text = "Número do Usuário";
            // 
            // btn_Alterar
            // 
            btn_Alterar.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btn_Alterar.Location = new Point(357, 389);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(88, 33);
            btn_Alterar.TabIndex = 13;
            btn_Alterar.Text = "Alterar";
            btn_Alterar.UseVisualStyleBackColor = true;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btn_Buscar.Location = new Point(328, 90);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(88, 33);
            btn_Buscar.TabIndex = 14;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(33, 233);
            label5.Name = "label5";
            label5.Size = new Size(51, 30);
            label5.TabIndex = 27;
            label5.Text = "Tipo";
            // 
            // cbx_TipoFunci
            // 
            cbx_TipoFunci.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            cbx_TipoFunci.FormattingEnabled = true;
            cbx_TipoFunci.Location = new Point(104, 237);
            cbx_TipoFunci.Name = "cbx_TipoFunci";
            cbx_TipoFunci.Size = new Size(121, 29);
            cbx_TipoFunci.TabIndex = 26;
            // 
            // AlterarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 438);
            Controls.Add(label5);
            Controls.Add(cbx_TipoFunci);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Alterar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txb_NumeroUsuario);
            Controls.Add(txb_SenhaFunci);
            Controls.Add(txb_EmailFunci);
            Controls.Add(txb_NomeFunci);
            Controls.Add(txb_MatriculaFunci);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AlterarUsuario";
            Text = "AlterarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txb_MatriculaFunci;
        private TextBox txb_NomeFunci;
        private TextBox txb_EmailFunci;
        private TextBox txb_SenhaFunci;
        private TextBox txb_NumeroUsuario;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button btn_Alterar;
        private Button btn_Buscar;
        private Label label5;
        private ComboBox cbx_TipoFunci;
    }
}