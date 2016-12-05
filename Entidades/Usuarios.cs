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
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public Usuarios(int UsuarioId ,string Usuario , string contraseña)
        {
            this.UsuarioId = UsuarioId;
            this.Usuario = Usuario;
            this.Contraseña = contraseña;
        }
        public Usuarios()
        {

        }
    }
}
