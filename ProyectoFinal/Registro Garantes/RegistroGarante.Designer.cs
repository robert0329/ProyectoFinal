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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label cedulaLabel;
            this.GuardarG = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.GnombreTextBox = new System.Windows.Forms.TextBox();
            this.GapellidoTextBox = new System.Windows.Forms.TextBox();
            this.GdireccionTextBox = new System.Windows.Forms.TextBox();
            this.GtelefonoTextBox = new System.Windows.Forms.TextBox();
            this.GcedulaTextBox = new System.Windows.Forms.TextBox();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GuardarG
            // 
            this.GuardarG.Location = new System.Drawing.Point(268, 249);
            this.GuardarG.Name = "GuardarG";
            this.GuardarG.Size = new System.Drawing.Size(75, 37);
            this.GuardarG.TabIndex = 28;
            this.GuardarG.Text = "Guardar";
            this.GuardarG.UseVisualStyleBackColor = true;
            this.GuardarG.Click += new System.EventHandler(this.GuardarG_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.Location = new System.Drawing.Point(21, 249);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(75, 37);
            this.Limpiarbutton.TabIndex = 26;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.UseVisualStyleBackColor = true;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(18, 9);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 16;
            nombreLabel.Text = "Nombre:";
            // 
            // GnombreTextBox
            // 
            this.GnombreTextBox.Location = new System.Drawing.Point(21, 25);
            this.GnombreTextBox.Name = "GnombreTextBox";
            this.GnombreTextBox.Size = new System.Drawing.Size(322, 20);
            this.GnombreTextBox.TabIndex = 17;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(18, 57);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 18;
            apellidoLabel.Text = "Apellido:";
            // 
            // GapellidoTextBox
            // 
            this.GapellidoTextBox.Location = new System.Drawing.Point(21, 73);
            this.GapellidoTextBox.Name = "GapellidoTextBox";
            this.GapellidoTextBox.Size = new System.Drawing.Size(322, 20);
            this.GapellidoTextBox.TabIndex = 19;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(18, 109);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 20;
            direccionLabel.Text = "Direccion:";
            // 
            // GdireccionTextBox
            // 
            this.GdireccionTextBox.Location = new System.Drawing.Point(21, 125);
            this.GdireccionTextBox.Name = "GdireccionTextBox";
            this.GdireccionTextBox.Size = new System.Drawing.Size(322, 20);
            this.GdireccionTextBox.TabIndex = 21;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(18, 157);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 22;
            telefonoLabel.Text = "Telefono:";
            // 
            // GtelefonoTextBox
            // 
            this.GtelefonoTextBox.Location = new System.Drawing.Point(21, 173);
            this.GtelefonoTextBox.Name = "GtelefonoTextBox";
            this.GtelefonoTextBox.Size = new System.Drawing.Size(322, 20);
            this.GtelefonoTextBox.TabIndex = 23;
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(18, 206);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 24;
            cedulaLabel.Text = "Cedula:";
            // 
            // GcedulaTextBox
            // 
            this.GcedulaTextBox.Location = new System.Drawing.Point(21, 222);
            this.GcedulaTextBox.Name = "GcedulaTextBox";
            this.GcedulaTextBox.Size = new System.Drawing.Size(322, 20);
            this.GcedulaTextBox.TabIndex = 25;
            // 
            // RegistroGarante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 289);
            this.Controls.Add(this.GuardarG);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Limpiarbutton);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.GnombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.GapellidoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.GdireccionTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.GtelefonoTextBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.GcedulaTextBox);
            this.Name = "RegistroGarante";
            this.Text = "RegistroGarante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarG;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Limpiarbutton;
        private System.Windows.Forms.TextBox GnombreTextBox;
        private System.Windows.Forms.TextBox GapellidoTextBox;
        private System.Windows.Forms.TextBox GdireccionTextBox;
        private System.Windows.Forms.TextBox GtelefonoTextBox;
        private System.Windows.Forms.TextBox GcedulaTextBox;
    }
}