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

namespace ProyectoFinal.Consultas
{
    public partial class ConsultasCliente : Form
    {
        public ConsultasCliente()
        {
            InitializeComponent();
        }
        public List<Usuarios> lista = new List<Usuarios>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FiltrotextBox.Text))
            {

                lista = BLL.UsuariosBll.GetLista(Utilidades.ToInt(FiltrotextBox.Text));
            }
            else
            {
                lista = BLL.UsuariosBll.GetLista();
            }

            DatosdataGridView.DataSource = lista;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void FiltrotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DatosdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CamposComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
