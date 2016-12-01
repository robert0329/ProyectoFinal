using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace ProyectoFinal.RegistroGarantes
{
    public partial class RegistroGarante : Form
    {
        Garantes gar = new Garantes();
        public RegistroGarante()
        {
            InitializeComponent();
        }
        private Garantes Llenar()
        {
            Garantes garantes = new Garantes();

            garantes.Nombres = nombresTextBox.Text;
            garantes.Direccion = direccionTextBox.Text;
            garantes.Telefono = telefonoMaskedTextBox.Text;
            garantes.Cedula = cedulaMaskedTextBox.Text;
            garantes.Sexo = sexoComboBox.Text;
            
            return garantes;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Garantes gar = new Garantes();
            gar.GaranteId = Utilidades.ToInt(garanteIdTextBox.Text);
            gar.Nombres = nombresTextBox.Text;
            gar.Direccion = direccionTextBox.Text;
            gar.Telefono = telefonoMaskedTextBox.Text;
            gar.Cedula = cedulaMaskedTextBox.Text;
            gar.Sexo = sexoComboBox.Text;

            if (ValidarTextbox())
            {
                GaranteBLL.Insertar(gar);
                MessageBox.Show("Proceso realizado", "<- Proceso Exitosa ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevobutton.PerformClick();
            }  
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            nombresTextBox.Text = direccionTextBox.Text = telefonoMaskedTextBox.Text = cedulaMaskedTextBox.Text = sexoComboBox.Text = "";
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(garanteIdTextBox.Text);
            var cc = GaranteBLL.Buscar(d);

            if (cc != null)
            {
                nombresTextBox.Text = cc.Nombres;
            }
            if (!string.IsNullOrEmpty(garanteIdTextBox.Text))
            {
                var garante = BLL.GaranteBLL.Buscar(Utilidades.ToInt(garanteIdTextBox.Text));
                if (garante != null)
                {
                    nombresTextBox.Text = garante.Nombres;
                    direccionTextBox.Text = garante.Direccion;
                    telefonoMaskedTextBox.Text = garante.Telefono;
                    cedulaMaskedTextBox.Text = garante.Cedula;
                    sexoComboBox.Text = garante.Sexo;
                }
                else
                {
                    MessageBox.Show("Este Id no contiene un garante", "<- Busqueda Fallida ->", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var cc = BLL.GaranteBLL.Buscar(Utilidades.ToInt(garanteIdTextBox.Text));
            if (cc != null)
            {
                Nuevobutton.PerformClick();
                if (BLL.GaranteBLL.Eliminar(cc))
                {
                    MessageBox.Show("Garante Eliminado", "<- Proceso Exitoso ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha eliminado", "<- Proceso Fallido ->", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RegistroGarante_Load(object sender, EventArgs e)
        {
            Validar();
        }
        private bool ValidarTextbox()
        {
            if (string.IsNullOrEmpty(nombresTextBox.Text))
            {
                ClienteerrorProvider.SetError(nombresTextBox, "Favor ingresar el nombre");
                return false;
            }
            if (string.IsNullOrEmpty(direccionTextBox.Text))
            {
                ClienteerrorProvider.SetError(direccionTextBox, "Favor ingresar la direccion");
                return false;
            }
            if (string.IsNullOrEmpty(telefonoMaskedTextBox.Text))
            {
                ClienteerrorProvider.SetError(telefonoMaskedTextBox, "Favor ingresar el telefono");
                return false;
            }
            if (string.IsNullOrEmpty(cedulaMaskedTextBox.Text))
            {
                ClienteerrorProvider.SetError(cedulaMaskedTextBox, "Favor ingresar la cedula");
                return false;
            }
            if (string.IsNullOrEmpty(sexoComboBox.Text))
            {
                ClienteerrorProvider.SetError(sexoComboBox, "Favor ingresar el sexo");
                return false;
            }
            return true;
        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(garanteIdTextBox.Text))
            {
                ClienteerrorProvider.SetError(garanteIdTextBox, "Ingresar el ID");
                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Validar()
        {
            var u = new Utilidades(garanteIdTextBox, "N");
            var u1 = new Utilidades(nombresTextBox, "L");
            var u2 = new Utilidades(garanteIdTextBox, "N");
            var u3 = new Utilidades(direccionTextBox, "LN");

        }
    }
}

