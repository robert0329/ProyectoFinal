using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Data.Entity;

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

        //public static void Insertar(Prestamos Prestamo)
        //{
        //    using (var Conn = new Conexion())
        //    {
        //        var con = Conn.Prestamos.Add(Prestamo);
        //        foreach(var pre in Prestamo.LClientes)
        //        {
        //            Conn.Entry(pre).State = EntityState.Unchanged;
        //        }
        //        Conn.SaveChanges();
        //    }
        //}
        //public static Prestamos Buscar(int id)
        //{
        //    var prestamo = new Prestamos();

        //    using (var context = new Conexion())
        //    {
        //        prestamo = context.Prestamos.Find(id);
        //        if(prestamo != null)
        //        {
        //            prestamo.LClientes.Count();
        //        } 
        //    }
        //    return prestamo;
        //}
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
        public static List<Prestamos> GetListaId(int PrestamosId)
        {
            List<Prestamos> list = new List<Prestamos>();

            var db = new Conexion();

            list = db.Prestamos.Where(p => p.PrestamoID == PrestamosId).ToList();

            return list;

        }
        public static List<Prestamos> GetListaNombre(string m)
        {
            List<Prestamos> lista = new List<Prestamos>();

            var db = new Conexion();

            lista = db.Prestamos.Where(p => string.Equals(p.Nombre, m)).ToList();

            return lista;

        }
        public static List<Prestamos> GetListaFecha(DateTime D, DateTime H)
        {
            List<Prestamos> lista = new List<Prestamos>();

            var db = new Conexion();

            lista = db.Prestamos.Where(p => p.Fecha >= D && p.Fecha <= H).ToList();

            return lista;

        }
        public static Prestamos Buscar(string Nombre)
        {
            var Client = new Prestamos();
            var d = new Conexion();

            Client = d.Prestamos.Where(c => c.Nombre.Equals(Nombre)).FirstOrDefault();
            return Client;
        }
    }
}
