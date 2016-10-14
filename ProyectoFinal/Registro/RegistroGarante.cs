﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace ProyectoFinal.RegistroGarantes
{
    public partial class RegistroGarante : Form
    {
        public RegistroGarante()
        {
            InitializeComponent();
        }
        private Garantes Llenar()
        {
            Garantes garantes = new Garantes();

            garantes.Nombre = GnombreTextBox.Text;
            garantes.Apellido = GapellidoTextBox.Text;
            garantes.Direccion = GdireccionTextBox.Text;
            garantes.Telefono = GtelefonoTextBox.Text;
            garantes.Cedula = GcedulaTextBox.Text;


            return garantes;
        }
        private void GuardarG_Click(object sender, EventArgs e)
        {
            Garantes garantes = new Garantes();

            garantes = Llenar();

            if (GaranteBLL.Guardar(garantes))
            {
                Limpiarbutton.PerformClick();

                MessageBox.Show("Guardodo con exito");
            }
        }
    }
}