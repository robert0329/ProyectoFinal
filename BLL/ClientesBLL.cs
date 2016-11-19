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

                Conn.Clientes.Add(Cliente);

                Conn.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }

        public static bool Eliminar(int id)
        {
            try
            {
                Conexion db = new Conexion();
                Clientes c = db.Clientes.Find(id);
                {
                    db.Clientes.Remove(c);
                    db.SaveChanges();
                    return false;
                }
            }
            catch (Exception)
            {
                return true;
                throw;
            }
        }

        public static Clientes Buscar(int id)
        {
            var db = new Conexion();

            return db.Clientes.Find(id);
        }

        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new Conexion();

            lista = db.Clientes.ToList();

            return lista;

        }

        public static List<Clientes> GetLista(int usuarioId)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new Conexion();

            lista = db.Clientes.Where(p => p.ClienteId == usuarioId).ToList();

            return lista;

        }
    }
}
