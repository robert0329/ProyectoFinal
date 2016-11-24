using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CobrosBLL
    {
        public static Prestamos Buscar(string Nombre)
        {
            var Client = new Prestamos();
            var d = new Conexion();

            Client = d.Prestamos.Where(c => c.Nombres.Equals(Nombre)).FirstOrDefault();
            return Client;
        }
        public static Prestamos Modificar(int Monto , string nombre)
        {
            var Conn = new Conexion();
            var prestamo = new Prestamos();

            prestamo = Conn.Prestamos.Where(c => c.Nombres.Equals(nombre)).FirstOrDefault();
            prestamo.MontoPrestado = Monto;
                Conn.SaveChanges();
            return prestamo;
        }
        public static bool Insertar(Cobros cobro)
        {
            bool retorno = false;

            try
            {
                Conexion Conn = new Conexion();

                Conn..Add(cobro);

                Conn.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }
        public static List<Prestamos> GetLista()
        {
            List<Prestamos> lista = new List<Prestamos>();

            var db = new Conexion();

            lista = db.Prestamos.ToList();

            return lista;

        }

        public static List<Prestamos> GetLista(string usuarioId)
        {
            List<Prestamos> lista = new List<Prestamos>();

            var db = new Conexion();

            lista = db.Prestamos.Where(p => Convert.ToString( p.PrestamoID) == usuarioId).ToList();

            return lista;

        }
    }
}
