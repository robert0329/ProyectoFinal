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
        public RegistroGarante()
        {
            InitializeComponent();
        }
        private Garantes Llenar()
        {
            Garantes garantes = new Garantes();

            garantes.Nombres = nombresTextBox.Text;
            garantes.Direccion = direccionTextBox.Text;
            garantes.Telefono = telefonoTextBox.Text;
            garantes.Cedula = cedulaTextBox.Text;
            garantes.Sexo = SexocomboBox.Text;
            
            return garantes;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Garantes garantes = new Garantes();

            garantes = Llenar();

            if (GaranteBLL.Guardar(garantes))
            {
                Nuevobutton.PerformClick();

                MessageBox.Show("Guardado con exito");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(garanteIdTextBox.Text);
            var cc = GaranteBLL.Eliminar(d);
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(garanteIdTextBox.Text);
            var cc = GaranteBLL.Buscar(d);

            if (cc != null)
            {
                nombresTextBox.Text = cc.Nombres;
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            nombresTextBox.Text = direccionTextBox.Text = telefonoTextBox.Text = cedulaTextBox.Text = SexocomboBox.Text = "";
        }
    }
}
