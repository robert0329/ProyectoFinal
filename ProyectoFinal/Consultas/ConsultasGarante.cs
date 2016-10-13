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
    public partial class ConsultasGarante : Form
    {
        public ConsultasGarante()
        {
            InitializeComponent();
        }
        public List<Garante> lista = new List<Garante>();
        

        private void DatosdataGridVieww_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(GFiltrotextBox.Text))
            {

                lista = BLL.GaranteBLL.GetLista(Utilidades.ToInt(GFiltrotextBox.Text));
            }
            else
            {
                lista = BLL.GaranteBLL.GetLista();
            }

            DatosdataGridVieww.DataSource = lista;
        }
    }
}
