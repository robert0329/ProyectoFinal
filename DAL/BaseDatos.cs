using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class Conexion : DbContext
    {
        public Conexion() : base("name=ConStr")
        {

        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Garantes> garante { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Prestamos> Prestamos { get; set; }
    }
    
}
