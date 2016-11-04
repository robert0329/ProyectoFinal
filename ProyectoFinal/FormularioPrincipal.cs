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
        private void nuevoPrestarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCliente.RegistroCliente rUsuarios = new RegistroCliente.RegistroCliente();
            rUsuarios.Show();
        }
        private void nuevoDesembolsoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void nuevoGaranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroGarante g = new RegistroGarante();
            g.Show();
        }
        private void nuevoPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestamos.NuevoPrestamo NP = new Prestamos.NuevoPrestamo();
            NP.Show();
        }
        private void consultaPrestarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConsultasCliente cc = new ConsultasCliente();
            cc.Show();
        }
        private void consultaGaranteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConsultasGarante cg = new ConsultasGarante();
            cg.Show();
        }
    }
}
