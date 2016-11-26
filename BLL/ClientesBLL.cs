using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class ClientesBLL
    {
        //public static void Insertar(Clientes cliente)
        //{
        //    using (var Conn = new Conexion())
        //    {
        //        var con = Conn.clientes.Add(cliente);
        //        foreach (var pre in cliente.ListPrestamo)
        //        {
        //            Conn.Entry(pre).State = EntityState.Unchanged;
        //        }
        //        Conn.SaveChanges();
        //    }
        //}
        //public static Clientes Buscar(int id)
        //{
        //    var Cliente = new Clientes();

        //    using (var context = new Conexion())
        //    {
        //        Cliente = context.clientes.Find(id);
        //        if (Cliente != null)
        //        {
        //            Cliente.ListPrestamo.Count();
        //        }
        //    }
        //    return Cliente;
        //}
        public static bool Insertar(Clientes Cliente)
        {
            bool retorno = false;

            try
            {
                Conexion Conn = new Conexion();

                Conn.clientes.Add(Cliente);

                Conn.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }
        public static bool Eliminar(int e)
        {
            bool r = false;
            using (var db = new Conexion())
            {
                try
                {
                    Clientes c = db.clientes.Find(e);
                    db.clientes.Remove(c);
                    db.SaveChanges();
                    r = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return r;
            }
        }
        public static Clientes Buscar(int id)
        {
            var Client = new Clientes();
            var d = new Conexion();

            Client = d.clientes.Find(id);
            return Client;
        }
        public static Clientes Buscar(string Nombre)
        {
            var Client = new Clientes();
            var d = new Conexion();

            Client = d.clientes.Where(c => c.Nombre.Equals(Nombre)).FirstOrDefault();
            return Client;
        }
        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new Conexion();

            lista = db.clientes.ToList();

            return lista;

        }
        public static List<Clientes> GetLista(int usuarioId)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new Conexion();

            lista = db.clientes.Where(p => p.ClienteId == usuarioId).ToList();

            return lista;

        }
    }
}
