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
            this.GFiltrotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GFiltrotextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.GFiltrotextBox.Location = new System.Drawing.Point(18, 22);
            this.GFiltrotextBox.Name = "GFiltrotextBox";
            this.GFiltrotextBox.Size = new System.Drawing.Size(108, 20);
            this.GFiltrotextBox.TabIndex = 79;
            // 
            // DatosdataGridVieww
            // 
            this.DatosdataGridVieww.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosdataGridVieww.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridVieww.Location = new System.Drawing.Point(18, 89);
            this.DatosdataGridVieww.Name = "DatosdataGridVieww";
            this.DatosdataGridVieww.Size = new System.Drawing.Size(655, 276);
            this.DatosdataGridVieww.TabIndex = 77;
            this.DatosdataGridVieww.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosdataGridVieww_CellContentClick);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(151, 22);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(55, 52);
            this.Buscarbutton.TabIndex = 78;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // ConsultasGarante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 385);
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