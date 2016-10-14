using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        public string Nombre { get; set; }

        public string Apellido{ get; set; }

        public string Direccion { get; set; }
        
        public string Telefono { get; set; }

        public string Cedula { get; set; }
    }

}
