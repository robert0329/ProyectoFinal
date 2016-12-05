using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Consultas
{
    public partial class ConsultaCobros : Form
    {
        public ConsultaCobros()
        {
            InitializeComponent();
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSeleccion();
        }
        private void Cargar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Fecha de ingreso");
            FiltrocomboBox.Items.Insert(2, "Todo");
            FiltrocomboBox.DataSource = FiltrocomboBox.Items;
            FiltrocomboBox.DisplayMember = "ID";
            //CobrosdataGridView.DataSource = CobrosBLL.GetLista();

        }
        private void BuscarSeleccion()
        {
            if (FiltrocomboBox.SelectedIndex == 0)
                CobrosdataGridView.DataSource = CobrosBLL.GetListaId(Utilidades.ToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 1)
                CobrosdataGridView.DataSource = CobrosBLL.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
            if (FiltrocomboBox.SelectedIndex == 2)
                CobrosdataGridView.DataSource = CobrosBLL.GetLista();
        }
        private bool validar()
        {
            if (FiltrocomboBox.Text != "Todo")
            {
                if (FiltrocomboBox.SelectedIndex == 1)
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

                if (FiltrocomboBox.SelectedIndex == 0 && CobrosBLL.GetListaId(Utilidades.ToInt(FiltrotextBox.Text)).Count == 0)
                {
                    MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                    return false;
                }
            }
            BuscarerrorProvider.Clear();
            return true;
        }
        private void ConsultaCobros_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
