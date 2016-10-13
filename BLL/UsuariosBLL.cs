using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{

    public class UsuariosBll
    {
        public static bool Insertar(Usuarios usuario)
        {
            bool retorno = false;

            try
            {
                Conexion Conn = new Conexion();

                Conn.Usuario.Add(usuario);

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

            Usuarios usuario = Buscar(id);

            db.Usuario.Remove(usuario);
            db.SaveChanges();
        }

        public static Usuarios Buscar(int id)
        {
            var db = new Conexion();

            return db.Usuario.Find(id);

        }

        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new Conexion();

            lista = db.Usuario.ToList();

            return lista;

        }

        public static List<Usuarios> GetLista(int usuarioId)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new Conexion();

            lista = db.Usuario.Where(p => p.UsuarioId == usuarioId).ToList();

            return lista;

        }
    }
}
