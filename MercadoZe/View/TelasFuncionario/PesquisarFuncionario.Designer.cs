namespace MercadoZe.View.TelasFuncionario
{
    partial class PesquisarFuncionario
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            txb_NumeroUsuario = new TextBox();
            label7 = new Label();
            txb_Nome = new TextBox();
            txb_Email = new TextBox();
            cbx_Tipo = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            txb_Matricula = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            BuscarTipoUsuario = new Button();
            cbx_TipoUsu = new ComboBox();
            dataGridView1 = new DataGridView();
            coluna_Usu = new DataGridViewTextBoxColumn();
            Coluna_Funci = new DataGridViewTextBoxColumn();
            Coluna_Funcao = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(19, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(763, 355);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(txb_Matricula);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(755, 327);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Buscar por Código";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txb_NumeroUsuario);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txb_Nome);
            groupBox1.Controls.Add(txb_Email);
            groupBox1.Controls.Add(cbx_Tipo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(6, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(743, 266);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // txb_NumeroUsuario
            // 
            txb_NumeroUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txb_NumeroUsuario.Location = new Point(218, 200);
            txb_NumeroUsuario.Name = "txb_NumeroUsuario";
            txb_NumeroUsuario.Size = new Size(100, 29);
            txb_NumeroUsuario.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(12, 200);
            label7.Name = "label7";
            label7.Size = new Size(189, 30);
            label7.TabIndex = 13;
            label7.Text = "Número do Usuário";
            // 
            // txb_Nome
            // 
            txb_Nome.Location = new Point(91, 41);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(169, 23);
            txb_Nome.TabIndex = 5;
            // 
            // txb_Email
            // 
            txb_Email.Location = new Point(91, 88);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(169, 23);
            txb_Email.TabIndex = 4;
            // 
            // cbx_Tipo
            // 
            cbx_Tipo.FormattingEnabled = true;
            cbx_Tipo.Location = new Point(91, 148);
            cbx_Tipo.Name = "cbx_Tipo";
            cbx_Tipo.Size = new Size(169, 23);
            cbx_Tipo.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(12, 141);
            label5.Name = "label5";
            label5.Size = new Size(51, 30);
            label5.TabIndex = 2;
            label5.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 79);
            label4.Name = "label4";
            label4.Size = new Size(73, 30);
            label4.TabIndex = 1;
            label4.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(6, 32);
            label3.Name = "label3";
            label3.Size = new Size(79, 30);
            label3.TabIndex = 0;
            label3.Text = "Nome :";
            // 
            // button1
            // 
            button1.Location = new Point(304, 26);
            button1.Name = "button1";
            button1.Size = new Size(95, 25);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // txb_Matricula
            // 
            txb_Matricula.Location = new Point(109, 28);
            txb_Matricula.Name = "txb_Matricula";
            txb_Matricula.Size = new Size(157, 23);
            txb_Matricula.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(9, 22);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 0;
            label2.Text = "Matricula";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BuscarTipoUsuario);
            tabPage2.Controls.Add(cbx_TipoUsu);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(755, 327);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buscar por Usuario";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BuscarTipoUsuario
            // 
            BuscarTipoUsuario.Location = new Point(517, 41);
            BuscarTipoUsuario.Name = "BuscarTipoUsuario";
            BuscarTipoUsuario.Size = new Size(75, 23);
            BuscarTipoUsuario.TabIndex = 9;
            BuscarTipoUsuario.Text = "Buscar";
            BuscarTipoUsuario.UseVisualStyleBackColor = true;
            // 
            // cbx_TipoUsu
            // 
            cbx_TipoUsu.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            cbx_TipoUsu.FormattingEnabled = true;
            cbx_TipoUsu.Items.AddRange(new object[] { "ponre", "POBRINHO" });
            cbx_TipoUsu.Location = new Point(265, 23);
            cbx_TipoUsu.Name = "cbx_TipoUsu";
            cbx_TipoUsu.Size = new Size(181, 29);
            cbx_TipoUsu.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { coluna_Usu, Coluna_Funci, Coluna_Funcao });
            dataGridView1.Location = new Point(86, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(513, 150);
            dataGridView1.TabIndex = 4;
            // 
            // coluna_Usu
            // 
            coluna_Usu.HeaderText = "Código Usuario";
            coluna_Usu.Name = "coluna_Usu";
            // 
            // Coluna_Funci
            // 
            Coluna_Funci.HeaderText = "Matricula Funcionario";
            Coluna_Funci.Name = "Coluna_Funci";
            // 
            // Coluna_Funcao
            // 
            Coluna_Funcao.HeaderText = "Função";
            Coluna_Funcao.Name = "Coluna_Funcao";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(20, 25);
            label6.Name = "label6";
            label6.Size = new Size(242, 30);
            label6.TabIndex = 1;
            label6.Text = "Escolhe o tipo de Usuario ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(261, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar Funcionario";
            // 
            // PesquisarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "PesquisarFuncionario";
            Text = "PesquisarFuncionario";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TextBox txb_NumeroUsuario;
        private Label label7;
        private TextBox txb_Nome;
        private TextBox txb_Email;
        private ComboBox cbx_Tipo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox txb_Matricula;
        private Label label2;
        private TabPage tabPage2;
        private Button BuscarTipoUsuario;
        private ComboBox cbx_TipoUsu;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn coluna_Usu;
        private DataGridViewTextBoxColumn Coluna_Funci;
        private DataGridViewTextBoxColumn Coluna_Funcao;
        private Label label6;
        private Label label1;
    }
}