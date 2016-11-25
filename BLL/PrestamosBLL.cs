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
                Conexion db = new Conexion();
                db.Prestamos.Add(Prestamo);
                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }
        public static bool Eliminar(Prestamos id)
        {
            try
            {
                Conexion db = new Conexion();
                Prestamos c = db.Prestamos.Find(id);
                {
                    db.Prestamos.Remove(c);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return true;
                throw;
            }
        }
        public static bool Buscar(int id)
        {
            bool Retorno = false;
            try
            {
                Prestamos p = new Prestamos();
                Conexion d = new Conexion();
                p = d.Prestamos.Find(id);
                Retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return Retorno;

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
