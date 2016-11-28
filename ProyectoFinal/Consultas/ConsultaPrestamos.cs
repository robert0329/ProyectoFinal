using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal;

namespace ProyectoFinal.Consultas
{
    public partial class ConsultaPrestamos : Form
    {
        Utilidades Util = new Utilidades();
        Clientes cliente = new Clientes();

        public ConsultaPrestamos()
        {
            InitializeComponent();
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSeleccion();
        }
        private void ConsultaPrestamos_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Nombre");
            FiltrocomboBox.Items.Insert(2, "Fecha de ingreso");
            FiltrocomboBox.DataSource = FiltrocomboBox.Items;
            FiltrocomboBox.DisplayMember = "ID";
            PrestamosdataGridView.DataSource = PrestamosBLL.GetLista();

        }
        private void BuscarSeleccion()
        {
            if (FiltrocomboBox.SelectedIndex == 0)
                PrestamosdataGridView.DataSource = PrestamosBLL.GetListaId(Util.StringToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 1)
                PrestamosdataGridView.DataSource = PrestamosBLL.GetListaNombre(FiltrotextBox.Text);
            if (FiltrocomboBox.SelectedIndex == 2)
                PrestamosdataGridView.DataSource = PrestamosBLL.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
        }
        private bool validar()
        {

            if (FiltrocomboBox.SelectedIndex == 3)
            {
                if (DesdeDateTimePicke.Value == HastadateTimePicker.Value)
                {
                    MessageBox.Show("Favor colocar un intervalo entre las dos fechas");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }

            if (FiltrocomboBox.SelectedIndex == 1 && PrestamosBLL.GetListaNombre(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            if (FiltrocomboBox.SelectedIndex == 0 && PrestamosBLL.GetListaId(Util.StringToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            BuscarerrorProvider.Clear();


            return true;
        }

    }
}
