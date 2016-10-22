namespace ProyectoFinal.RegistroCliente
{
    partial class RegistroCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.TelefonotextBox = new System.Windows.Forms.TextBox();
            this.CedulatextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.Sexo = new System.Windows.Forms.Label();
            this.SexocomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cedula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono/Cel";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(25, 25);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(325, 20);
            this.NombretextBox.TabIndex = 6;
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.Location = new System.Drawing.Point(25, 114);
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.Size = new System.Drawing.Size(325, 20);
            this.TelefonotextBox.TabIndex = 8;
            // 
            // CedulatextBox
            // 
            this.CedulatextBox.Location = new System.Drawing.Point(25, 163);
            this.CedulatextBox.Name = "CedulatextBox";
            this.CedulatextBox.Size = new System.Drawing.Size(325, 20);
            this.CedulatextBox.TabIndex = 9;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(25, 64);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(325, 20);
            this.DirecciontextBox.TabIndex = 10;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(275, 247);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 36);
            this.Guardarbutton.TabIndex = 2;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(25, 247);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 36);
            this.Nuevobutton.TabIndex = 11;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(152, 247);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 36);
            this.CancelarButton.TabIndex = 12;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Location = new System.Drawing.Point(22, 196);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(31, 13);
            this.Sexo.TabIndex = 13;
            this.Sexo.Text = "Sexo";
            // 
            // SexocomboBox
            // 
            this.SexocomboBox.FormattingEnabled = true;
            this.SexocomboBox.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otro"});
            this.SexocomboBox.Location = new System.Drawing.Point(25, 212);
            this.SexocomboBox.Name = "SexocomboBox";
            this.SexocomboBox.Size = new System.Drawing.Size(325, 21);
            this.SexocomboBox.TabIndex = 14;
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 283);
            this.Controls.Add(this.SexocomboBox);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.CedulatextBox);
            this.Controls.Add(this.TelefonotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Cliente";
            this.Load += new System.EventHandler(this.RegistroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox TelefonotextBox;
        private System.Windows.Forms.TextBox CedulatextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.ComboBox SexocomboBox;
    }
}