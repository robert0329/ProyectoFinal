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
            this.GarantecomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.TabladataGridView = new System.Windows.Forms.DataGridView();
            this.NCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DiaMoratoriotextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MontoEstimadotextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DiaMoratorianumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.MesesMoratorianumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Carcular = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MesesnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FormaPagocomboBox = new System.Windows.Forms.ComboBox();
            this.InterestextBox = new System.Windows.Forms.TextBox();
            this.CantidatextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DesdemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HastamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MontomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CuotasmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TotalmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabladataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiaMoratorianumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesesMoratorianumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesesnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // GarantecomboBox
            // 
            this.GarantecomboBox.FormattingEnabled = true;
            this.GarantecomboBox.Location = new System.Drawing.Point(210, 125);
            this.GarantecomboBox.Name = "GarantecomboBox";
            this.GarantecomboBox.Size = new System.Drawing.Size(176, 21);
            this.GarantecomboBox.TabIndex = 0;
            this.GarantecomboBox.SelectedIndexChanged += new System.EventHandler(this.GarantecomboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.TabladataGridView);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prestamo";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(6, 65);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(62, 40);
            this.Nuevobutton.TabIndex = 1;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Nuevobutton);
            this.groupBox4.Controls.Add(this.Eliminarbutton);
            this.groupBox4.Controls.Add(this.Guardarbutton);
            this.groupBox4.Location = new System.Drawing.Point(577, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 126);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(80, 19);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(62, 40);
            this.Eliminarbutton.TabIndex = 4;
            this.Eliminarbutton.Text = "Cancelar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(6, 19);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(62, 40);
            this.Guardarbutton.TabIndex = 0;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // TabladataGridView
            // 
            this.TabladataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.TabladataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabladataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabladataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NCuotas,
            this.Cuotas});
            this.TabladataGridView.Location = new System.Drawing.Point(18, 301);
            this.TabladataGridView.Name = "TabladataGridView";
            this.TabladataGridView.Size = new System.Drawing.Size(558, 126);
            this.TabladataGridView.TabIndex = 2;
            // 
            // NCuotas
            // 
            this.NCuotas.HeaderText = "N°";
            this.NCuotas.Name = "NCuotas";
            // 
            // Cuotas
            // 
            this.Cuotas.HeaderText = "Cuotas";
            this.Cuotas.Name = "Cuotas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.DiaMoratoriotextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.MontoEstimadotextBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.DiaMoratorianumericUpDown);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.MesesMoratorianumericUpDown);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(424, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 263);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parametros Moratorio";
            // 
            // DiaMoratoriotextBox
            // 
            this.DiaMoratoriotextBox.Location = new System.Drawing.Point(10, 167);
            this.DiaMoratoriotextBox.Name = "DiaMoratoriotextBox";
            this.DiaMoratoriotextBox.Size = new System.Drawing.Size(277, 20);
            this.DiaMoratoriotextBox.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Estimado por cuota Moratoria";
            // 
            // MontoEstimadotextBox
            // 
            this.MontoEstimadotextBox.Location = new System.Drawing.Point(10, 126);
            this.MontoEstimadotextBox.Name = "MontoEstimadotextBox";
            this.MontoEstimadotextBox.Size = new System.Drawing.Size(277, 20);
            this.MontoEstimadotextBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Monto Moratorio Estimado por Mes";
            // 
            // DiaMoratorianumericUpDown
            // 
            this.DiaMoratorianumericUpDown.Location = new System.Drawing.Point(10, 86);
            this.DiaMoratorianumericUpDown.Name = "DiaMoratorianumericUpDown";
            this.DiaMoratorianumericUpDown.Size = new System.Drawing.Size(277, 20);
            this.DiaMoratorianumericUpDown.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Dias de Gracia Moratoria Por Cuotas";
            // 
            // MesesMoratorianumericUpDown
            // 
            this.MesesMoratorianumericUpDown.Location = new System.Drawing.Point(10, 47);
            this.MesesMoratorianumericUpDown.Name = "MesesMoratorianumericUpDown";
            this.MesesMoratorianumericUpDown.Size = new System.Drawing.Size(277, 20);
            this.MesesMoratorianumericUpDown.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Meses de Gracia Moratoria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalmaskedTextBox);
            this.groupBox2.Controls.Add(this.CuotasmaskedTextBox);
            this.groupBox2.Controls.Add(this.MontomaskedTextBox);
            this.groupBox2.Controls.Add(this.HastamaskedTextBox);
            this.groupBox2.Controls.Add(this.DesdemaskedTextBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.Carcular);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.GarantecomboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.MesesnumericUpDown);
            this.groupBox2.Controls.Add(this.FormaPagocomboBox);
            this.groupBox2.Controls.Add(this.InterestextBox);
            this.groupBox2.Controls.Add(this.CantidatextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 263);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(207, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Hasta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Desde";
            // 
            // Carcular
            // 
            this.Carcular.Location = new System.Drawing.Point(311, 233);
            this.Carcular.Name = "Carcular";
            this.Carcular.Size = new System.Drawing.Size(75, 23);
            this.Carcular.TabIndex = 15;
            this.Carcular.Text = "Calcular";
            this.Carcular.UseVisualStyleBackColor = true;
            this.Carcular.Click += new System.EventHandler(this.Carcular_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "A Pagar por cuotas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Garante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total a Pagar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Meses";
            // 
            // MesesnumericUpDown
            // 
            this.MesesnumericUpDown.Location = new System.Drawing.Point(210, 86);
            this.MesesnumericUpDown.Name = "MesesnumericUpDown";
            this.MesesnumericUpDown.Size = new System.Drawing.Size(176, 20);
            this.MesesnumericUpDown.TabIndex = 8;
            // 
            // FormaPagocomboBox
            // 
            this.FormaPagocomboBox.FormattingEnabled = true;
            this.FormaPagocomboBox.Items.AddRange(new object[] {
            "Semanal",
            "Quincenal",
            "Mensual"});
            this.FormaPagocomboBox.Location = new System.Drawing.Point(10, 126);
            this.FormaPagocomboBox.Name = "FormaPagocomboBox";
            this.FormaPagocomboBox.Size = new System.Drawing.Size(176, 21);
            this.FormaPagocomboBox.TabIndex = 6;
            // 
            // InterestextBox
            // 
            this.InterestextBox.Location = new System.Drawing.Point(10, 86);
            this.InterestextBox.Name = "InterestextBox";
            this.InterestextBox.Size = new System.Drawing.Size(176, 20);
            this.InterestextBox.TabIndex = 5;
            // 
            // CantidatextBox
            // 
            this.CantidatextBox.Location = new System.Drawing.Point(10, 47);
            this.CantidatextBox.Name = "CantidatextBox";
            this.CantidatextBox.Size = new System.Drawing.Size(176, 20);
            this.CantidatextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto Prestado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Forma De Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "%Interes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantida De Cuotas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(8, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // DesdemaskedTextBox
            // 
            this.DesdemaskedTextBox.Location = new System.Drawing.Point(10, 167);
            this.DesdemaskedTextBox.Mask = "00/00/0000";
            this.DesdemaskedTextBox.Name = "DesdemaskedTextBox";
            this.DesdemaskedTextBox.Size = new System.Drawing.Size(176, 20);
            this.DesdemaskedTextBox.TabIndex = 18;
            this.DesdemaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // HastamaskedTextBox
            // 
            this.HastamaskedTextBox.Location = new System.Drawing.Point(210, 166);
            this.HastamaskedTextBox.Mask = "00/00/0000";
            this.HastamaskedTextBox.Name = "HastamaskedTextBox";
            this.HastamaskedTextBox.Size = new System.Drawing.Size(176, 20);
            this.HastamaskedTextBox.TabIndex = 19;
            this.HastamaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // MontomaskedTextBox
            // 
            this.MontomaskedTextBox.Location = new System.Drawing.Point(210, 47);
            this.MontomaskedTextBox.Name = "MontomaskedTextBox";
            this.MontomaskedTextBox.Size = new System.Drawing.Size(176, 20);
            this.MontomaskedTextBox.TabIndex = 20;
            // 
            // CuotasmaskedTextBox
            // 
            this.CuotasmaskedTextBox.Enabled = false;
            this.CuotasmaskedTextBox.Location = new System.Drawing.Point(10, 206);
            this.CuotasmaskedTextBox.Name = "CuotasmaskedTextBox";
            this.CuotasmaskedTextBox.Size = new System.Drawing.Size(176, 20);
            this.CuotasmaskedTextBox.TabIndex = 21;
            // 
            // TotalmaskedTextBox
            // 
            this.TotalmaskedTextBox.Enabled = false;
            this.TotalmaskedTextBox.Location = new System.Drawing.Point(210, 206);
            this.TotalmaskedTextBox.Name = "TotalmaskedTextBox";
            this.TotalmaskedTextBox.Size = new System.Drawing.Size(176, 20);
            this.TotalmaskedTextBox.TabIndex = 22;
            // 
            // NuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 464);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoPrestamo";
            this.Text = "NuevoPrestamo";
            this.Load += new System.EventHandler(this.NuevoPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabladataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiaMoratorianumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesesMoratorianumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesesnumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox GarantecomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TabladataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox DiaMoratoriotextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MontoEstimadotextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown DiaMoratorianumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown MesesMoratorianumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MesesnumericUpDown;
        private System.Windows.Forms.ComboBox FormaPagocomboBox;
        private System.Windows.Forms.TextBox InterestextBox;
        private System.Windows.Forms.TextBox CantidatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Carcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox HastamaskedTextBox;
        private System.Windows.Forms.MaskedTextBox DesdemaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TotalmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CuotasmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox MontomaskedTextBox;
    }
}