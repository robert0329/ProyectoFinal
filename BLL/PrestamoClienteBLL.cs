using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PrestamoClienteBLL
    {
        public static bool Guardar(PrestamoCliente student)
        {
            bool retorno = false;
            try
            {
                Conexion db = new Conexion();
                db.prestamoCliente.Add(student);
                db.SaveChanges();

                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }
        public static List<PrestamoCliente> GetLis(int ClienteId)
        {
            var lista = new List<PrestamoCliente>();
            using (var conexion = new Conexion())
            {
                try
                {
                    lista = conexion.prestamoCliente.Where(ge => ge.ClienteId == ClienteId).ToList();
                }
                catch (Exception)
                {
                }
            }
            return lista;
        }
        public static List<PrestamoCliente> GetLista()
        {
            List<PrestamoCliente> lista = new List<PrestamoCliente>();
            var db = new Conexion();

            lista = db.prestamoCliente.ToList();
            return lista;
        }
    }
}
