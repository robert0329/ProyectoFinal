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
    public partial class ReportPrestamos : Form
    {
        public ReportPrestamos()
        {
            InitializeComponent();
        }

        private void ReportPrestamos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
