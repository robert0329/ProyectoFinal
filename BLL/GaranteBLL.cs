using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class GaranteBLL
    {
        public static bool Insertar(Garantes gar)
        {
            bool resultado = false;
            using (var conexion = new Conexion())
            {
                try
                {
                    conexion.garante.Add(gar);
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
        public static bool Eliminar(Garantes existente)
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
        public static Garantes Buscar(int id)
        {
            var gar = new Garantes();
            using (var conexion = new Conexion())
            {
                try
                {
                    gar = conexion.garante.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return gar;
        }
        public static Garantes Buscar(string Nombre)
        {
            var gar = new Garantes();
            using (var conexion = new Conexion())
            {
                try
                {
                    gar = conexion.garante.Where(c => c.Nombres.Equals(Nombre)).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return gar;
        }
        public static List<Garantes> GetLista()
        {
            var lista = new List<Garantes>();
            using (var conexion = new Conexion())
            {
                try
                {
                    lista = conexion.garante.ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return lista;

        }
        public static List<Garantes> GetLista(int usuarioId)
        {
            List<Garantes> lista = new List<Garantes>();
            using (var conexion = new Conexion())
            {
                try
                {
                    lista = conexion.garante.Where(p => p.GaranteId == usuarioId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;

        }
        public static List<Garantes> GetListaM(string aux)
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new Conexion();

            lista = db.garante.Where(p => p.Nombres == aux).ToList();

            return lista;

        }
        public static void Modificar(int id, Garantes cliente)
        {
            using (var db = new Conexion())
            {
                try
                {
                    Garantes cc = db.garante.Find(id);
                    cc.Nombres = cliente.Nombres;
                    cc.Direccion = cliente.Direccion;
                    cc.Telefono = cliente.Telefono;
                    cc.Cedula = cliente.Cedula;
                    cc.Sexo = cliente.Sexo;
                    db.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
