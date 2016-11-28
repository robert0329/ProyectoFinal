using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cobros
    {
        [Key]
        public int cobroId { get; set; }
        public int ClienteId { get; set; }
        public int PrestamoId { get; set; }
        public int NumeroCuotas { get; set; }
        public int Abono { get; set; }
        public DateTime Fecha { get; set; }
    }
}
