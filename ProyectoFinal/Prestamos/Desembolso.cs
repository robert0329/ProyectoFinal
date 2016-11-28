﻿using BLL;
using DAL;
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
        Conexion bd = new Conexion();
        List<Entidades.Cobros> Lista = new List<Entidades.Cobros>();
        List<Entidades.Prestamos> List = new List<Entidades.Prestamos>();
        public Desembolso()
        {
            InitializeComponent();
        }
        void cargar()
        {
            var conn = new Conexion();
            var lista = conn.Prestamos.ToList();
            NombrecomboBox.DataSource = lista;
            NombrecomboBox.DisplayMember = "Nombre";
        }
        private void Desembolso_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void NombrecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var d = new Conexion();
            var cc = BLL.PrestamosBLL.Buscar(NombrecomboBox.Text);
            if (cc != null)
            {

                Retornar();

            }
        }
        public void Retornar()
        {
            var cc = BLL.PrestamosBLL.Buscar(NombrecomboBox.Text);
            ClienteIdtextBox.Text = Convert.ToString(cc.ClienteId);
            PrestamoIdtextBox.Text = Convert.ToString(cc.PrestamoID);
            CuotastextBox.Text = Convert.ToString(cc.NumeroCuotas);
            FechadateTimePicker.Value = Convert.ToDateTime(cc.Fecha);
            ValortextBox.Text = Convert.ToString(cc.valorCuotas);
            MontotextBox.Text = Convert.ToString(cc.Prestamo);
        }
        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            int r = 0;
            var p = Utilidades.ToInt(AbonomaskedTextBox.Text);
            var cc = BLL.CobrosBLL.Buscar(NombrecomboBox.Text);
            Cobros();
            if (cc != null)
            {
                if (AbonomaskedTextBox.Text == String.Empty)
                {
                    r = cc.Prestamo - Convert.ToInt32(cc.valorCuotas);                   
                }
                else
                {
                    r = cc.Prestamo - Convert.ToInt32(cc.valorCuotas + p);  
                }
                BLL.CobrosBLL.Modificar(r, NombrecomboBox.Text);
                Retornar();
            }
        }
        public void Cobros()
        {
            Cobros cobro = new Cobros();
            cobro.ClienteId = Utilidades.ToInt(ClienteIdtextBox.Text);
            cobro.PrestamoId = Utilidades.ToInt(PrestamoIdtextBox.Text);
            cobro.NumeroCuotas = Utilidades.ToInt(CuotastextBox.Text);
            cobro.Abono = Utilidades.ToInt(AbonomaskedTextBox.Text);
            cobro.Fecha = Convert.ToDateTime(FechadateTimePicker.Value);

            if (BLL.CobrosBLL.Insertar(cobro))
            {
                MessageBox.Show("Guardo");
            }          
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
