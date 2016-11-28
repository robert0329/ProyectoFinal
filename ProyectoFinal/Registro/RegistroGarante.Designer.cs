using System;

namespace ProyectoFinal.RegistroGarantes
{
    partial class RegistroGarante
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
            System.Windows.Forms.Label garanteIdLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label sexoLabel;
            this.garanteIdTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Guargarbutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.ClienteerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            garanteIdLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // garanteIdLabel
            // 
            garanteIdLabel.AutoSize = true;
            garanteIdLabel.Location = new System.Drawing.Point(12, 28);
            garanteIdLabel.Name = "garanteIdLabel";
            garanteIdLabel.Size = new System.Drawing.Size(60, 13);
            garanteIdLabel.TabIndex = 1;
            garanteIdLabel.Text = "Garante Id:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(12, 54);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 3;
            nombresLabel.Text = "Nombres:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(12, 80);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 5;
            direccionLabel.Text = "Direccion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(12, 106);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 7;
            telefonoLabel.Text = "Telefono:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(12, 132);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 9;
            cedulaLabel.Text = "Cedula:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(12, 158);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 11;
            sexoLabel.Text = "Sexo:";
            // 
            // garanteIdTextBox
            // 
            this.garanteIdTextBox.Location = new System.Drawing.Point(78, 25);
            this.garanteIdTextBox.Name = "garanteIdTextBox";
            this.garanteIdTextBox.Size = new System.Drawing.Size(49, 20);
            this.garanteIdTextBox.TabIndex = 2;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(78, 51);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(256, 20);
            this.nombresTextBox.TabIndex = 4;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(78, 77);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(256, 20);
            this.direccionTextBox.TabIndex = 6;
            // 
            // telefonoMaskedTextBox
            // 
            this.telefonoMaskedTextBox.Location = new System.Drawing.Point(78, 103);
            this.telefonoMaskedTextBox.Name = "telefonoMaskedTextBox";
            this.telefonoMaskedTextBox.Size = new System.Drawing.Size(256, 20);
            this.telefonoMaskedTextBox.TabIndex = 8;
            // 
            // cedulaMaskedTextBox
            // 
            this.cedulaMaskedTextBox.Location = new System.Drawing.Point(78, 129);
            this.cedulaMaskedTextBox.Name = "cedulaMaskedTextBox";
            this.cedulaMaskedTextBox.Size = new System.Drawing.Size(256, 20);
            this.cedulaMaskedTextBox.TabIndex = 10;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Location = new System.Drawing.Point(78, 155);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(256, 21);
            this.sexoComboBox.TabIndex = 12;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(259, 16);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 29);
            this.Buscarbutton.TabIndex = 16;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Guargarbutton
            // 
            this.Guargarbutton.Location = new System.Drawing.Point(15, 182);
            this.Guargarbutton.Name = "Guargarbutton";
            this.Guargarbutton.Size = new System.Drawing.Size(75, 29);
            this.Guargarbutton.TabIndex = 17;
            this.Guargarbutton.Text = "Guardar";
            this.Guargarbutton.UseVisualStyleBackColor = true;
            this.Guargarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(96, 182);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(75, 29);
            this.Modificarbutton.TabIndex = 18;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(177, 182);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 29);
            this.Eliminarbutton.TabIndex = 19;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(259, 182);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 29);
            this.Nuevobutton.TabIndex = 20;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // ClienteerrorProvider
            // 
            this.ClienteerrorProvider.ContainerControl = this;
            // 
            // RegistroGarante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(346, 224);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Guargarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(garanteIdLabel);
            this.Controls.Add(this.garanteIdTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoMaskedTextBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaMaskedTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoComboBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "RegistroGarante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Garante";
            this.Load += new System.EventHandler(this.RegistroGarante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.TextBox garanteIdTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.MaskedTextBox telefonoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cedulaMaskedTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Guargarbutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.ErrorProvider ClienteerrorProvider;
    }
}