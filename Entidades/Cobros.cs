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
        public string Nombres { get; set; }
        public int Deuda { get; set; }
        public int UltimoPago { get; set; }
    }
}
