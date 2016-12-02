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
        public List<Garantes> garantes = new List<Garantes>();
        Entidades.Prestamos Pre = new Entidades.Prestamos();
        public NuevoPrestamo()
        {
            InitializeComponent();
        }
        private void ListarComboBox()
        {
            var lista = BLL.GaranteBLL.GetLista();
            var lis = BLL.ClientesBLL.GetLista();
            GarantecomboBox.DataSource = lista;
            NombrecomboBox.DataSource = lis;

            GarantecomboBox.DisplayMember = "Nombres";
            GarantecomboBox.ValueMember = "GaranteId";
            NombrecomboBox.DisplayMember = "Nombre";

            GaranteActualcomboBox.DataSource = lista;
            GaranteActualcomboBox.DisplayMember = "Nombres";
            GaranteActualcomboBox.ValueMember = "GaranteId";
        }
        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            ListarComboBox();
            Nuevobutton.PerformClick();
            FormadePagocomboBox.Items.Add("Semanal");
            FormadePagocomboBox.Items.Add("Quincenal");
            FormadePagocomboBox.Items.Add("Mensual");
        }
        private void LlenarClase(Entidades.Prestamos prestamos)
        {

            prestamos.ClienteId = Utilidades.ToInt(CodigoClientetextBox.Text);
            prestamos.Nombre = NombrecomboBox.Text;
            prestamos.Apellidos = ApellidoTextBox.Text;
            prestamos.Prestamo = Utilidades.ToInt(PrestamotextBox.Text);
            prestamos.Interes = Utilidades.ToInt(InteresnumericUpDown.Text);
            prestamos.Meses = Utilidades.ToInt(MesesnumericUpDown.Text);
            prestamos.FormaPago = FormadePagocomboBox.Text;
            prestamos.Fecha = Convert.ToDateTime(FechadateTimePicker.Text);
            prestamos.MontoFinal = Utilidades.ToInt(MontoFinaltextBox.Text);
            prestamos.InteresFinal = Convert.ToDouble(InteresFinaltextBox.Text);
            prestamos.NumeroCuotas = Utilidades.ToInt(NumeroCuotastextBox.Text);
            prestamos.valorCuotas = Convert.ToDouble(ValorPorCuotastextBox.Text);

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
            PrestamotextBox.Enabled = InteresnumericUpDown.Enabled = MesesnumericUpDown.Enabled = FormadePagocomboBox.Enabled = FechadateTimePicker.Enabled = GarantecomboBox.Enabled = Calcularbutton.Enabled = true;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LlenarClase(Pre);

            if (ValidarTextbox())
            {
                Pre.PrestamoId = Utilidades.ToInt(PrestamosIdtextBox.Text);
                if (PrestamosBLL.Guardar(Pre))
                {

                    if (BLL.GaranteBLL.Insertar(garantes))
                        MessageBox.Show("Prestamo Realizado", "<- Proceso Exitoso ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Nuevobutton.PerformClick();
            }
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NombrecomboBox.Text = ApellidoTextBox.Text = CodigoClientetextBox.Text = PrestamotextBox.Text = Prestamos2textBox.Text =
                NumeroCuotastextBox.Text = ValorPorCuotastextBox.Text = InteresnumericUpDown.Text = MontoFinaltextBox.Text =
                InteresFinaltextBox.Text = MesesnumericUpDown.Text = FormadePagocomboBox.Text = FechadateTimePicker.Text =
                GarantecomboBox.Text = "";
            Pre = new Entidades.Prestamos();
            garantes = new List<Garantes>();
            NuevocheckBox.Checked = false;
            garantedataGridView.DataSource = null;
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
        public void rellenar(Entidades.Prestamos presta)
        {
            if (presta != null)
            {
                NombrecomboBox.Text = presta.Nombre;
                ApellidoTextBox.Text = presta.Apellidos;
                CodigoClientetextBox.Text = presta.ClienteId.ToString();
                PrestamotextBox.Text = presta.Prestamo.ToString();
                InteresnumericUpDown.Text = presta.Interes.ToString();
                MesesnumericUpDown.Text = presta.Meses.ToString();
                FormadePagocomboBox.SelectedText = presta.FormaPago;
                GaranteActualcomboBox.SelectedValue = presta.GaranteId;
                FechadateTimePicker.Value = presta.Fecha;
                MontoFinaltextBox.Text = presta.MontoFinal.ToString();
                InteresFinaltextBox.Text = presta.InteresFinal.ToString();
                Prestamos2textBox.Text = presta.Prestamo.ToString();
                NumeroCuotastextBox.Text = presta.NumeroCuotas.ToString();
                ValorPorCuotastextBox.Text = presta.valorCuotas.ToString();
                garantedataGridView.DataSource = null;
                garantedataGridView.DataSource = garantes;
            }
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
            Nuevobutton.PerformClick();
            var p = Convert.ToInt32(PrestamosIdtextBox.Text);
            if (PrestamosIdtextBox.Text != string.Empty)
            {
                garantedataGridView.DataSource = null;
                Pre = BLL.PrestamosBLL.Buscar(p);
                if (Pre != null)
                {
                    garantes.AddRange(BLL.GaranteBLL.GetLista(p));
                    rellenar(Pre);
                }

            }
            //else
            //{
            //    garantedataGridView.DataSource = null;
            //    garantedataGridView.DataSource = PrestamosBLL.GetListaId(Utilidades.ToInt(CodigoClientetextBox.Text));
            //}  
        }
        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (true)
            {
                Garantes G = BLL.GaranteBLL.Buscar((int)GarantecomboBox.SelectedValue);
                Pre.GaranteId = G.GaranteId;
                garantes.Add(G);
                garantedataGridView.DataSource = null;
                garantedataGridView.DataSource = garantes;
            }
            else
            {

            }
        }
        private void Savebutton_Click(object sender, EventArgs e)
        {
            Garantes G = new Garantes();

            G.Nombres = NombrestextBox.Text;
            G.Direccion = DirecciontextBox.Text;
            G.Telefono = TelefonomaskedTextBox.Text;
            G.Cedula = CedulamaskedTextBox.Text;
            G.Sexo = SexocomboBox.Text;

            if (GaranteBLL.Insertar(G))
            {
                NombrestextBox.Text = DirecciontextBox.Text = TelefonomaskedTextBox.Text = CedulamaskedTextBox.Text = SexocomboBox.Text = "";
                ListarComboBox();
                GarantegroupBox.Visible = false;
                NuevocheckBox.Checked = false;
            }

        }
        private void NuevocheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NuevocheckBox.Checked)
            {
                GarantegroupBox.Visible = true;
            }
            else
            {
                GarantegroupBox.Visible = false;
            }
        }
    }
}
