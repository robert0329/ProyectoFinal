namespace ProyectoFinal.Login
{
    partial class Seleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seleccion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.Entrarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.Location = new System.Drawing.Point(33, 188);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(75, 46);
            this.RegistrarButton.TabIndex = 21;
            this.RegistrarButton.Text = "Registrar Usuario";
            this.RegistrarButton.UseVisualStyleBackColor = true;
            this.RegistrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // Entrarbutton
            // 
            this.Entrarbutton.Location = new System.Drawing.Point(168, 188);
            this.Entrarbutton.Name = "Entrarbutton";
            this.Entrarbutton.Size = new System.Drawing.Size(75, 46);
            this.Entrarbutton.TabIndex = 22;
            this.Entrarbutton.Text = "Entrar";
            this.Entrarbutton.UseVisualStyleBackColor = true;
            this.Entrarbutton.Click += new System.EventHandler(this.Entrarbutton_Click);
            // 
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(279, 261);
            this.Controls.Add(this.Entrarbutton);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Seleccion";
            this.Text = "Seleccion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RegistrarButton;
        private System.Windows.Forms.Button Entrarbutton;
    }
}