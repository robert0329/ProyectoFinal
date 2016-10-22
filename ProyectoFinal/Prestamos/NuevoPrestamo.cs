using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using DAL;

namespace ProyectoFinal.Prestamos
{
    public partial class NuevoPrestamo : Form
    {
        public List<Garantes> lista = new List<Garantes>();
        public NuevoPrestamo()
        {
            InitializeComponent();
        }
        private void ListarGarante()
        {
            Conexion conn = new Conexion();
            var lista = conn.garante.ToList();
            if (lista.Count > 0)
            {
                GarantecomboBox.DataSource = lista;
                GarantecomboBox.DisplayMember = "Nombres";
            }
        }
        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            ListarGarante();
        }

        private void Carcular_Click(object sender, EventArgs e)
        {
            Double i, k;
            Double z = Convert.ToDouble(MontotextBox.Text);
            Double x = Convert.ToDouble(InterestextBox.Text);
            Double c = Convert.ToDouble(MesesnumericUpDown.Text);
            Double v = Convert.ToDouble(MontotextBox.Text);
            Double b = Convert.ToDouble(CantidatextBox.Text);

            i = z * x / 100 * c + v;//Total a pagar
            k = i / b;// por cuotas

            CuotastextBox.Text = Convert.ToString(k);
            TotaltextBox.Text = Convert.ToString(i);
            for (int p = 0; p < 10; p++)
            {
                TabladataGridView.DataSource = k;
                TabladataGridView.DataMember = "Cuotas";
            }
        }

        private void GarantecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
