﻿namespace ProyectoFinal
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
            this.nuevoGaranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDesembolsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPrestarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaGaranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prestariosToolStripMenuItem
            // 
            this.prestariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPrestarioToolStripMenuItem,
            this.nuevoGaranteToolStripMenuItem});
            this.prestariosToolStripMenuItem.Name = "prestariosToolStripMenuItem";
            this.prestariosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.prestariosToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoPrestarioToolStripMenuItem
            // 
            this.nuevoPrestarioToolStripMenuItem.Name = "nuevoPrestarioToolStripMenuItem";
            this.nuevoPrestarioToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nuevoPrestarioToolStripMenuItem.Text = "&Nuevo Prestario";
            this.nuevoPrestarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoPrestarioToolStripMenuItem_Click);
            // 
            // nuevoGaranteToolStripMenuItem
            // 
            this.nuevoGaranteToolStripMenuItem.Name = "nuevoGaranteToolStripMenuItem";
            this.nuevoGaranteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nuevoGaranteToolStripMenuItem.Text = "Nuevo Garante";
            this.nuevoGaranteToolStripMenuItem.Click += new System.EventHandler(this.nuevoGaranteToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPrestamoToolStripMenuItem,
            this.nuevoDesembolsoToolStripMenuItem});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // nuevoPrestamoToolStripMenuItem
            // 
            this.nuevoPrestamoToolStripMenuItem.Name = "nuevoPrestamoToolStripMenuItem";
            this.nuevoPrestamoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nuevoPrestamoToolStripMenuItem.Text = "Nuevo Prestamo";
            this.nuevoPrestamoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPrestamoToolStripMenuItem_Click);
            // 
            // nuevoDesembolsoToolStripMenuItem
            // 
            this.nuevoDesembolsoToolStripMenuItem.Name = "nuevoDesembolsoToolStripMenuItem";
            this.nuevoDesembolsoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nuevoDesembolsoToolStripMenuItem.Text = "Nuevo Desembolso";
            this.nuevoDesembolsoToolStripMenuItem.Click += new System.EventHandler(this.nuevoDesembolsoToolStripMenuItem_Click);
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
            this.reportesToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaPrestarioToolStripMenuItem,
            this.consultaGaranteToolStripMenuItem,
            this.consultaPrestamosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaPrestarioToolStripMenuItem
            // 
            this.consultaPrestarioToolStripMenuItem.Name = "consultaPrestarioToolStripMenuItem";
            this.consultaPrestarioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.consultaPrestarioToolStripMenuItem.Text = "Consulta Prestario";
            this.consultaPrestarioToolStripMenuItem.Click += new System.EventHandler(this.consultaPrestarioToolStripMenuItem_Click_1);
            // 
            // consultaGaranteToolStripMenuItem
            // 
            this.consultaGaranteToolStripMenuItem.Name = "consultaGaranteToolStripMenuItem";
            this.consultaGaranteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.consultaGaranteToolStripMenuItem.Text = "Consulta Garante";
            this.consultaGaranteToolStripMenuItem.Click += new System.EventHandler(this.consultaGaranteToolStripMenuItem_Click_1);
            // 
            // consultaPrestamosToolStripMenuItem
            // 
            this.consultaPrestamosToolStripMenuItem.Name = "consultaPrestamosToolStripMenuItem";
            this.consultaPrestamosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.consultaPrestamosToolStripMenuItem.Text = "Consulta Prestamos";
            this.consultaPrestamosToolStripMenuItem.Click += new System.EventHandler(this.consultaPrestamosToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 307);
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
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoGaranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPrestarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaGaranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPrestamosToolStripMenuItem;
    }
}

