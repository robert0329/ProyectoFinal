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
        public static bool Insertar(Clientes nuevo)
        {
            bool resultado = false;
            using (var conexion = new Conexion())
            {
                try
                {
                    if (Buscar(nuevo.ClienteId) == null)
                        conexion.clientes.Add(nuevo);
                    else
                        conexion.Entry(nuevo).State = EntityState.Modified;
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return resultado;
        }
        public static bool Eliminar(Clientes existente)
        {
            bool resultado = false;
            using (var conexion = new Conexion())
            {
                try
                {
                    conexion.Entry(existente).State = EntityState.Deleted;
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return resultado;
        }
        public static Clientes Buscar(int Id)
        {
            var cc= new Clientes();
            using (var conexion = new Conexion())
            {
                try
                {
                    cc = conexion.clientes.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return cc;
        }
        public static Clientes Buscar(string Nombre)
        {
            var Cliente = new Clientes();
            using (var conexion = new Conexion())
            {
                try
                {
                    Cliente = conexion.clientes.Where(c => c.Nombre.Equals(Nombre)).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Cliente;
        }
        public static List<Clientes> GetLista()
        {
            var lista = new List<Clientes>();
            using (var conexion = new Conexion())
            {
                try
                {
                    lista = conexion.clientes.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;

        }
        public static List<Clientes> GetListaId(int PrestamosId)
        {
            List<Clientes> list = new List<Clientes>();

            var db = new Conexion();

            list = db.clientes.Where(p => p.ClienteId == PrestamosId).ToList();

            return list;

        }
        public static List<Clientes>GetListaNombre(string m)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new Conexion();

            lista = db.clientes.Where(p => string.Equals(p.Nombre, m)).ToList();

            return lista;

        }
        
    }
}

