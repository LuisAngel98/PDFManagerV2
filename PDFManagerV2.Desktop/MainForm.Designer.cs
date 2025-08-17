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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btn_SaveConfig = new TabControl();
            Tab_Generar = new TabPage();
            groupBox1 = new GroupBox();
            btnGuardar = new Button();
            label6 = new Label();
            txtNombres = new TextBox();
            label7 = new Label();
            label4 = new Label();
            txtConcepto = new TextBox();
            label3 = new Label();
            label5 = new Label();
            btnBuscar = new Button();
            txtMonto = new NumericUpDown();
            txtApellidos = new TextBox();
            txtDni = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Tab_Listar = new TabPage();
            label10 = new Label();
            label9 = new Label();
            dgvRecibos = new DataGridView();
            Col_Cliente = new DataGridViewTextBoxColumn();
            Col_Codigo = new DataGridViewTextBoxColumn();
            Col_Fecha = new DataGridViewTextBoxColumn();
            Col_Open = new DataGridViewImageColumn();
            groupBox2 = new GroupBox();
            btnListar = new Button();
            txtDniBusqueda = new TextBox();
            label8 = new Label();
            Tab_Configuracion = new TabPage();
            btn_GuardarConfig = new Button();
            groupBox4 = new GroupBox();
            txtApiKeyReniec = new TextBox();
            label13 = new Label();
            groupBox3 = new GroupBox();
            txtDestino = new TextBox();
            txtoOrigen = new TextBox();
            label12 = new Label();
            label11 = new Label();
            btn_SaveConfig.SuspendLayout();
            Tab_Generar.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtMonto).BeginInit();
            Tab_Listar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecibos).BeginInit();
            groupBox2.SuspendLayout();
            Tab_Configuracion.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_SaveConfig
            // 
            btn_SaveConfig.Controls.Add(Tab_Generar);
            btn_SaveConfig.Controls.Add(Tab_Listar);
            btn_SaveConfig.Controls.Add(Tab_Configuracion);
            btn_SaveConfig.Location = new Point(3, 3);
            btn_SaveConfig.Name = "btn_SaveConfig";
            btn_SaveConfig.SelectedIndex = 0;
            btn_SaveConfig.Size = new Size(792, 445);
            btn_SaveConfig.TabIndex = 0;
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
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtConcepto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(201, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 393);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(72, 350);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(284, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Generar Recibo";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 134);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 11;
            label6.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(45, 160);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(147, 23);
            txtNombres.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 202);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 13;
            label7.Text = "Datos del recibo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 287);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 3;
            label4.Text = "Por concepto de:";
            // 
            // txtConcepto
            // 
            txtConcepto.Location = new Point(50, 305);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(306, 23);
            txtConcepto.TabIndex = 6;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 134);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 10;
            label5.Text = "Apellidos";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(295, 74);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            txtMonto.DecimalPlaces = 2;
            txtMonto.Location = new Point(50, 250);
            txtMonto.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(120, 23);
            txtMonto.TabIndex = 5;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(236, 160);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(162, 23);
            txtApellidos.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(42, 74);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(237, 23);
            txtDni.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 232);
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
            Tab_Listar.Controls.Add(dgvRecibos);
            Tab_Listar.Controls.Add(groupBox2);
            Tab_Listar.Location = new Point(4, 24);
            Tab_Listar.Name = "Tab_Listar";
            Tab_Listar.Padding = new Padding(3);
            Tab_Listar.Size = new Size(784, 417);
            Tab_Listar.TabIndex = 1;
            Tab_Listar.Text = "LISTAR";
            Tab_Listar.UseVisualStyleBackColor = true;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(551, 370);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 2;
            label9.Text = "Total Registros:";
            // 
            // dgvRecibos
            // 
            dgvRecibos.AllowUserToAddRows = false;
            dgvRecibos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvRecibos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecibos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecibos.ColumnHeadersHeight = 36;
            dgvRecibos.Columns.AddRange(new DataGridViewColumn[] { Col_Cliente, Col_Codigo, Col_Fecha, Col_Open });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRecibos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecibos.EnableHeadersVisualStyles = false;
            dgvRecibos.Location = new Point(62, 149);
            dgvRecibos.Name = "dgvRecibos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRecibos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRecibos.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvRecibos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvRecibos.RowTemplate.Height = 36;
            dgvRecibos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecibos.Size = new Size(650, 205);
            dgvRecibos.TabIndex = 1;
            dgvRecibos.CellContentClick += dgvRecibos_CellContentClick;
            // 
            // Col_Cliente
            // 
            Col_Cliente.FillWeight = 158.748154F;
            Col_Cliente.HeaderText = "Cliente";
            Col_Cliente.Name = "Col_Cliente";
            Col_Cliente.Width = 165;
            // 
            // Col_Codigo
            // 
            Col_Codigo.FillWeight = 101.52282F;
            Col_Codigo.HeaderText = "Codigo";
            Col_Codigo.Name = "Col_Codigo";
            Col_Codigo.Width = 215;
            // 
            // Col_Fecha
            // 
            Col_Fecha.FillWeight = 80.30393F;
            Col_Fecha.HeaderText = "Fecha";
            Col_Fecha.Name = "Col_Fecha";
            Col_Fecha.Width = 165;
            // 
            // Col_Open
            // 
            Col_Open.FillWeight = 59.42503F;
            Col_Open.HeaderText = "";
            Col_Open.Image = Properties.Resources.icon_pdf;
            Col_Open.Name = "Col_Open";
            Col_Open.Resizable = DataGridViewTriState.True;
            Col_Open.SortMode = DataGridViewColumnSortMode.Automatic;
            Col_Open.Width = 110;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnListar);
            groupBox2.Controls.Add(txtDniBusqueda);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(62, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(649, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(449, 41);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // txtDniBusqueda
            // 
            txtDniBusqueda.Location = new Point(129, 41);
            txtDniBusqueda.Name = "txtDniBusqueda";
            txtDniBusqueda.Size = new Size(284, 23);
            txtDniBusqueda.TabIndex = 1;
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
            // Tab_Configuracion
            // 
            Tab_Configuracion.Controls.Add(btn_GuardarConfig);
            Tab_Configuracion.Controls.Add(groupBox4);
            Tab_Configuracion.Controls.Add(groupBox3);
            Tab_Configuracion.Location = new Point(4, 24);
            Tab_Configuracion.Name = "Tab_Configuracion";
            Tab_Configuracion.Size = new Size(784, 417);
            Tab_Configuracion.TabIndex = 2;
            Tab_Configuracion.Text = "CONFIGURACION";
            Tab_Configuracion.UseVisualStyleBackColor = true;
            // 
            // btn_GuardarConfig
            // 
            btn_GuardarConfig.Location = new Point(270, 367);
            btn_GuardarConfig.Name = "btn_GuardarConfig";
            btn_GuardarConfig.Size = new Size(225, 23);
            btn_GuardarConfig.TabIndex = 2;
            btn_GuardarConfig.Text = "Guardar Configuración";
            btn_GuardarConfig.UseVisualStyleBackColor = true;
            btn_GuardarConfig.Click += btn_GuardarConfig_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtApiKeyReniec);
            groupBox4.Controls.Add(label13);
            groupBox4.Location = new Point(49, 252);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(681, 100);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "API Keys";
            // 
            // txtApiKeyReniec
            // 
            txtApiKeyReniec.Location = new Point(31, 52);
            txtApiKeyReniec.Name = "txtApiKeyReniec";
            txtApiKeyReniec.Size = new Size(333, 23);
            txtApiKeyReniec.TabIndex = 1;
            txtApiKeyReniec.Text = "**********";
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
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDestino);
            groupBox3.Controls.Add(txtoOrigen);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(49, 40);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(681, 156);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Configuración de Archivos PDF";
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(31, 111);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(333, 23);
            txtDestino.TabIndex = 3;
            // 
            // txtoOrigen
            // 
            txtoOrigen.Location = new Point(31, 55);
            txtoOrigen.Name = "txtoOrigen";
            txtoOrigen.Size = new Size(333, 23);
            txtoOrigen.TabIndex = 2;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 37);
            label11.Name = "label11";
            label11.Size = new Size(181, 15);
            label11.TabIndex = 0;
            label11.Text = "Ruta de Origen (Lectura de PDFs)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_SaveConfig);
            Name = "MainForm";
            Text = "PDFManager";
            Load += MainForm_Load;
            btn_SaveConfig.ResumeLayout(false);
            Tab_Generar.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtMonto).EndInit();
            Tab_Listar.ResumeLayout(false);
            Tab_Listar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecibos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            Tab_Configuracion.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl btn_SaveConfig;
        private TabPage Tab_Generar;
        private TabPage Tab_Listar;
        private TabPage Tab_Configuracion;
        private GroupBox groupBox1;
        private NumericUpDown txtMonto;
        private TextBox txtNombres;
        private TextBox txtConcepto;
        private TextBox txtApellidos;
        private TextBox txtDni;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Button btnBuscar;
        private Label label3;
        private Label label7;
        private DataGridView dgvRecibos;
        private GroupBox groupBox2;
        private Button btnListar;
        private TextBox txtDniBusqueda;
        private Label label8;
        private Label label10;
        private Label label9;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox txtApiKeyReniec;
        private Label label13;
        private TextBox txtDestino;
        private TextBox txtoOrigen;
        private Label label12;
        private Label label11;
        private Button btn_GuardarConfig;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn Col_Cliente;
        private DataGridViewTextBoxColumn Col_Codigo;
        private DataGridViewTextBoxColumn Col_Fecha;
        private DataGridViewImageColumn Col_Open;
    }
}
