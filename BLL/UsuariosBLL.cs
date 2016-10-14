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
                Conexion Conn = new Conexion();

                Conn.Usuarios.Add(usuario);

                Conn.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }
    }
}
