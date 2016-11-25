﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ProyectoFinal.Consultas
{
    public partial class ConsultasCliente : Form
    {
        public ConsultasCliente()
        {
            InitializeComponent();
        }
        public List<Cobros> lista = new List<Cobros>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FiltrotextBox.Text))
            {

                lista = BLL.CobrosBLL.GetLista(FiltrotextBox.Text);
            }
            else
            {
                lista = BLL.CobrosBLL.GetLista();
            }

            ConsultaClientedataGridView.DataSource = lista;
        }
        private void FiltrotextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
