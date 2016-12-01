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
        public List<Entidades.Prestamos> Listaprestamo = new List<Entidades.Prestamos>();
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
            NombrecomboBox.DisplayMember = "Nombre";

        }
        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            ListarComboBox();
            Nuevobutton.PerformClick();
            FormadePagocomboBox.Items.Add("Semanal");
            FormadePagocomboBox.Items.Add("Quincenal");
            FormadePagocomboBox.Items.Add("Mensual");
        }
        private Entidades.Prestamos LlenarClase()
        {
            Entidades.Prestamos Prestamos = new Entidades.Prestamos();

            Prestamos.ClienteId = Utilidades.ToInt(CodigoClientetextBox.Text);
            Prestamos.Nombre = NombrecomboBox.Text;
            Prestamos.Apellidos = ApellidoTextBox.Text;
            Prestamos.Prestamo = Utilidades.ToInt(PrestamotextBox.Text);
            Prestamos.Interes = Utilidades.ToInt(InteresnumericUpDown.Text);
            Prestamos.Meses = Utilidades.ToInt(MesesnumericUpDown.Text);
            Prestamos.FormaPago = FormadePagocomboBox.Text;
            Prestamos.Fecha = Convert.ToDateTime(FechadateTimePicker.Text);
            Prestamos.Garante = GarantecomboBox.Text;
            Prestamos.MontoFinal = Utilidades.ToInt(MontoFinaltextBox.Text);
            Prestamos.InteresFinal = Convert.ToDouble(InteresFinaltextBox.Text);
            Prestamos.NumeroCuotas = Utilidades.ToInt(NumeroCuotastextBox.Text);
            Prestamos.valorCuotas = Convert.ToDouble(ValorPorCuotastextBox.Text);

            return Prestamos;
        }
        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            Entidades.Prestamos Prestamos = new Entidades.Prestamos();
            if (ValidarTextbox())
            {
                if (FormadePagocomboBox.Text == "Semanal")
                {
                    var p = Condiciones.CondicionesSemanal(Convert.ToInt32(MesesnumericUpDown.Text));
                    Semanal(p);
                }
                else
            if (FormadePagocomboBox.Text == "Quincenal")
                {
                    var p = Condiciones.CondicionesQuincenal(Convert.ToInt32(MesesnumericUpDown.Text));
                    Quincenal(p);
                }
                else
            if (FormadePagocomboBox.Text == "Mensual")
                {
                    var p = Condiciones.CondicionesMensual(Convert.ToInt32(MesesnumericUpDown.Text));
                    Mensual(p);
                }
            }      
        }
        public void Semanal(Double N)
        {
            Double i, k, m;
            Double z = Convert.ToDouble(PrestamotextBox.Text);
            Double x = Convert.ToDouble(InteresnumericUpDown.Text);
            Double c = Convert.ToDouble(MesesnumericUpDown.Text);

            i = z * x / 100 * c;
            m = i + z;
            k = m / N;

            ValorPorCuotastextBox.Text = Convert.ToString(k);
            MontoFinaltextBox.Text = Convert.ToString(m);
            Prestamos2textBox.Text = Convert.ToString(z);
            NumeroCuotastextBox.Text = Convert.ToString(N);
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
            k = m / N;

            ValorPorCuotastextBox.Text = Convert.ToString(k);
            MontoFinaltextBox.Text = Convert.ToString(m);
            Prestamos2textBox.Text = Convert.ToString(z);
            NumeroCuotastextBox.Text = Convert.ToString(N);
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
            k = m / N;

            ValorPorCuotastextBox.Text = Convert.ToString(k);
            MontoFinaltextBox.Text = Convert.ToString(m);
            Prestamos2textBox.Text = Convert.ToString(z);
            NumeroCuotastextBox.Text = Convert.ToString(N);
            InteresFinaltextBox.Text = Convert.ToString(i);
        }
        public void ActivarTexto()
        {
            PrestamotextBox.Enabled = InteresnumericUpDown.Enabled = MesesnumericUpDown.Enabled = FormadePagocomboBox.Enabled = FechadateTimePicker.Enabled = GarantecomboBox.Enabled = Calcularbutton.Enabled= true;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Entidades.Prestamos Prestamos = new Entidades.Prestamos();

            Prestamos = LlenarClase();

            if (ValidarTextbox())
            {
                PrestamosBLL.Guardar(Prestamos);
                MessageBox.Show("Prestamo Realizado", "<- Proceso Exitoso ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevobutton.PerformClick();
            }
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            //PrestamodataGridView = null;
            NombrecomboBox.Text = ApellidoTextBox.Text = CodigoClientetextBox.Text = PrestamotextBox.Text = Prestamos2textBox.Text = NumeroCuotastextBox.Text = ValorPorCuotastextBox.Text = InteresnumericUpDown.Text =MontoFinaltextBox.Text= InteresFinaltextBox.Text = MesesnumericUpDown.Text = FormadePagocomboBox.Text = FechadateTimePicker.Text = GarantecomboBox.Text = "";
        }
        private void NombrecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cc = ClientesBLL.Buscar(NombrecomboBox.Text);
            ActivarTexto();
            if (cc != null)
            {
                CodigoClientetextBox.Text = Convert.ToString(cc.ClienteId);
                ApellidoTextBox.Text = cc.Apellidos;
            }
        }
        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            
        }
        private bool ValidarTextbox()
        {
            if (string.IsNullOrEmpty(NombrecomboBox.Text))
            {
                ClienteerrorProvider.SetError(NombrecomboBox, "Favor ingresar el nombre");
                return false;
            }
            if (string.IsNullOrEmpty(PrestamotextBox.Text))
            {
                ClienteerrorProvider.SetError(PrestamotextBox, "Favor ingresar el Monto");
                return false;
            }

            if (string.IsNullOrEmpty(InteresnumericUpDown.Text))
            {
                ClienteerrorProvider.SetError(InteresnumericUpDown, "Favor ingresar el Interes");
                return false;
            }
            if (string.IsNullOrEmpty(MesesnumericUpDown.Text))
            {
                ClienteerrorProvider.SetError(MesesnumericUpDown, "Favor ingresar los meses");
                return false;
            }
            if (string.IsNullOrEmpty(FormadePagocomboBox.Text))
            {
                ClienteerrorProvider.SetError(FormadePagocomboBox, "Favor ingresar la forma de pago");
                return false;
            }
            
            return true;
        }
        private void Buscar_Click(object sender, EventArgs e)
        {
            if (CodigoClientetextBox.Text == string.Empty)
            {
                PrestamodataGridView.DataSource = null;
                //PrestamodataGridView.DataSource = PrestamosBLL.GetLista();
                PrestamodataGridView.DataSource = PrestamosBLL.GetListaId(Utilidades.ToInt(CodigoClientetextBox.Text));
            }
            else
            {
                PrestamodataGridView.DataSource = null;
                PrestamodataGridView.DataSource = PrestamosBLL.GetListaId(Utilidades.ToInt(CodigoClientetextBox.Text)); }  
        }
    }
}
