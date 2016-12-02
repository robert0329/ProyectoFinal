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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPrestamo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombrecomboBox = new System.Windows.Forms.ComboBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoClientetextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GaranteActualcomboBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
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
            this.GarantecomboBox = new System.Windows.Forms.ComboBox();
            this.Garante = new System.Windows.Forms.Label();
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
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.ClienteerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.garantedataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NuevocheckBox = new System.Windows.Forms.CheckBox();
            this.Deletedbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.GarantegroupBox = new System.Windows.Forms.GroupBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.SexocomboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CedulamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.PrestamosIdtextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesesnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteresnumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garantedataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.GarantegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // NombrecomboBox
            // 
            this.NombrecomboBox.FormattingEnabled = true;
            this.NombrecomboBox.Location = new System.Drawing.Point(590, 63);
            this.NombrecomboBox.Name = "NombrecomboBox";
            this.NombrecomboBox.Size = new System.Drawing.Size(246, 21);
            this.NombrecomboBox.TabIndex = 5;
            this.NombrecomboBox.SelectedIndexChanged += new System.EventHandler(this.NombrecomboBox_SelectedIndexChanged);
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Enabled = false;
            this.ApellidoTextBox.Location = new System.Drawing.Point(280, 63);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(233, 20);
            this.ApellidoTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Cliente";
            // 
            // CodigoClientetextBox
            // 
            this.CodigoClientetextBox.Enabled = false;
            this.CodigoClientetextBox.Location = new System.Drawing.Point(111, 63);
            this.CodigoClientetextBox.Name = "CodigoClientetextBox";
            this.CodigoClientetextBox.Size = new System.Drawing.Size(100, 20);
            this.CodigoClientetextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.GaranteActualcomboBox);
            this.groupBox2.Controls.Add(this.label20);
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
            // GaranteActualcomboBox
            // 
            this.GaranteActualcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GaranteActualcomboBox.FormattingEnabled = true;
            this.GaranteActualcomboBox.Location = new System.Drawing.Point(524, 68);
            this.GaranteActualcomboBox.Name = "GaranteActualcomboBox";
            this.GaranteActualcomboBox.Size = new System.Drawing.Size(183, 21);
            this.GaranteActualcomboBox.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(472, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Garante";
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Enabled = false;
            this.Calcularbutton.Image = ((System.Drawing.Image)(resources.GetObject("Calcularbutton.Image")));
            this.Calcularbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Calcularbutton.Location = new System.Drawing.Point(745, 32);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(84, 49);
            this.Calcularbutton.TabIndex = 12;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Enabled = false;
            this.FechadateTimePicker.Location = new System.Drawing.Point(524, 21);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(183, 20);
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
            // GarantecomboBox
            // 
            this.GarantecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GarantecomboBox.Enabled = false;
            this.GarantecomboBox.FormattingEnabled = true;
            this.GarantecomboBox.Location = new System.Drawing.Point(60, 21);
            this.GarantecomboBox.Name = "GarantecomboBox";
            this.GarantecomboBox.Size = new System.Drawing.Size(183, 21);
            this.GarantecomboBox.TabIndex = 14;
            // 
            // Garante
            // 
            this.Garante.AutoSize = true;
            this.Garante.Location = new System.Drawing.Point(8, 20);
            this.Garante.Name = "Garante";
            this.Garante.Size = new System.Drawing.Size(45, 13);
            this.Garante.TabIndex = 13;
            this.Garante.Text = "Garante";
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
            this.NumeroCuotastextBox.Location = new System.Drawing.Point(681, 25);
            this.NumeroCuotastextBox.Name = "NumeroCuotastextBox";
            this.NumeroCuotastextBox.Size = new System.Drawing.Size(113, 20);
            this.NumeroCuotastextBox.TabIndex = 7;
            // 
            // ValorPorCuotastextBox
            // 
            this.ValorPorCuotastextBox.Enabled = false;
            this.ValorPorCuotastextBox.Location = new System.Drawing.Point(337, 65);
            this.ValorPorCuotastextBox.Name = "ValorPorCuotastextBox";
            this.ValorPorCuotastextBox.Size = new System.Drawing.Size(137, 20);
            this.ValorPorCuotastextBox.TabIndex = 11;
            // 
            // Prestamos2textBox
            // 
            this.Prestamos2textBox.Enabled = false;
            this.Prestamos2textBox.Location = new System.Drawing.Point(468, 25);
            this.Prestamos2textBox.Name = "Prestamos2textBox";
            this.Prestamos2textBox.Size = new System.Drawing.Size(113, 20);
            this.Prestamos2textBox.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(300, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Valor";
            // 
            // InteresFinaltextBox
            // 
            this.InteresFinaltextBox.Enabled = false;
            this.InteresFinaltextBox.Location = new System.Drawing.Point(292, 25);
            this.InteresFinaltextBox.Name = "InteresFinaltextBox";
            this.InteresFinaltextBox.Size = new System.Drawing.Size(113, 20);
            this.InteresFinaltextBox.TabIndex = 5;
            // 
            // MontoFinaltextBox
            // 
            this.MontoFinaltextBox.Enabled = false;
            this.MontoFinaltextBox.Location = new System.Drawing.Point(91, 22);
            this.MontoFinaltextBox.Name = "MontoFinaltextBox";
            this.MontoFinaltextBox.Size = new System.Drawing.Size(113, 20);
            this.MontoFinaltextBox.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(595, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Numero Cuotas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(411, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Prestamo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Interes Final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Monto Final";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(757, 320);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(90, 42);
            this.Guardarbutton.TabIndex = 5;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(757, 368);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(94, 42);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscar
            // 
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar.Location = new System.Drawing.Point(203, 6);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(85, 29);
            this.Buscar.TabIndex = 7;
            this.Buscar.Text = "Buscar";
            this.Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // ClienteerrorProvider
            // 
            this.ClienteerrorProvider.ContainerControl = this;
            // 
            // garantedataGridView
            // 
            this.garantedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.garantedataGridView.Location = new System.Drawing.Point(6, 48);
            this.garantedataGridView.Name = "garantedataGridView";
            this.garantedataGridView.Size = new System.Drawing.Size(720, 132);
            this.garantedataGridView.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NuevocheckBox);
            this.groupBox4.Controls.Add(this.GarantecomboBox);
            this.groupBox4.Controls.Add(this.Garante);
            this.groupBox4.Controls.Add(this.garantedataGridView);
            this.groupBox4.Location = new System.Drawing.Point(13, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(732, 186);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Garantes";
            // 
            // NuevocheckBox
            // 
            this.NuevocheckBox.AutoSize = true;
            this.NuevocheckBox.Location = new System.Drawing.Point(272, 20);
            this.NuevocheckBox.Name = "NuevocheckBox";
            this.NuevocheckBox.Size = new System.Drawing.Size(58, 17);
            this.NuevocheckBox.TabIndex = 15;
            this.NuevocheckBox.Text = "Nuevo";
            this.NuevocheckBox.UseVisualStyleBackColor = true;
            this.NuevocheckBox.CheckedChanged += new System.EventHandler(this.NuevocheckBox_CheckedChanged);
            // 
            // Deletedbutton
            // 
            this.Deletedbutton.Location = new System.Drawing.Point(75, 136);
            this.Deletedbutton.Name = "Deletedbutton";
            this.Deletedbutton.Size = new System.Drawing.Size(75, 26);
            this.Deletedbutton.TabIndex = 6;
            this.Deletedbutton.Text = "Eliminar";
            this.Deletedbutton.UseVisualStyleBackColor = true;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(75, 107);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 26);
            this.Addbutton.TabIndex = 5;
            this.Addbutton.Text = "Agregar";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // GarantegroupBox
            // 
            this.GarantegroupBox.Controls.Add(this.Savebutton);
            this.GarantegroupBox.Controls.Add(this.SexocomboBox);
            this.GarantegroupBox.Controls.Add(this.label19);
            this.GarantegroupBox.Controls.Add(this.Deletedbutton);
            this.GarantegroupBox.Controls.Add(this.CedulamaskedTextBox);
            this.GarantegroupBox.Controls.Add(this.Addbutton);
            this.GarantegroupBox.Controls.Add(this.TelefonomaskedTextBox);
            this.GarantegroupBox.Controls.Add(this.DirecciontextBox);
            this.GarantegroupBox.Controls.Add(this.NombrestextBox);
            this.GarantegroupBox.Controls.Add(this.label18);
            this.GarantegroupBox.Controls.Add(this.label17);
            this.GarantegroupBox.Controls.Add(this.label16);
            this.GarantegroupBox.Controls.Add(this.label14);
            this.GarantegroupBox.Location = new System.Drawing.Point(461, 323);
            this.GarantegroupBox.Name = "GarantegroupBox";
            this.GarantegroupBox.Size = new System.Drawing.Size(290, 161);
            this.GarantegroupBox.TabIndex = 9;
            this.GarantegroupBox.TabStop = false;
            this.GarantegroupBox.Text = "Nuevo Garante";
            this.GarantegroupBox.Visible = false;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(206, 118);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 10;
            this.Savebutton.Text = "Guardar";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // SexocomboBox
            // 
            this.SexocomboBox.FormattingEnabled = true;
            this.SexocomboBox.Location = new System.Drawing.Point(61, 125);
            this.SexocomboBox.Name = "SexocomboBox";
            this.SexocomboBox.Size = new System.Drawing.Size(139, 21);
            this.SexocomboBox.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Sexo";
            // 
            // CedulamaskedTextBox
            // 
            this.CedulamaskedTextBox.Location = new System.Drawing.Point(60, 97);
            this.CedulamaskedTextBox.Name = "CedulamaskedTextBox";
            this.CedulamaskedTextBox.Size = new System.Drawing.Size(140, 20);
            this.CedulamaskedTextBox.TabIndex = 7;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(61, 71);
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(139, 20);
            this.TelefonomaskedTextBox.TabIndex = 6;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(61, 45);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(139, 20);
            this.DirecciontextBox.TabIndex = 5;
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(61, 17);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(139, 20);
            this.NombrestextBox.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Cedula";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Telefono";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Direccion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nombres";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "Prestamos Id;";
            // 
            // PrestamosIdtextBox
            // 
            this.PrestamosIdtextBox.Location = new System.Drawing.Point(90, 6);
            this.PrestamosIdtextBox.Name = "PrestamosIdtextBox";
            this.PrestamosIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.PrestamosIdtextBox.TabIndex = 11;
            // 
            // NuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 518);
            this.Controls.Add(this.PrestamosIdtextBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.NombrecomboBox);
            this.Controls.Add(this.GarantegroupBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.CodigoClientetextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "NuevoPrestamo";
            this.Text = "Nuevo Prestamo";
            this.Load += new System.EventHandler(this.NuevoPrestamo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesesnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteresnumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garantedataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.GarantegroupBox.ResumeLayout(false);
            this.GarantegroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.ComboBox GarantecomboBox;
        private System.Windows.Forms.Label Garante;
        private System.Windows.Forms.ErrorProvider ClienteerrorProvider;
        private System.Windows.Forms.DataGridView garantedataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Deletedbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.GroupBox GarantegroupBox;
        private System.Windows.Forms.ComboBox SexocomboBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox CedulamaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.CheckBox NuevocheckBox;
        private System.Windows.Forms.ComboBox GaranteActualcomboBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox PrestamosIdtextBox;
        private System.Windows.Forms.Label label21;
    }
}