namespace ProyectoFinal
{
    partial class FormularioPrincipal
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
            this.prestariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPrestarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoPrestamoGaranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPrestarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoGaranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaGaranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDesembolsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDesembolsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDevolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prestariosToolStripMenuItem
            // 
            this.prestariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPrestarioToolStripMenuItem,
            this.consultaPrestarioToolStripMenuItem,
            this.nuevoGaranteToolStripMenuItem,
            this.consultaGaranteToolStripMenuItem});
            this.prestariosToolStripMenuItem.Name = "prestariosToolStripMenuItem";
            this.prestariosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.prestariosToolStripMenuItem.Text = "&Prestarios";
            // 
            // nuevoPrestarioToolStripMenuItem
            // 
            this.nuevoPrestarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoPrestamoGaranteToolStripMenuItem});
            this.nuevoPrestarioToolStripMenuItem.Name = "nuevoPrestarioToolStripMenuItem";
            this.nuevoPrestarioToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nuevoPrestarioToolStripMenuItem.Text = "&Nuevo Prestario";
            this.nuevoPrestarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoPrestarioToolStripMenuItem_Click);
            // 
            // NuevoPrestamoGaranteToolStripMenuItem
            // 
            this.NuevoPrestamoGaranteToolStripMenuItem.Name = "NuevoPrestamoGaranteToolStripMenuItem";
            this.NuevoPrestamoGaranteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.NuevoPrestamoGaranteToolStripMenuItem.Text = "Nuevo Prestamo";
            this.NuevoPrestamoGaranteToolStripMenuItem.Click += new System.EventHandler(this.NuevoPrestamoGaranteToolStripMenuItem_Click);
            // 
            // consultaPrestarioToolStripMenuItem
            // 
            this.consultaPrestarioToolStripMenuItem.Name = "consultaPrestarioToolStripMenuItem";
            this.consultaPrestarioToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultaPrestarioToolStripMenuItem.Text = "&Consulta Prestario";
            this.consultaPrestarioToolStripMenuItem.Click += new System.EventHandler(this.consultaPrestarioToolStripMenuItem_Click);
            // 
            // nuevoGaranteToolStripMenuItem
            // 
            this.nuevoGaranteToolStripMenuItem.Name = "nuevoGaranteToolStripMenuItem";
            this.nuevoGaranteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nuevoGaranteToolStripMenuItem.Text = "Nuevo Garante";
            this.nuevoGaranteToolStripMenuItem.Click += new System.EventHandler(this.nuevoGaranteToolStripMenuItem_Click);
            // 
            // consultaGaranteToolStripMenuItem
            // 
            this.consultaGaranteToolStripMenuItem.Name = "consultaGaranteToolStripMenuItem";
            this.consultaGaranteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultaGaranteToolStripMenuItem.Text = "Consulta Garante";
            this.consultaGaranteToolStripMenuItem.Click += new System.EventHandler(this.consultaGaranteToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDesembolsoToolStripMenuItem,
            this.modificacionDesembolsoToolStripMenuItem,
            this.devolucionToolStripMenuItem,
            this.modificacionDevolucionToolStripMenuItem});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // nuevoDesembolsoToolStripMenuItem
            // 
            this.nuevoDesembolsoToolStripMenuItem.Name = "nuevoDesembolsoToolStripMenuItem";
            this.nuevoDesembolsoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.nuevoDesembolsoToolStripMenuItem.Text = "Nuevo Desembolso";
            this.nuevoDesembolsoToolStripMenuItem.Click += new System.EventHandler(this.nuevoDesembolsoToolStripMenuItem_Click);
            // 
            // modificacionDesembolsoToolStripMenuItem
            // 
            this.modificacionDesembolsoToolStripMenuItem.Name = "modificacionDesembolsoToolStripMenuItem";
            this.modificacionDesembolsoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.modificacionDesembolsoToolStripMenuItem.Text = "Modificacion Desembolso";
            // 
            // devolucionToolStripMenuItem
            // 
            this.devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            this.devolucionToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.devolucionToolStripMenuItem.Text = "Devolucion";
            // 
            // modificacionDevolucionToolStripMenuItem
            // 
            this.modificacionDevolucionToolStripMenuItem.Name = "modificacionDevolucionToolStripMenuItem";
            this.modificacionDevolucionToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.modificacionDevolucionToolStripMenuItem.Text = "Modificacion Devolucion";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestariosToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(802, 70);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 307);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos Mariant";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem prestariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPrestarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDesembolsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDesembolsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDevolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem consultaPrestarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoGaranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaGaranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevoPrestamoGaranteToolStripMenuItem;
    }
}

