namespace ProyectoFinal.Prestamos
{
    partial class Desembolso
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombrecomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClienteIdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CobrodataGridView = new System.Windows.Forms.DataGridView();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrestamoIdtextBox = new System.Windows.Forms.TextBox();
            this.CuotastextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.AbonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobrodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // NombrecomboBox
            // 
            this.NombrecomboBox.FormattingEnabled = true;
            this.NombrecomboBox.Location = new System.Drawing.Point(55, 25);
            this.NombrecomboBox.Name = "NombrecomboBox";
            this.NombrecomboBox.Size = new System.Drawing.Size(173, 21);
            this.NombrecomboBox.TabIndex = 5;
            this.NombrecomboBox.SelectedIndexChanged += new System.EventHandler(this.NombrecomboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MontotextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ValortextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AbonomaskedTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.FechadateTimePicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CuotastextBox);
            this.groupBox1.Controls.Add(this.PrestamoIdtextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.ClienteIdtextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CobrodataGridView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NombrecomboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 259);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cobros";
            // 
            // ClienteIdtextBox
            // 
            this.ClienteIdtextBox.Enabled = false;
            this.ClienteIdtextBox.Location = new System.Drawing.Point(291, 25);
            this.ClienteIdtextBox.Name = "ClienteIdtextBox";
            this.ClienteIdtextBox.Size = new System.Drawing.Size(28, 20);
            this.ClienteIdtextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ClienteID:";
            // 
            // CobrodataGridView
            // 
            this.CobrodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CobrodataGridView.Location = new System.Drawing.Point(9, 87);
            this.CobrodataGridView.Name = "CobrodataGridView";
            this.CobrodataGridView.Size = new System.Drawing.Size(643, 150);
            this.CobrodataGridView.TabIndex = 6;
            this.CobrodataGridView.SelectionChanged += new System.EventHandler(this.NombrecomboBox_SelectedIndexChanged);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(577, 52);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 30);
            this.Agregarbutton.TabIndex = 9;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "PrestamoId:";
            // 
            // PrestamoIdtextBox
            // 
            this.PrestamoIdtextBox.Enabled = false;
            this.PrestamoIdtextBox.Location = new System.Drawing.Point(389, 27);
            this.PrestamoIdtextBox.Name = "PrestamoIdtextBox";
            this.PrestamoIdtextBox.Size = new System.Drawing.Size(27, 20);
            this.PrestamoIdtextBox.TabIndex = 12;
            // 
            // CuotastextBox
            // 
            this.CuotastextBox.Enabled = false;
            this.CuotastextBox.Location = new System.Drawing.Point(522, 26);
            this.CuotastextBox.Name = "CuotastextBox";
            this.CuotastextBox.Size = new System.Drawing.Size(29, 20);
            this.CuotastextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cuotas Restantes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha:";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(53, 59);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(175, 20);
            this.FechadateTimePicker.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Abono:";
            // 
            // AbonomaskedTextBox
            // 
            this.AbonomaskedTextBox.Location = new System.Drawing.Point(443, 60);
            this.AbonomaskedTextBox.Name = "AbonomaskedTextBox";
            this.AbonomaskedTextBox.Size = new System.Drawing.Size(73, 20);
            this.AbonomaskedTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Valor por Cuotas:";
            // 
            // ValortextBox
            // 
            this.ValortextBox.Enabled = false;
            this.ValortextBox.Location = new System.Drawing.Point(323, 62);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(67, 20);
            this.ValortextBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(558, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Monto:";
            // 
            // MontotextBox
            // 
            this.MontotextBox.Enabled = false;
            this.MontotextBox.Location = new System.Drawing.Point(602, 25);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(50, 20);
            this.MontotextBox.TabIndex = 22;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(583, 277);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(87, 32);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Desembolso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 338);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Desembolso";
            this.Text = "Desembolso";
            this.Load += new System.EventHandler(this.Desembolso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CobrodataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NombrecomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView CobrodataGridView;
        private System.Windows.Forms.TextBox ClienteIdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox AbonomaskedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CuotastextBox;
        private System.Windows.Forms.TextBox PrestamoIdtextBox;
        private System.Windows.Forms.TextBox ValortextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Guardarbutton;
    }
}