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

namespace ProyectoFinal.RegistroUsuarios
{
    public partial class RegistroDeUsuarios : Form
    {
        public RegistroDeUsuarios()
        {
            InitializeComponent();
        }
        private Usuarios LlenarClase()
        {
            Usuarios usuario = new Usuarios();

            usuario.Usuario = textUsuario.Text;
            usuario.Contraseña = textContraseña.Text;

            return usuario;
        }
        private void RegistrarB_Click(object sender, EventArgs e)
        { 
            if ((textContraseña.Text == "") || (textConfirmar.Text == "") || (textUsuario.Text == ""))
            {
                MessageBox.Show("No Puedes Dejar Campos Vacios");
            }
            else
            if (textContraseña.Text == textConfirmar.Text)
            {
                Usuarios usuario = new Usuarios();
                usuario = LlenarClase();

                if (UsuariosBLL.Guardar(usuario))
                {
                     MessageBox.Show("Guardado con exito");
                    this.Close();
                }
            }
            if (textContraseña.Text != textConfirmar.Text)
            {
                MessageBox.Show("Contraseña Invalida");
            }
        }

        private void CancelarB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
