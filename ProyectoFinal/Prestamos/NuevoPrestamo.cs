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
using BLL;

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
            Double z = Convert.ToDouble(MontomaskedTextBox.Text);
            Double x = Convert.ToDouble(InterestextBox.Text);
            Double c = Convert.ToDouble(MesesnumericUpDown.Text);
            Double v = Convert.ToDouble(MontomaskedTextBox.Text);
            Double b = Convert.ToDouble(CantidatextBox.Text);

            i = z * x / 100 * c + v;//Total a pagar
            k = i / b;// por cuotas

            CuotasmaskedTextBox.Text = Convert.ToString(k);
            TotalmaskedTextBox.Text = Convert.ToString(i);

            for (int p = 0; p < b; ++p)
            {
                TabladataGridView.Rows.Add(p, k);
            }
        }

        private void GarantecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Entidades.Prestamos LlenarClase()
        {
            Entidades.Prestamos Prestamos = new Entidades.Prestamos();

            Prestamos.CantidadCuotas = Utilidades.ToInt(CantidatextBox.Text);
            Prestamos.Interes = Utilidades.ToInt(InterestextBox.Text);
            Prestamos.FormaDePago = FormaPagocomboBox.Text;
            Prestamos.Desde = Convert.ToDateTime(DesdemaskedTextBox);
            Prestamos.MontoPrestado = Utilidades.ToInt(MontomaskedTextBox.Text);
            Prestamos.Meses = Utilidades.ToInt(MesesnumericUpDown.Text);
            Prestamos.Garante = GarantecomboBox.Text;
            Prestamos.Hasta = Convert.ToDateTime(HastamaskedTextBox);
            Prestamos.Cuotas = Utilidades.ToInt(CuotasmaskedTextBox.Text);
            Prestamos.Total =  Utilidades.ToInt(TotalmaskedTextBox.Text);
            Prestamos.MesesgraciasMonatoria = Utilidades.ToInt(MesesMoratorianumericUpDown.Text);
            Prestamos.DiasgraciasMonatoria = Utilidades.ToInt(DiaMoratorianumericUpDown.Text);
            Prestamos.MontoMesesMonatoria = Utilidades.ToInt(MontoEstimadotextBox.Text);
            Prestamos.MontoDiaMonatoria = Utilidades.ToInt(DiaMoratoriotextBox.Text);

            return Prestamos;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Entidades.Prestamos Prestamos = new Entidades.Prestamos();

            Prestamos = LlenarClase();

            if (PrestamosBLL.Guardar(Prestamos))
            {
                Nuevobutton.PerformClick();

                MessageBox.Show("Guardado con exito");
            }
        }
    }
}
