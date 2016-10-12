namespace ProyectoFinal.Consultas
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
            this.CamposComboBox = new System.Windows.Forms.ComboBox();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).BeginInit();
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
            this.Buscarbutton.Location = new System.Drawing.Point(607, 5);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(55, 52);
            this.Buscarbutton.TabIndex = 69;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // CamposComboBox
            // 
            this.CamposComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamposComboBox.FormattingEnabled = true;
            this.CamposComboBox.Items.AddRange(new object[] {
            "UsuarioId",
            "Nombre"});
            this.CamposComboBox.Location = new System.Drawing.Point(63, 7);
            this.CamposComboBox.Name = "CamposComboBox";
            this.CamposComboBox.Size = new System.Drawing.Size(121, 21);
            this.CamposComboBox.TabIndex = 76;
            this.CamposComboBox.SelectedIndexChanged += new System.EventHandler(this.CamposComboBox_SelectedIndexChanged);
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrotextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FiltrotextBox.Location = new System.Drawing.Point(190, 7);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(402, 20);
            this.FiltrotextBox.TabIndex = 70;
            this.FiltrotextBox.TextChanged += new System.EventHandler(this.FiltrotextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 71;
            this.label5.Text = "Filtrar ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Location = new System.Drawing.Point(7, 74);
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.Size = new System.Drawing.Size(655, 276);
            this.DatosdataGridView.TabIndex = 68;
            this.DatosdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosdataGridView_CellContentClick);
            // 
            // ConsultasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 354);
            this.Controls.Add(this.CamposComboBox);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DatosdataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "ConsultasCliente";
            this.Text = "ConsultasCliente";
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ComboBox CamposComboBox;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DatosdataGridView;
    }
}