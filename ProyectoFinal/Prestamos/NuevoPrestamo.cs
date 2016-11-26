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
        public List<PrestamoClientes> ListPrestamoCliente = new List<PrestamoClientes>();
        Double Mes;
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
            NombrecomboBox.DataSource = lis;
            GarantecomboBox.DisplayMember = "Nombres";
            NombrecomboBox.DisplayMember = "Nombres";

        }
        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            ListarComboBox();
            FormadePagocomboBox.Items.Add("Semanal");
            FormadePagocomboBox.Items.Add("Quincenal");
            FormadePagocomboBox.Items.Add("Mensual");
        }

        
        public Double CondicionesQuincenal()
        {
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 1)
            {
                Mes = 2;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 2)
            {
                Mes = 4;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 3)
            {
                Mes = 6;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 4)
            {
                Mes = 8;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 5)
            {
                Mes = 10;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 6)
            {
                Mes = 12;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 7)
            {
                Mes = 14;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 8)
            {
                Mes = 16;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 9)
            {
                Mes = 18;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 10)
            {
                Mes = 20;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 11)
            {
                Mes = 22;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 12)
            {
                Mes = 24;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 13)
            {
                Mes = 26;
            }
            return Mes;
        }
        public Double CondicionesMensual()
        {
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 1)
            {
                Mes = 1;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 2)
            {
                Mes = 2;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 3)
            {
                Mes = 3;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 4)
            {
                Mes =  4;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 5)
            {
                Mes = 5;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 6)
            {
                Mes = 6;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 7)
            {
                Mes = 7;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 8)
            {
                Mes = 8;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 9)
            {
                Mes = 9;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 10)
            {
                Mes = 10;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 11)
            {
                Mes = 11;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 12)
            {
                Mes = 12;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 13)
            {
                Mes = 13;
            }
            return Mes;
        }
        public Double CondicionesSemanal()
        {
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 1)
            {
                Mes = 4;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 2)
            {
                Mes = 8;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 3)
            {
                Mes = 12;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 4)
            {
                Mes = 16;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 5)
            {
                Mes = 20;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 6)
            {
                Mes = 24;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 7)
            {
                Mes = 28;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 8)
            {
                Mes = 32;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 9)
            {
                Mes = 36;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 10)
            {
                Mes = 40;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 11)
            {
                Mes = 44;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 12)
            {
                Mes = 48;
            }
            else
            if (Convert.ToInt32(MesesnumericUpDown.Text) == 13)
            {
                Mes = 52;
            }
            return Mes;
        }        
        private Entidades.Prestamos LlenarClase()
        {
            Entidades.Prestamos Prestamos = new Entidades.Prestamos();

            //Prestamos.Nombre = NombreClientecomboBox.Text;
            //Prestamos.CantidadCuotas = Utilidades.ToInt(CantidatextBox.Text);
            //Prestamos.Interes = Utilidades.ToInt(InterestextBox.Text);
            //Prestamos.FormaDePago = FormaPagocomboBox.Text;
            //Prestamos.MontoPrestado = Utilidades.ToInt(MontomaskedTextBox.Text);
            //Prestamos.Meses = Utilidades.ToInt(MesesnumericUpDown.Text);
            //Prestamos.Garante = GarantecomboBox.Text;
            //Prestamos.Fecha = HastamaskedTextBox.Text;
            //Prestamos.Cuotas = Utilidades.ToInt(CuotasmaskedTextBox.Text);
            //Prestamos.Total = Utilidades.ToInt(TotalmaskedTextBox.Text);

            return Prestamos;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Entidades.Prestamos Prestamos = new Entidades.Prestamos();

            Prestamos = LlenarClase();

            if (Prestamos != null)
            {
                PrestamosBLL.Insertar(Prestamos);
                //Nuevobutton.PerformClick();
                MessageBox.Show("Guardado con exito");
            }
        }
        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            Entidades.Prestamos Prestamos = new Entidades.Prestamos();

            if (FormadePagocomboBox.Text == "Diario")
            {
                //CondicionesDiario();
            }
            else
            if (FormadePagocomboBox.Text == "Semanal")
            {
                CondicionesSemanal();
                Semanal(Mes);
            }
            else
            if (FormadePagocomboBox.Text == "Quincenal")
            {
                CondicionesQuincenal();
                Quincenal(Mes);
            }
            else
            if (FormadePagocomboBox.Text == "Mensual")
            {
                CondicionesMensual();
                Mensual(Mes);
            }
        }
        public void Diario(Double N)
        {
            Double i, k, m;
            Double z = Convert.ToDouble(PrestamotextBox.Text);
            Double x = Convert.ToDouble(InteresnumericUpDown.Text);
            Double c = Convert.ToDouble(MesesnumericUpDown.Text);

            i = z * x / 100 * c;
            m = i + z;
            k = m / Mes;

            ValorPorCuotastextBox.Text = Convert.ToString(k);
            MontoFinaltextBox.Text = Convert.ToString(m);
            Prestamos2textBox.Text = Convert.ToString(z);
            NumeroCuotastextBox.Text = Convert.ToString(Mes);
            InteresFinaltextBox.Text = Convert.ToString(i);
        }
        public void Semanal(Double N)
        {
            Double i, k, m;
            Double z = Convert.ToDouble(PrestamotextBox.Text);
            Double x = Convert.ToDouble(InteresnumericUpDown.Text);
            Double c = Convert.ToDouble(MesesnumericUpDown.Text);

            i = z * x / 100 * c;
            m = i + z;
            k = m / Mes;

            ValorPorCuotastextBox.Text = Convert.ToString(k);
            MontoFinaltextBox.Text = Convert.ToString(m);
            Prestamos2textBox.Text = Convert.ToString(z);
            NumeroCuotastextBox.Text = Convert.ToString(Mes);
            InteresFinaltextBox.Text = Convert.ToString(i);
        }
        public void Quincenal(Double N)
        {
            Double i, k, m;
            Double z = Convert.ToDouble(PrestamotextBox.Text);
            Double x = Convert.ToDouble(InteresnumericUpDown.Text);
            Double c = Convert.ToDouble(MesesnumericUpDown.Text);

            i = z * x / 100 * c;
            m = i + z;
            k = m / Mes;

            ValorPorCuotastextBox.Text = Convert.ToString(k);
            MontoFinaltextBox.Text = Convert.ToString(m);
            Prestamos2textBox.Text = Convert.ToString(z);
            NumeroCuotastextBox.Text = Convert.ToString(Mes);
            InteresFinaltextBox.Text = Convert.ToString(i);
        }
        public void Mensual(Double N)
        {
            Double i, k, m;
            Double z = Convert.ToDouble(PrestamotextBox.Text);
            Double x = Convert.ToDouble(InteresnumericUpDown.Text);
            Double c = Convert.ToDouble(MesesnumericUpDown.Text);

            i = z * x / 100 * c;
            m = i + z;
            k = m / Mes;

            ValorPorCuotastextBox.Text = Convert.ToString(k);
            MontoFinaltextBox.Text = Convert.ToString(m);
            Prestamos2textBox.Text = Convert.ToString(z);
            NumeroCuotastextBox.Text = Convert.ToString(Mes);
            InteresFinaltextBox.Text = Convert.ToString(i);
        }
    }

}
