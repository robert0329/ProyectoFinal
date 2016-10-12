using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class UsuariosGarante
    {
        [Key]
        public string NombreGarante{ get; set; }

        public string DireccionGarante { get; set; }

        public string TelefonoGarante { get; set; }

        public int CedulaGarante { get; set; }
    }
}
