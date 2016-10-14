namespace ProyectoFinal.Consultas
{
    partial class ConsultasGarante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasGarante));
            this.GFiltrotextBox = new System.Windows.Forms.TextBox();
            this.DatosdataGridVieww = new System.Windows.Forms.DataGridView();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridVieww)).BeginInit();
            this.SuspendLayout();
            // 
            // GFiltrotextBox
            // 
            this.GFiltrotextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GFiltrotextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.GFiltrotextBox.Location = new System.Drawing.Point(20, 189);
            this.GFiltrotextBox.Name = "GFiltrotextBox";
            this.GFiltrotextBox.Size = new System.Drawing.Size(591, 20);
            this.GFiltrotextBox.TabIndex = 82;
            // 
            // DatosdataGridVieww
            // 
            this.DatosdataGridVieww.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DatosdataGridVieww.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridVieww.Location = new System.Drawing.Point(20, 4);
            this.DatosdataGridVieww.Name = "DatosdataGridVieww";
            this.DatosdataGridVieww.Size = new System.Drawing.Size(651, 178);
            this.DatosdataGridVieww.TabIndex = 80;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(616, 189);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(55, 52);
            this.Buscarbutton.TabIndex = 81;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ConsultasGarante
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 244);
            this.Controls.Add(this.GFiltrotextBox);
            this.Controls.Add(this.DatosdataGridVieww);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "ConsultasGarante";
            this.Text = "Consultas De Garantes";
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridVieww)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GFiltrotextBox;
        private System.Windows.Forms.DataGridView DatosdataGridVieww;
        private System.Windows.Forms.Button Buscarbutton;
    }
}