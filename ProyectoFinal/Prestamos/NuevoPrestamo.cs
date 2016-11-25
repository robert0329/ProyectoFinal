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
        public List<Clientes> lis = new List<Clientes>();
        public NuevoPrestamo()
        {
            InitializeComponent();
        }
        private void ListarComboBox()
        {
            Conexion conn = new Conexion();
            var lista = conn.garante.ToList();
            var lis = conn.clientes.ToList();
            GarantecomboBox.DataSource = lista;
            NombreClientecomboBox.DataSource = lis;
            GarantecomboBox.DisplayMember = "Nombres";
            NombreClientecomboBox.DisplayMember = "Nombres";

        }
        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            ListarComboBox();
        }
        private void Carcular_Click(object sender, EventArgs e)
        {
            Entidades.Prestamos Prestamos = new Entidades.Prestamos();
            Double i, k;
            Double z = Convert.ToDouble(MontomaskedTextBox.Text);
            Double x = Convert.ToDouble(InterestextBox.Text);
            Double c = Convert.ToDouble(MesesnumericUpDown.Text);
            Double v = Convert.ToDouble(MontomaskedTextBox.Text);
            Double b = Convert.ToDouble(CantidatextBox.Text);

            i = z * x / 100 * c + v;
            k = i / b;

            CuotasmaskedTextBox.Text = Convert.ToString(k);
            TotalmaskedTextBox.Text = Convert.ToString(i);
        }
        private void GarantecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Entidades.Prestamos LlenarClase()
        {
            Entidades.Prestamos Prestamos = new Entidades.Prestamos();

            Prestamos.Nombres = NombreClientecomboBox.Text;
            Prestamos.CantidadCuotas = Utilidades.ToInt(CantidatextBox.Text);
            Prestamos.Interes = Utilidades.ToInt(InterestextBox.Text);
            Prestamos.FormaDePago = FormaPagocomboBox.Text;
            Prestamos.MontoPrestado = Utilidades.ToInt(MontomaskedTextBox.Text);
            Prestamos.Meses = Utilidades.ToInt(MesesnumericUpDown.Text);
            Prestamos.Garante = GarantecomboBox.Text;
            Prestamos.Hasta = HastamaskedTextBox.Text;
            Prestamos.Cuotas = Utilidades.ToInt(CuotasmaskedTextBox.Text);
            Prestamos.Total = Utilidades.ToInt(TotalmaskedTextBox.Text);

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
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void HastamaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void NombreClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NombreClientecomboBox.Text = CantidatextBox.Text = InterestextBox.Text = "";
        }
    }
}
