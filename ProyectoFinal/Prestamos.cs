﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entidades;
using BLL;

namespace ProyectoFinal
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = 0;
           // usuario.Nombre = textNombre.Text;
            //usuario.Contraseña = textContraseña.Text;

            if (UsuariosBLL.Insertar(usuario))
            {
                MessageBox.Show("Guardo Bien");
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
