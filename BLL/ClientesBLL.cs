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

        public static bool Buscar(int id)
        {
            bool Retorno = false;
            using (var d = new Conexion())
            {
                try
                {
                    Clientes p = new Clientes();
                    p = d.clientes.Find(id);
                    Retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return Retorno;
            }
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
