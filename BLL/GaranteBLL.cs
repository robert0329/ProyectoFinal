using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class GaranteBLL
    {
        public static bool Guardar(Garante garante)
        {
            bool retorno = false;

            try
            {
                Conexion ConnG = new Conexion();

                ConnG.garante.Add(garante);

                ConnG.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }
        public static void EliminarG(int id)
        {
            var db = new Conexion();

            Garante Ug = Busqueda(id);

            db.garante.Remove(Ug);
            db.SaveChanges();
        }

        public static Garante Busqueda(int id)
        {
            var db = new Conexion();

            return db.garante.Find(id);

        }

        public static List<Garante> GetLista()
        {
            List<Garante> lista = new List<Garante>();

            var db = new Conexion();

            lista = db.garante.ToList();

            return lista;

        }

        public static List<Garante> GetLista(int GaranteId)
        {
            List<Garante> list = new List<Garante>();

            var db = new Conexion();

            list = db.garante.Where(p => p.GaranteId == GaranteId).ToList();

            return list;

        }
    }
}
