namespace ProyectoFinal.Prestamos
{
    partial class NuevoPrestamo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombrecomboBox = new System.Windows.Forms.ComboBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoClientetextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GarantecomboBox = new System.Windows.Forms.ComboBox();
            this.Garante = new System.Windows.Forms.Label();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FormadePagocomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MesesnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InteresnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrestamotextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NumeroCuotastextBox = new System.Windows.Forms.TextBox();
            this.ValorPorCuotastextBox = new System.Windows.Forms.TextBox();
            this.Prestamos2textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.InteresFinaltextBox = new System.Windows.Forms.TextBox();
            this.MontoFinaltextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Salirbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesesnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteresnumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombrecomboBox);
            this.groupBox1.Controls.Add(this.ApellidoTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CodigoClientetextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // NombrecomboBox
            // 
            this.NombrecomboBox.FormattingEnabled = true;
            this.NombrecomboBox.Location = new System.Drawing.Point(583, 29);
            this.NombrecomboBox.Name = "NombrecomboBox";
            this.NombrecomboBox.Size = new System.Drawing.Size(246, 21);
            this.NombrecomboBox.TabIndex = 5;
            this.NombrecomboBox.SelectedIndexChanged += new System.EventHandler(this.NombrecomboBox_SelectedIndexChanged);
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Enabled = false;
            this.ApellidoTextBox.Location = new System.Drawing.Point(273, 29);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(233, 20);
            this.ApellidoTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Cliente";
            // 
            // CodigoClientetextBox
            // 
            this.CodigoClientetextBox.Enabled = false;
            this.CodigoClientetextBox.Location = new System.Drawing.Point(104, 29);
            this.CodigoClientetextBox.Name = "CodigoClientetextBox";
            this.CodigoClientetextBox.Size = new System.Drawing.Size(100, 20);
            this.CodigoClientetextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.GarantecomboBox);
            this.groupBox2.Controls.Add(this.Garante);
            this.groupBox2.Controls.Add(this.Calcularbutton);
            this.groupBox2.Controls.Add(this.FechadateTimePicker);
            this.groupBox2.Controls.Add(this.FormadePagocomboBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.MesesnumericUpDown);
            this.groupBox2.Controls.Add(this.InteresnumericUpDown);
            this.groupBox2.Controls.Add(this.PrestamotextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terminos del Prestamo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // GarantecomboBox
            // 
            this.GarantecomboBox.Enabled = false;
            this.GarantecomboBox.FormattingEnabled = true;
            this.GarantecomboBox.Location = new System.Drawing.Point(524, 68);
            this.GarantecomboBox.Name = "GarantecomboBox";
            this.GarantecomboBox.Size = new System.Drawing.Size(202, 21);
            this.GarantecomboBox.TabIndex = 14;
            // 
            // Garante
            // 
            this.Garante.AutoSize = true;
            this.Garante.Location = new System.Drawing.Point(472, 67);
            this.Garante.Name = "Garante";
            this.Garante.Size = new System.Drawing.Size(45, 13);
            this.Garante.TabIndex = 13;
            this.Garante.Text = "Garante";
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Enabled = false;
            this.Calcularbutton.Location = new System.Drawing.Point(741, 11);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 49);
            this.Calcularbutton.TabIndex = 12;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Enabled = false;
            this.FechadateTimePicker.Location = new System.Drawing.Point(524, 21);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.FechadateTimePicker.TabIndex = 11;
            // 
            // FormadePagocomboBox
            // 
            this.FormadePagocomboBox.Enabled = false;
            this.FormadePagocomboBox.Location = new System.Drawing.Point(273, 68);
            this.FormadePagocomboBox.Name = "FormadePagocomboBox";
            this.FormadePagocomboBox.Size = new System.Drawing.Size(179, 21);
            this.FormadePagocomboBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Meses";
            // 
            // MesesnumericUpDown
            // 
            this.MesesnumericUpDown.Enabled = false;
            this.MesesnumericUpDown.Location = new System.Drawing.Point(273, 30);
            this.MesesnumericUpDown.Name = "MesesnumericUpDown";
            this.MesesnumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.MesesnumericUpDown.TabIndex = 8;
            // 
            // InteresnumericUpDown
            // 
            this.InteresnumericUpDown.Enabled = false;
            this.InteresnumericUpDown.Location = new System.Drawing.Point(78, 68);
            this.InteresnumericUpDown.Name = "InteresnumericUpDown";
            this.InteresnumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.InteresnumericUpDown.TabIndex = 7;
            // 
            // PrestamotextBox
            // 
            this.PrestamotextBox.Enabled = false;
            this.PrestamotextBox.Location = new System.Drawing.Point(78, 29);
            this.PrestamotextBox.Name = "PrestamotextBox";
            this.PrestamotextBox.Size = new System.Drawing.Size(126, 20);
            this.PrestamotextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(469, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Forma de Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tiempo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Interes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prestamo";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.NumeroCuotastextBox);
            this.groupBox3.Controls.Add(this.ValorPorCuotastextBox);
            this.groupBox3.Controls.Add(this.Prestamos2textBox);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.InteresFinaltextBox);
            this.groupBox3.Controls.Add(this.MontoFinaltextBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(835, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Totales";
            // 
            // NumeroCuotastextBox
            // 
            this.NumeroCuotastextBox.Enabled = false;
            this.NumeroCuotastextBox.Location = new System.Drawing.Point(681, 30);
            this.NumeroCuotastextBox.Name = "NumeroCuotastextBox";
            this.NumeroCuotastextBox.Size = new System.Drawing.Size(113, 20);
            this.NumeroCuotastextBox.TabIndex = 7;
            // 
            // ValorPorCuotastextBox
            // 
            this.ValorPorCuotastextBox.Enabled = false;
            this.ValorPorCuotastextBox.Location = new System.Drawing.Point(337, 70);
            this.ValorPorCuotastextBox.Name = "ValorPorCuotastextBox";
            this.ValorPorCuotastextBox.Size = new System.Drawing.Size(137, 20);
            this.ValorPorCuotastextBox.TabIndex = 11;
            // 
            // Prestamos2textBox
            // 
            this.Prestamos2textBox.Enabled = false;
            this.Prestamos2textBox.Location = new System.Drawing.Point(468, 30);
            this.Prestamos2textBox.Name = "Prestamos2textBox";
            this.Prestamos2textBox.Size = new System.Drawing.Size(113, 20);
            this.Prestamos2textBox.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(300, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Valor";
            // 
            // InteresFinaltextBox
            // 
            this.InteresFinaltextBox.Enabled = false;
            this.InteresFinaltextBox.Location = new System.Drawing.Point(292, 30);
            this.InteresFinaltextBox.Name = "InteresFinaltextBox";
            this.InteresFinaltextBox.Size = new System.Drawing.Size(113, 20);
            this.InteresFinaltextBox.TabIndex = 5;
            // 
            // MontoFinaltextBox
            // 
            this.MontoFinaltextBox.Enabled = false;
            this.MontoFinaltextBox.Location = new System.Drawing.Point(91, 30);
            this.MontoFinaltextBox.Name = "MontoFinaltextBox";
            this.MontoFinaltextBox.Size = new System.Drawing.Size(113, 20);
            this.MontoFinaltextBox.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(595, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Numero Cuotas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(411, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Prestamo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Interes Final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Monto Final";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(776, 320);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 42);
            this.Guardarbutton.TabIndex = 5;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(776, 368);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 42);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Salirbutton
            // 
            this.Salirbutton.Location = new System.Drawing.Point(776, 416);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(75, 42);
            this.Salirbutton.TabIndex = 7;
            this.Salirbutton.Text = "Salir";
            this.Salirbutton.UseVisualStyleBackColor = true;
            // 
            // NuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 473);
            this.Controls.Add(this.Salirbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoPrestamo";
            this.Text = "Nuevo Prestamo";
            this.Load += new System.EventHandler(this.NuevoPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesesnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteresnumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox NombrecomboBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoClientetextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.ComboBox FormadePagocomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown MesesnumericUpDown;
        private System.Windows.Forms.NumericUpDown InteresnumericUpDown;
        private System.Windows.Forms.TextBox PrestamotextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox NumeroCuotastextBox;
        private System.Windows.Forms.TextBox ValorPorCuotastextBox;
        private System.Windows.Forms.TextBox Prestamos2textBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox InteresFinaltextBox;
        private System.Windows.Forms.TextBox MontoFinaltextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Salirbutton;
        private System.Windows.Forms.ComboBox GarantecomboBox;
        private System.Windows.Forms.Label Garante;
    }
}