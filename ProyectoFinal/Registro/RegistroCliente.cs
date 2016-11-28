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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ProyectoFinal.RegistroCliente
{
    public partial class RegistroCliente : Form
    {
        Clientes Client = new Clientes();
        public RegistroCliente()
        {
            InitializeComponent();
        }
        public void RegistroCliente_Load(object sender, EventArgs e)
        {}
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes Cliente = new Clientes();
            Cliente.Nombre = nombreTextBox.Text;
            Cliente.Apellidos = apellidosTextBox.Text;
            Cliente.Direccion = direccionTextBox.Text;
            Cliente.Telefono = telefonoMaskedTextBox.Text;
            Cliente.Cedula = cedulaMaskedTextBox.Text;
            Cliente.Sexo = sexoComboBox.Text;
            if (ValidarTextbox() && ValidarExiste(nombreTextBox.Text))
            {
                ClientesBLL.Insertar(Cliente);
                MessageBox.Show("Se Registrado Un Cliente", "<- Proceso Exitoso ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Text = direccionTextBox.Text = telefonoMaskedTextBox.Text = cedulaMaskedTextBox.Text = sexoComboBox.Text = "";
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(clienteIdMaskedTextBox.Text);
            var cc = ClientesBLL.Buscar(d);

            if (cc != null)
            {
                nombreTextBox.Text = cc.Nombre;
            }
            if (!string.IsNullOrEmpty(clienteIdMaskedTextBox.Text))
            {
                var Cliente = BLL.ClientesBLL.Buscar(Utilidades.ToInt(clienteIdMaskedTextBox.Text));
                if (Cliente != null)
                {
                    nombreTextBox.Text = Cliente.Nombre;
                    apellidosTextBox.Text = Cliente.Apellidos;
                    direccionTextBox.Text = Cliente.Direccion;
                    telefonoMaskedTextBox.Text = Cliente.Telefono;
                    cedulaMaskedTextBox.Text = Cliente.Cedula;
                    sexoComboBox.Text = Cliente.Sexo;
                }
                else
                {
                    MessageBox.Show("Este Id no contiene un cliente", "<- Busqueda Fallida ->", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var cc = BLL.ClientesBLL.Buscar(Utilidades.ToInt(clienteIdMaskedTextBox.Text));
            if (cc != null)
            {
                if (BLL.ClientesBLL.Eliminar(cc))
                {
                    MessageBox.Show("Cliente Eliminado", "<- Proceso Exitoso ->", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha eliminado", "<- Proceso Fallido ->", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor Buscar el cliente"))
            {
                LlenarClase(Client);
                if (ValidarExiste(nombreTextBox.Text))
                {
                    ClientesBLL.Modificar(Utilidades.ToInt(clienteIdMaskedTextBox.Text), Client);
                    MessageBox.Show("Actualizado con exito");
                }

            }
        }
        private bool ValidarExiste(string aux)
        {
            if (ClientesBLL.GetListaM(aux).Count() > 0)
            {
                MessageBox.Show("Este cliente ya existe." + "\n" + "Verifique los datos ingresado correctamente");
                return false;
            }
            return true;
        }
        private bool ValidarTextbox()
        {
            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                ClienteerrorProvider.SetError(nombreTextBox, "Favor ingresar el nombre");
                return false;
            }

            if (string.IsNullOrEmpty(apellidosTextBox.Text))
            {
                ClienteerrorProvider.SetError(apellidosTextBox, "Favor ingresar el apellido");
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
            if (string.IsNullOrEmpty(clienteIdMaskedTextBox.Text))
            {
                ClienteerrorProvider.SetError(clienteIdMaskedTextBox, "Ingresar el ID");
                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LlenarClase(Clientes E)
        {
            E.Nombre = nombreTextBox.Text;
            E.Apellidos = apellidosTextBox.Text;
            E.Direccion = direccionTextBox.Text;
            E.Telefono = telefonoMaskedTextBox.Text;
            E.Cedula = cedulaMaskedTextBox.Text;
            E.Sexo = sexoComboBox.Text;
        }
    }
}
