using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Garantes
    {
        [Key]
        public int GaranteId { get; set; }

        public string Nombres { get; set; }
        
        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Cedula { get; set; }

        public int PrestamoId { get; set; }

        public string Sexo { get; set; }
        public Garantes(int GaranteId , string Nombre , string Direccion , string Telefono , string Cedula , string Sexo)
        {
            this.GaranteId = GaranteId;
            this.Nombres = Nombres;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Cedula = Cedula;
            this.Sexo = Sexo;
        }
        public Garantes()
        {
        }
    }
}
