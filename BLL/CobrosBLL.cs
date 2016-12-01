using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CobrosBLL
    {
        public static bool Insertar(Cobros Cobro)
        {
            bool retorno = false;
            using (var Conn = new Conexion())
            {
                try
                {
                    if (Buscar(Cobro.cobroId) == null)
                    {
                        Conn.cobros.Add(Cobro);
                    }
                    else
                    {
                        Conn.Entry(Cobro).State = EntityState.Modified;
                    }
                    Conn.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {
                    throw;
                }
                return retorno;
            }
        }
        public static Prestamos Buscar(string Nombre)
        {
            var Client = new Prestamos();
            var d = new Conexion();

            Client = d.Prestamos.Where(c => c.Nombre.Equals(Nombre)).FirstOrDefault();
            return Client;
        }
        public static Cobros Buscar(int Id)
        {
            var Cobro = new Cobros();
            using (var conexion = new Conexion())
            {
                try
                {
                    Cobro = conexion.cobros.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Cobro;
        }
        public static Prestamos Modificar(int Monto , string nombre , int Cuotas)
        {
            var Conn = new Conexion();
            var prestamo = new Prestamos();

            prestamo = Conn.Prestamos.Where(c => c.Nombre.Equals(nombre)).FirstOrDefault();
            prestamo.MontoFinal = Monto;
            prestamo.NumeroCuotas = Cuotas;
            Conn.SaveChanges();
            return prestamo;
        }      
        public static List<Cobros> GetLista()
        {
            List<Cobros> lista = new List<Cobros>();

            var db = new Conexion();

            lista = db.cobros.ToList();

            return lista;

        }
        public static List<Cobros> GetLista(string usuarioId)
        {
            List<Cobros> lista = new List<Cobros>();

            var db = new Conexion();

            lista = db.cobros.Where(p => Convert.ToString( p.cobroId) == usuarioId).ToList();

            return lista;

        }
        public static List<Prestamos> GetListaC()
        {
            List<Prestamos> lista = new List<Prestamos>();

            var db = new Conexion();

            lista = db.Prestamos.ToList();

            return lista;

        }
        public static List<Cobros> GetListaId(int PrestamosId)
        {
            List<Cobros> list = new List<Cobros>();

            var db = new Conexion();

            list = db.cobros.Where(p => p.cobroId == PrestamosId).ToList();

            return list;

        }
        public static List<Cobros> GetListaFecha(DateTime D, DateTime H)
        {
            List<Cobros> lista = new List<Cobros>();

            var db = new Conexion();

            lista = db.cobros.Where(p => p.Fecha >= D && p.Fecha <= H).ToList();

            return lista;

        }
    }
}
