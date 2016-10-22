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
        public List<Clientes> lista = new List<Clientes>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FiltrotextBox.Text))
            {

                lista = BLL.ClientesBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text));
            }
            else
            {
                lista = BLL.ClientesBLL.GetLista();
            }

            ConsultaClientedataGridView.DataSource = lista;
        }
        
        private void FiltrotextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
