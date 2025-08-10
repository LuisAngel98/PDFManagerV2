namespace PDFManagerV2.Desktop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Tab_Generar = new TabPage();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            Tab_Listar = new TabPage();
            Tab_Configuracion = new TabPage();
            label7 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Col_Cliente = new DataGridViewTextBoxColumn();
            Col_Codigo = new DataGridViewTextBoxColumn();
            Col_Fecha = new DataGridViewTextBoxColumn();
            label9 = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label11 = new Label();
            label12 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label13 = new Label();
            textBox8 = new TextBox();
            button3 = new Button();
            tabControl1.SuspendLayout();
            Tab_Generar.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            Tab_Listar.SuspendLayout();
            Tab_Configuracion.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Tab_Generar);
            tabControl1.Controls.Add(Tab_Listar);
            tabControl1.Controls.Add(Tab_Configuracion);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(792, 445);
            tabControl1.TabIndex = 0;
            // 
            // Tab_Generar
            // 
            Tab_Generar.Controls.Add(groupBox1);
            Tab_Generar.Location = new Point(4, 24);
            Tab_Generar.Name = "Tab_Generar";
            Tab_Generar.Padding = new Padding(3);
            Tab_Generar.Size = new Size(784, 417);
            Tab_Generar.TabIndex = 0;
            Tab_Generar.Text = "GENERAR";
            Tab_Generar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(201, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 393);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 100);
            label3.Name = "label3";
            label3.Size = new Size(355, 15);
            label3.TabIndex = 12;
            label3.Text = "Ingrese el DNI y presione buscar para completar automáticamente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 134);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 11;
            label6.Text = "Nombres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 134);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 10;
            label5.Text = "Apellidos";
            // 
            // button1
            // 
            button1.Location = new Point(295, 74);
            button1.Name = "button1";
            button1.Size = new Size(98, 23);
            button1.TabIndex = 9;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(50, 278);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(223, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 350);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 321);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 3;
            label4.Text = "Por concepto de:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 250);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "La cantidad de:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 47);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // Tab_Listar
            // 
            Tab_Listar.Controls.Add(label10);
            Tab_Listar.Controls.Add(label9);
            Tab_Listar.Controls.Add(dataGridView1);
            Tab_Listar.Controls.Add(groupBox2);
            Tab_Listar.Location = new Point(4, 24);
            Tab_Listar.Name = "Tab_Listar";
            Tab_Listar.Padding = new Padding(3);
            Tab_Listar.Size = new Size(784, 417);
            Tab_Listar.TabIndex = 1;
            Tab_Listar.Text = "LISTAR";
            Tab_Listar.UseVisualStyleBackColor = true;
            // 
            // Tab_Configuracion
            // 
            Tab_Configuracion.Controls.Add(button3);
            Tab_Configuracion.Controls.Add(groupBox4);
            Tab_Configuracion.Controls.Add(groupBox3);
            Tab_Configuracion.Location = new Point(4, 24);
            Tab_Configuracion.Name = "Tab_Configuracion";
            Tab_Configuracion.Size = new Size(784, 417);
            Tab_Configuracion.TabIndex = 2;
            Tab_Configuracion.Text = "CONFIGURACION";
            Tab_Configuracion.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 210);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 13;
            label7.Text = "Datos del recibo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(62, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(649, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(73, 44);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 0;
            label8.Text = "DNI:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 41);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(284, 23);
            textBox5.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(449, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Listar";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Col_Cliente, Col_Codigo, Col_Fecha });
            dataGridView1.Location = new Point(62, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(649, 205);
            dataGridView1.TabIndex = 1;
            // 
            // Col_Cliente
            // 
            Col_Cliente.HeaderText = "Cliente";
            Col_Cliente.Name = "Col_Cliente";
            // 
            // Col_Codigo
            // 
            Col_Codigo.HeaderText = "Codigo";
            Col_Codigo.Name = "Col_Codigo";
            // 
            // Col_Fecha
            // 
            Col_Fecha.HeaderText = "Fecha";
            Col_Fecha.Name = "Col_Fecha";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(551, 370);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 2;
            label9.Text = "Total Registros:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(642, 371);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 3;
            label10.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(49, 40);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(681, 156);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Configuración de Archivos PDF";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(label13);
            groupBox4.Location = new Point(49, 252);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(681, 100);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "API Keys";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 37);
            label11.Name = "label11";
            label11.Size = new Size(181, 15);
            label11.TabIndex = 0;
            label11.Text = "Ruta de Origen (Lectura de PDFs)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(31, 93);
            label12.Name = "label12";
            label12.Size = new Size(191, 15);
            label12.TabIndex = 1;
            label12.Text = "Ruta de Destino (Escritura de PDFs)";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(31, 55);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(333, 23);
            textBox6.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(31, 111);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(333, 23);
            textBox7.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(31, 34);
            label13.Name = "label13";
            label13.Size = new Size(105, 15);
            label13.TabIndex = 0;
            label13.Text = "API Key de RENIEC";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(31, 52);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(333, 23);
            textBox8.TabIndex = 1;
            textBox8.Text = "**********";
            // 
            // button3
            // 
            button3.Location = new Point(270, 367);
            button3.Name = "button3";
            button3.Size = new Size(225, 23);
            button3.TabIndex = 2;
            button3.Text = "Guardar Configuración";
            button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "PDFManager";
            tabControl1.ResumeLayout(false);
            Tab_Generar.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            Tab_Listar.ResumeLayout(false);
            Tab_Listar.PerformLayout();
            Tab_Configuracion.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Tab_Generar;
        private TabPage Tab_Listar;
        private TabPage Tab_Configuracion;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Button button1;
        private Label label3;
        private Label label7;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button button2;
        private TextBox textBox5;
        private Label label8;
        private Label label10;
        private Label label9;
        private DataGridViewTextBoxColumn Col_Cliente;
        private DataGridViewTextBoxColumn Col_Codigo;
        private DataGridViewTextBoxColumn Col_Fecha;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox textBox8;
        private Label label13;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label12;
        private Label label11;
        private Button button3;
    }
}
