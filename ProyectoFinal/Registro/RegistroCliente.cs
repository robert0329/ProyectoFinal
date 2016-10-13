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

        private Usuarios LlenarClase()
        {
            Usuarios usuario = new Usuarios();
            
            usuario.Nombre = NombretextBox.Text;
            usuario.Apellido = ApellidotextBox.Text;
            usuario.Direccion = DirecciontextBox.Text;
            usuario.Telefono = TelefonotextBox.Text;
            usuario.Cedula = CedulatextBox.Text;


            return usuario;
        }
        
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            usuario = LlenarClase();

            if (UsuariosBll.Insertar(usuario))
            {
                Nuevobutton.PerformClick();

                MessageBox.Show("Guardodo con exito");
            }
        }
    }
}
