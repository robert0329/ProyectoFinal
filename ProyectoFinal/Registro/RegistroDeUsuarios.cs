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
            if(ValidarTextbox())
            {
                Usuarios usuario = new Usuarios();
                usuario = LlenarClase();

                usuario.UsuarioId = Utilidades.ToInt(UsuarioidmaskedTextBox.Text);
                if (UsuariosBLL.Guardar(usuario))
                {
                    MessageBox.Show("Guardado con exito");
                    ValidarTextbox();
                }
            }
                
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var cc = BLL.UsuariosBLL.Buscar(Utilidades.ToInt(UsuarioidmaskedTextBox.Text));
            if (cc != null)
            {
                if (BLL.UsuariosBLL.Eliminar(cc))
                {
                    MessageBox.Show("usuario Eliminado", "<- Proceso Exitoso ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha eliminado", "<- Proceso Fallido ->", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Nuevobutton.PerformClick();
            }
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            UsuarioidmaskedTextBox.Text = textContraseña.Text = textConfirmar.Text = textUsuario.Text = "";
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            ValidarId();
            if(ValidarId())
            {
                int d = Convert.ToInt32(UsuarioidmaskedTextBox.Text);
                var cc = UsuariosBLL.Buscar(d);

                if (cc != null)
                {
                    textUsuario.Text = cc.Usuario;
                    textContraseña.Text = cc.Contraseña;
                }
            }
            
        }
        private bool ValidarTextbox()
        {
            if (string.IsNullOrEmpty(textUsuario.Text))
            {
                UsuarioerrorProvider.SetError(textUsuario, "Favor ingresar el usuario");
                return false;
            }
            if (string.IsNullOrEmpty(textContraseña.Text))
            {
                UsuarioerrorProvider.SetError(textContraseña, "Favor ingresar la contraseña");
                return false;
            }
            if (string.IsNullOrEmpty(textConfirmar.Text))
            {
                UsuarioerrorProvider.SetError(textConfirmar, "Favor ingresar la contraseña");
                return false;
            }            
            return true;
        }
        private bool ValidarId()
        {
            if (string.IsNullOrEmpty(UsuarioidmaskedTextBox.Text))
            {
                UsuarioerrorProvider.SetError(UsuarioidmaskedTextBox, "Favor ingresar el Id");
                return false;
            }
            return true;
        }
    }
}
