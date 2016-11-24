﻿using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Prestamos
{
    public partial class Desembolso : Form
    {
        public Desembolso()
        {
            InitializeComponent();
        }
        Conexion bd = new Conexion();
        void cargar()
        {
            var conn = new Conexion();
            var lista = conn.Prestamos.ToList();
            NombrecomboBox.DataSource = lista;
            NombrecomboBox.DisplayMember = "Nombres";

        }
        
        private void Cobrarbutton_Click(object sender, EventArgs e)
        {
            int r = 0;
            var cc = BLL.CobrosBLL.Buscar(NombrecomboBox.Text);
            if (cc != null)
            {
                r = (cc.MontoPrestado - Utilidades.ToInt(MontotextBox.Text));
                BLL.CobrosBLL.Modificar(r, NombrecomboBox.Text);
                Agregarbutton.PerformClick();
            }
        }

        private void Desembolso_Load(object sender, EventArgs e)
        { 
            cargar();
        }
        private void NombrecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            var d = new Conexion();
            var cc = BLL.CobrosBLL.Buscar(NombrecomboBox.Text);

            if (cc != null)
            {
                DeudatextBox.Text = Convert.ToString(cc.MontoPrestado);
            }
        }
    }
}
