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
            this.SuspendLayout();
            // 
            // GarantecomboBox
            // 
            this.GarantecomboBox.FormattingEnabled = true;
            this.GarantecomboBox.Location = new System.Drawing.Point(362, 97);
            this.GarantecomboBox.Name = "GarantecomboBox";
            this.GarantecomboBox.Size = new System.Drawing.Size(121, 21);
            this.GarantecomboBox.TabIndex = 0;
            // 
            // NuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 436);
            this.Controls.Add(this.GarantecomboBox);
            this.Name = "NuevoPrestamo";
            this.Text = "NuevoPrestamo";
            this.Load += new System.EventHandler(this.NuevoPrestamo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox GarantecomboBox;
    }
}