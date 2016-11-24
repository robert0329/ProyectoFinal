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
        public int PrestamoID { get; set; }
        public string Nombres { get; set; }
        public int CantidadCuotas { get; set; }
        public int Interes { get; set; }
        public int MontoPrestado { get; set; }
        public int Meses { get; set; }
        public string FormaDePago { get; set; }
        public string Garante { get; set; }
        public string Hasta { get; set; }
        public int Cuotas { get; set; }
        public int Total { get; set; }
        public int DiasgraciasMonatoria { get; set; }
        public int MontoDiaMonatoria { get; set; }
    }
}
