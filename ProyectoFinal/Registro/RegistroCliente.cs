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

namespace ProyectoFinal.RegistroCliente
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        public void RegistroCliente_Load(object sender, EventArgs e)
        {

        }

        private Clientes LlenarClase()
        {
            Clientes Cliente = new Clientes();

            Cliente.Nombres = NombretextBox.Text;
            Cliente.Direccion = DirecciontextBox.Text;
            Cliente.Telefono = TelefonotextBox.Text;
            Cliente.Cedula = CedulatextBox.Text;
            Cliente.Sexo = SexocomboBox.Text;
            return Cliente;
        }
        
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes Cliente = new Clientes();

            Cliente = LlenarClase();

            if (ClientesBLL.Insertar(Cliente))
            {
                Nuevobutton.PerformClick();

                MessageBox.Show("Guardodo con exito");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

        }
    }
}
