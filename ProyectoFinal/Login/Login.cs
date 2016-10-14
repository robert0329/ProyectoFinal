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

namespace ProyectoFinal.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TextCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void BEntrar_Click(object sender, EventArgs e)
        {
            Usuarios User = new Usuarios();

            User.Usuario = TextCuenta.Text;
            User.Usuario = TextClave.Text;

            FormularioPrincipal FP = new FormularioPrincipal();
            FP.Show();
        }
        
    }
}
