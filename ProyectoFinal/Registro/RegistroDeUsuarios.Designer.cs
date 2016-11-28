namespace ProyectoFinal.RegistroUsuarios
{
    partial class RegistroDeUsuarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RegistrarB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelarB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textConfirmar = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.UsuarioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RegistrarB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CancelarB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textConfirmar);
            this.groupBox1.Controls.Add(this.textUsuario);
            this.groupBox1.Controls.Add(this.textContraseña);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 250);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Usuarios";
            // 
            // RegistrarB
            // 
            this.RegistrarB.Location = new System.Drawing.Point(12, 175);
            this.RegistrarB.Name = "RegistrarB";
            this.RegistrarB.Size = new System.Drawing.Size(102, 47);
            this.RegistrarB.TabIndex = 38;
            this.RegistrarB.Text = "Registrar";
            this.RegistrarB.UseVisualStyleBackColor = true;
            this.RegistrarB.Click += new System.EventHandler(this.RegistrarB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Contraseña";
            // 
            // CancelarB
            // 
            this.CancelarB.Location = new System.Drawing.Point(223, 175);
            this.CancelarB.Name = "CancelarB";
            this.CancelarB.Size = new System.Drawing.Size(102, 47);
            this.CancelarB.TabIndex = 37;
            this.CancelarB.Text = "Cancelar";
            this.CancelarB.UseVisualStyleBackColor = true;
            this.CancelarB.Click += new System.EventHandler(this.CancelarB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // textConfirmar
            // 
            this.textConfirmar.Location = new System.Drawing.Point(12, 137);
            this.textConfirmar.Name = "textConfirmar";
            this.textConfirmar.PasswordChar = '*';
            this.textConfirmar.Size = new System.Drawing.Size(313, 20);
            this.textConfirmar.TabIndex = 36;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(12, 41);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(313, 20);
            this.textUsuario.TabIndex = 34;
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(12, 89);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.PasswordChar = '*';
            this.textContraseña.Size = new System.Drawing.Size(313, 20);
            this.textContraseña.TabIndex = 35;
            // 
            // UsuarioerrorProvider
            // 
            this.UsuarioerrorProvider.ContainerControl = this;
            // 
            // RegistroDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 257);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroDeUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroDeUsuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioerrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegistrarB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelarB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textConfirmar;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.ErrorProvider UsuarioerrorProvider;
    }
}