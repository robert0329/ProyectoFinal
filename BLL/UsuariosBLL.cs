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
        public static bool Insertar(Usuarios usuarios)
        {
            bool retorno = false;
            try
            {
                Conexion re = new Conexion();
                re.Usuario.Add(usuarios);
                re.SaveChanges();
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
