using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool retorno = false;
            try
            {
                Conexion db = new Conexion();
                db.Usuarios.Add(usuario);
                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }
        public static List<Usuarios> GetListaNombreUsuario(string Usuario)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Conexion db = new Conexion();
            lista = db.Usuarios.Where(p => p.Usuario == Usuario).ToList();
            return lista;
        }

        public static List<Usuarios> GetContrasena(string contraseña)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Conexion db = new Conexion();
            lista = db.Usuarios.Where(p => p.Contraseña == contraseña).ToList();
            return lista;
        }

    }
}
