﻿namespace ProyectoFinal.Consultas
{
    partial class ConsultasCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasCliente));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.ConsultaClientedataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaClientedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-182, -8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 67;
            this.label3.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-182, -42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Filtrar ";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(577, 51);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(63, 39);
            this.Buscarbutton.TabIndex = 69;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrotextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FiltrotextBox.Location = new System.Drawing.Point(598, 15);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(42, 20);
            this.FiltrotextBox.TabIndex = 70;
            this.FiltrotextBox.TextChanged += new System.EventHandler(this.FiltrotextBox_TextChanged);
            // 
            // ConsultaClientedataGridView
            // 
            this.ConsultaClientedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaClientedataGridView.Location = new System.Drawing.Point(-1, 0);
            this.ConsultaClientedataGridView.Name = "ConsultaClientedataGridView";
            this.ConsultaClientedataGridView.Size = new System.Drawing.Size(569, 150);
            this.ConsultaClientedataGridView.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "ID";
            // 
            // ConsultasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 151);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConsultaClientedataGridView);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "ConsultasCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas De Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaClientedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.DataGridView ConsultaClientedataGridView;
        private System.Windows.Forms.Label label2;
    }
}