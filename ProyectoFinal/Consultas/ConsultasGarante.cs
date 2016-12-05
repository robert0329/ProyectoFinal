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
    public partial class ConsultasGarante : Form
    {
        public ConsultasGarante()
        {
            InitializeComponent();
        }
        public List<Garantes> lista = new List<Garantes>();
        private void ConsultasGarante_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSeleccion();
        }
        private void Cargar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Nombre");
            FiltrocomboBox.Items.Insert(2, "Todo");
            FiltrocomboBox.DataSource = FiltrocomboBox.Items;
            FiltrocomboBox.DisplayMember = "ID";
            //GarantedataGridView.DataSource = BLL.ClientesBLL.GetLista();
            
        }
        private void BuscarSeleccion()
        {
            if (FiltrocomboBox.SelectedIndex == 0)
                GarantedataGridView.DataSource = GaranteBLL.GetListaId(Utilidades.ToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 1)
                GarantedataGridView.DataSource = GaranteBLL.GetListaNombre(FiltrotextBox.Text);
            if (FiltrocomboBox.SelectedIndex == 2)
                GarantedataGridView.DataSource = GaranteBLL.GetLista();
        }
        private bool validar()
        {
            if (FiltrocomboBox.Text != "Todo")
            {

                if (string.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    errorProvider1.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                    return false;
                }

                if (FiltrocomboBox.SelectedIndex == 1 && GaranteBLL.GetListaNombre(FiltrotextBox.Text).Count == 0)
                {
                    MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                    return false;

                }
                if (FiltrocomboBox.SelectedIndex == 0 && GaranteBLL.GetListaId(Utilidades.ToInt(FiltrotextBox.Text)).Count == 0)
                {
                    MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                    return false;

                }
            }
            errorProvider1.Clear();
            return true;
        }
    }
}
