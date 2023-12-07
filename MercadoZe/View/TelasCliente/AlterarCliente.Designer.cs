namespace MercadoZe.View.TelasCliente
{
    partial class AlterarCliente
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
            btn_Buscar = new Button();
            label4 = new Label();
            label3 = new Label();
            txb_EmailFunci = new TextBox();
            txb_NomeFunci = new TextBox();
            txb_MatriculaFunci = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label7 = new Label();
            txb_NumeroUsuario = new TextBox();
            SuspendLayout();
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btn_Buscar.Location = new Point(358, 95);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(88, 33);
            btn_Buscar.TabIndex = 29;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(60, 190);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 24;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(60, 150);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 23;
            label3.Text = "Nome";
            // 
            // txb_EmailFunci
            // 
            txb_EmailFunci.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_EmailFunci.Location = new Point(131, 194);
            txb_EmailFunci.Name = "txb_EmailFunci";
            txb_EmailFunci.Size = new Size(241, 29);
            txb_EmailFunci.TabIndex = 19;
            // 
            // txb_NomeFunci
            // 
            txb_NomeFunci.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_NomeFunci.Location = new Point(131, 154);
            txb_NomeFunci.Name = "txb_NomeFunci";
            txb_NomeFunci.Size = new Size(241, 29);
            txb_NomeFunci.TabIndex = 18;
            // 
            // txb_MatriculaFunci
            // 
            txb_MatriculaFunci.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_MatriculaFunci.Location = new Point(176, 99);
            txb_MatriculaFunci.Name = "txb_MatriculaFunci";
            txb_MatriculaFunci.Size = new Size(176, 29);
            txb_MatriculaFunci.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(60, 65);
            label2.Name = "label2";
            label2.Size = new Size(269, 30);
            label2.TabIndex = 16;
            label2.Text = "Digite a Matricula do Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(187, 14);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 15;
            label1.Text = "Alterar Cliente";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(405, 348);
            button1.Name = "button1";
            button1.Size = new Size(88, 33);
            button1.TabIndex = 33;
            button1.Text = "Alterar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(60, 233);
            label7.Name = "label7";
            label7.Size = new Size(56, 30);
            label7.TabIndex = 32;
            label7.Text = "Fone";
            // 
            // txb_NumeroUsuario
            // 
            txb_NumeroUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_NumeroUsuario.Location = new Point(131, 237);
            txb_NumeroUsuario.Name = "txb_NumeroUsuario";
            txb_NumeroUsuario.Size = new Size(241, 29);
            txb_NumeroUsuario.TabIndex = 31;
            // 
            // AlterarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 450);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(txb_NumeroUsuario);
            Controls.Add(btn_Buscar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txb_EmailFunci);
            Controls.Add(txb_NomeFunci);
            Controls.Add(txb_MatriculaFunci);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AlterarCliente";
            Text = "AlterarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Buscar;
        private Label label4;
        private Label label3;
        private TextBox txb_EmailFunci;
        private TextBox txb_NomeFunci;
        private TextBox txb_MatriculaFunci;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label7;
        private TextBox txb_NumeroUsuario;
    }
}