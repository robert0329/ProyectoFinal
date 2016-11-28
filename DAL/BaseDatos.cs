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
        public virtual DbSet<Clientes> clientes { get; set; }
        public virtual DbSet<Garantes> garante { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Prestamos> Prestamos { get; set; }
        public virtual DbSet<Cobros> cobros { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Prestamos>()
        //        .HasMany<Clientes>(g => g.LClientes)
        //        .WithMany(e => e.ListPrestamos)
        //        .Map(Ge =>
        //        {
        //            Ge.MapLeftKey("PrestamoId");
        //            Ge.MapRightKey("ClienteId");
        //            Ge.ToTable("PrestamoClientes"); 
        //        });
        //}
    }
}
