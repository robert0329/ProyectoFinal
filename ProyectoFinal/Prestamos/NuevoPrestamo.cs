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
using DAL;

namespace ProyectoFinal.Prestamos
{
    public partial class NuevoPrestamo : Form
    {
        public List<Garantes> lista = new List<Garantes>();
        public NuevoPrestamo()
        {
            InitializeComponent();
        }
        private void ListarGarante()
        {
            Conexion conn = new Conexion();
            var lista = conn.garante.ToList();
            if (lista.Count > 0)
            {
                GarantecomboBox.DataSource = lista;
                GarantecomboBox.DisplayMember = "Nombres";
            }
        }
        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            ListarGarante();
        }
    }
}
