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
        public static bool Eliminar(Garantes e)
        {
            try
            {
                Conexion db = new Conexion();
                Garantes c = db.garante.Find(e);
                {
                    db.garante.Remove(c);
                    db.SaveChanges();
                    return false;
                }
            }catch(Exception)
            {
                return true;
                throw;
            }

        }

        public static bool Buscar(int id)
        {
            bool Retorno = false;
            try
            {
                Garantes p = new Garantes();
                Conexion d = new Conexion();
                p = d.garante.Find(id);
                Retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return Retorno;

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
