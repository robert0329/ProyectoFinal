using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.VentanaReporte
{
    public partial class ReportePrestamos : Form
    {
        public int Id { get; set; }
        public ReportePrestamos()
        {
            InitializeComponent();
        }

        private void ReportePrestamos_Load(object sender, EventArgs e)
        {
            foreach (var prestamo in BLL.PrestamosBLL.GetLista(Id))
            {
                PrestamosbindingSource.Add(prestamo);
            }
            this.reportViewer.RefreshReport();
        }
    }
}
