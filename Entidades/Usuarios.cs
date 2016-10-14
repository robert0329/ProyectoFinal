using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
