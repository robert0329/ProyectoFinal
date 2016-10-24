using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class PrestamosBLL
    {
        public static bool Guardar(Prestamos Prestamo)
        {
            bool retorno = false;

            try
            {
                Conexion Conn = new Conexion();

                Conn.Prestamos.Add(Prestamo);

                Conn.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }
        public static void Eliminar(int id)
        {
            var db = new Conexion();

            Prestamos Prestamo = Busqueda(id);

            db.Prestamos.Remove(Prestamo);
            db.SaveChanges();
        }

        public static Prestamos Busqueda(int id)
        {
            var db = new Conexion();

            return db.Prestamos.Find(id);

        }

        public static List<Prestamos> GetLista()
        {
            List<Prestamos> lista = new List<Prestamos>();

            var db = new Conexion();

            lista = db.Prestamos.ToList();

            return lista;
        }


        public static List<Prestamos> GetLista(int PrestamosId)
        {
            List<Prestamos> list = new List<Prestamos>();

            var db = new Conexion();

            list = db.Prestamos.Where(p => p.PrestamoID == PrestamosId).ToList();

            return list;

        }
    }
}
