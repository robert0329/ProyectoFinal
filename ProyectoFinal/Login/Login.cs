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
using DAL;
using ProyectoFinal.RegistroUsuarios;

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
            Validar();
            if (ValidarSesion() == DialogResult.OK)
            {
                //this.Close();
                FormularioPrincipal f = new FormularioPrincipal();
                f.Show();
            }
        }
        public bool ValidarUsuario()
        {
            if (UsuariosBLL.GetListaNombreUsuario(UsuarioTextBox.Text).Count() == 0)
            {
                MessageBox.Show("Usuario incorrecto o no registrado");
                return false;
            }
            return true;
        }
        public bool ValidarContrasena()
        {
            if (UsuariosBLL.GetContrasena(ContraseñaTextBox.Text).Count() == 0)
            {
                MessageBox.Show("Contraseña incorrecta");
                return false;
            }
            return true;
        }
        public DialogResult ValidarSesion()
        {
            if (ValidarUsuario() == true && ValidarContrasena() == true)
            {
                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
        public void Validar()
        {
            if(ContraseñaTextBox.Text == string.Empty && UsuarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ContraseñaTextBox, "Campo vacio");
                errorProvider1.SetError(UsuarioTextBox, "Campo vacio");
            }
        }
        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();

            UsuariosBLL.Guardar(new Usuarios(1 , "Admin ", "123"));
        }
    }
}
