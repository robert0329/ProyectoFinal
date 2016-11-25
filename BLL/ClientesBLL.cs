using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{

    public class ClientesBLL
    {
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
