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
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool resultado = false;
            using (var conexion = new Conexion())
            {
                try
                {
                    var c = Buscar(usuario.UsuarioId);
                    if (c == null)
                        conexion.Usuarios.Add(usuario);
                    else
                        conexion.Entry(usuario).State = EntityState.Modified;
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
        public static bool Eliminar(Usuarios existente)
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
        public static Usuarios Buscar(int Id)
        {
            var cc = new Usuarios();
            using (var conexion = new Conexion())
            {
                try
                {
                    cc = conexion.Usuarios.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return cc;
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
