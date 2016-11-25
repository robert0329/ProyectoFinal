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
        public static bool Guardar(Garantes garante)
        {
            bool retorno = false;
            try
            {
                Conexion db = new Conexion();
                db.garante.Add(garante);
                db.SaveChanges();

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
                    Garantes c = db.garante.Find(e);
                    db.garante.Remove(c);
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
        public static Garantes Buscar(int id)
        {
            var Garant = new Garantes();
            var d = new Conexion();

            Garant = d.garante.Find(id);
            return Garant;
        }
        public static List<Garantes> GetLista()
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new Conexion();

            lista = db.garante.ToList();

            return lista;

        }
        public static List<Garantes> GetLista(int GaranteId)
        {
            List<Garantes> list = new List<Garantes>();

            var db = new Conexion();

            list = db.garante.Where(p => p.GaranteId == GaranteId).ToList();

            return list;

        }
    }
}
