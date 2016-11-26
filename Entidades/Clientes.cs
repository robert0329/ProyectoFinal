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
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Sexo { get; set; }
        public virtual List<Prestamos> ListPrestamo { get; set; }
        public Clientes(int ClienteId, string Nombres, string Apellidos, string Direccion, string Telefono, string Cedula)
        {
            this.ClienteId = ClienteId;
            this.Nombre = Nombres;
            this.Apellidos = Apellidos;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Cedula = Cedula;
        }
        public Clientes()
        {

        }
    }
}
