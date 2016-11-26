using BLL;
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
        public Desembolso()
        {
            InitializeComponent();
        }
        void cargar()
        {
            var conn = new Conexion();
            var lista = conn.Prestamos.ToList();
            NombrecomboBox.DataSource = lista;
            NombrecomboBox.DisplayMember = "Nombres";
        }
        private void Cobrarbutton_Click(object sender, EventArgs e)
        {
            llenar();
            int r = 0;
            var cc = BLL.CobrosBLL.Buscar(NombrecomboBox.Text);
            if (cc != null)
            {
                r = (cc.Prestamo - Utilidades.ToInt(MontotextBox.Text));
                BLL.CobrosBLL.Modificar(r, NombrecomboBox.Text);
            }
            Limpiar();
        }
        private void Desembolso_Load(object sender, EventArgs e)
        { 
            cargar();
            Limpiar();
        }
        private void NombrecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var d = new Conexion();
            var cc = BLL.CobrosBLL.Buscar(NombrecomboBox.Text);
            if (cc != null)
            {
                DeudatextBox.Text = Convert.ToString(cc.Prestamo);
            }
        }
        public void Limpiar()
        {
            NombrecomboBox.Text = DeudatextBox.Text = MontotextBox.Text = "";
        }
        public void llenar()
        {
            Cobros Co = new Cobros();
            Co.Nombres = NombrecomboBox.Text;
            Co.Deuda = Utilidades.ToInt(DeudatextBox.Text);
            Co.UltimoPago = Utilidades.ToInt(MontotextBox.Text);

            if (CobrosBLL.Insertar(Co , NombrecomboBox.Text , Utilidades.ToInt(DeudatextBox.Text) , Utilidades.ToInt(MontotextBox.Text)))
            {
                MessageBox.Show("Cobro con exito");
            }
        }
    }
}
