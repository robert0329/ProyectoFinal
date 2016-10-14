using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.RegistroUsuarios;
using ProyectoFinal.Login;

namespace ProyectoFinal.Login
{
    public partial class Seleccion : Form
    {
        public Seleccion()
        {
            InitializeComponent();
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            RegistroDeUsuarios ru = new RegistroDeUsuarios();
            ru.Show();
        }

        private void Entrarbutton_Click(object sender, EventArgs e)
        {
            Login Lg = new Login();
            Lg.Show();
        }
    }
}
