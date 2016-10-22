using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entidades;
using BLL;
using ProyectoFinal.RegistroCliente;
using ProyectoFinal.RegistroGarantes;
using ProyectoFinal.Consultas;

namespace ProyectoFinal
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nuevoPrestarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCliente.RegistroCliente rUsuarios = new RegistroCliente.RegistroCliente();
            rUsuarios.Show();
        }

        private void consultaPrestarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultasCliente cc = new ConsultasCliente();
            cc.Show();
        }


        private void nuevoDesembolsoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoGaranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroGarante g = new RegistroGarante();
            g.Show();
        }

        private void consultaGaranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultasGarante cg = new ConsultasGarante();
            cg.Show();
        }

        private void NuevoPrestamoGaranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestamos.NuevoPrestamo NP = new Prestamos.NuevoPrestamo();
            NP.Show();
        }
    }
}
