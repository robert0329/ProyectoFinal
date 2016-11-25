using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PrestamoCliente
    {
        public int Id { get; set; }
        public int PrestamoId { get; set; }
        public int ClienteId { get; set; }
    }
}
