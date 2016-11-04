using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Prestamos
    {
        [Key]

        public string Nombre { get; set; }
        public int PrestamoID { get; set; }
        public int CantidadCuotas { get; set; }
        public int Interes { get; set; }
        public int MontoPrestado { get; set; }
        public int Meses { get; set; }
        public string FormaDePago { get; set; }
        public string Garante { get; set; }
        public DateTime Hasta { get; set; }
        public Double Cuotas { get; set; }
        public Double Total { get; set; }
        public int MesesgraciasMonatoria { get; set; }
        public int DiasgraciasMonatoria { get; set; }
        public int MontoMesesMonatoria { get; set; }
        public int MontoDiaMonatoria { get; set; }
    }
}
