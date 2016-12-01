using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace ProyectoFinal.Consultas
{
    public partial class ConsultasCliente : Form
    {
        public ConsultasCliente()
        {
            InitializeComponent();
        }
        Clientes cliente = new Clientes();       
        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSeleccion();
        }
        private void Cargar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Nombre");
            FiltrocomboBox.DataSource = FiltrocomboBox.Items;
            FiltrocomboBox.DisplayMember = "ID";
            ClientedataGridView.DataSource = BLL.ClientesBLL.GetLista();

        }
        private void BuscarSeleccion()
        {
            if (FiltrocomboBox.SelectedIndex == 0)
                ClientedataGridView.DataSource = ClientesBLL.GetListaId(Utilidades.ToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 1)
                ClientedataGridView.DataSource = ClientesBLL.GetListaNombre(FiltrotextBox.Text);
        }
        private bool validar()
        {
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }

            if (FiltrocomboBox.SelectedIndex == 1 && ClientesBLL.GetListaNombre(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            if (FiltrocomboBox.SelectedIndex == 0 && ClientesBLL.GetListaId(Utilidades.ToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            BuscarerrorProvider.Clear();
            return true;
        }
        private void ConsultasCliente_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
