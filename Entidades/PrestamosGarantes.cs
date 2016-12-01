using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PrestamosGarante
    {
        public int PrestamosGaranteId { get; set; }
        public int PrestamoId{ get; set; }
        public int GaranteId { get; set; }
    }
}
