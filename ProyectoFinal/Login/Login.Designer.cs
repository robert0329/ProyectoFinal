namespace ProyectoFinal.Login
{
    partial class Login
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
            this.BCancelar = new System.Windows.Forms.Button();
            this.BEntrar = new System.Windows.Forms.Button();
            this.TextClave = new System.Windows.Forms.TextBox();
            this.TextCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(159, 133);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(113, 46);
            this.BCancelar.TabIndex = 19;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            // 
            // BEntrar
            // 
            this.BEntrar.Location = new System.Drawing.Point(12, 133);
            this.BEntrar.Name = "BEntrar";
            this.BEntrar.Size = new System.Drawing.Size(113, 46);
            this.BEntrar.TabIndex = 18;
            this.BEntrar.Text = "Entrar";
            this.BEntrar.UseVisualStyleBackColor = true;
            this.BEntrar.Click += new System.EventHandler(this.BEntrar_Click);
            // 
            // TextClave
            // 
            this.TextClave.Location = new System.Drawing.Point(12, 83);
            this.TextClave.Name = "TextClave";
            this.TextClave.PasswordChar = '*';
            this.TextClave.Size = new System.Drawing.Size(260, 20);
            this.TextClave.TabIndex = 17;
            // 
            // TextCuenta
            // 
            this.TextCuenta.Location = new System.Drawing.Point(12, 34);
            this.TextCuenta.Name = "TextCuenta";
            this.TextCuenta.Size = new System.Drawing.Size(260, 20);
            this.TextCuenta.TabIndex = 16;
            this.TextCuenta.TextChanged += new System.EventHandler(this.TextCuenta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BEntrar);
            this.Controls.Add(this.TextClave);
            this.Controls.Add(this.TextCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BEntrar;
        private System.Windows.Forms.TextBox TextClave;
        private System.Windows.Forms.TextBox TextCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}