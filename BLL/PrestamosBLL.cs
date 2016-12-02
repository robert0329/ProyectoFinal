using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Data.Entity;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BLL
{
    public class PrestamosBLL
    {
        public static bool Guardar(Prestamos Prestamo)
        {
            bool retorno = false;
            try
            {
                Conexion db = new Conexion();
                db.Prestamos.Add(Prestamo);
                db.SaveChanges();

                retorno = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            return retorno;
        }
        public static bool Eliminar(Prestamos id)
        {
            try
            {
                Conexion db = new Conexion();
                Prestamos c = db.Prestamos.Find(id);
                {
                    db.Prestamos.Remove(c);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return true;
                throw;
            }
        }
        public static Prestamos Buscar(int id)
        {
            Prestamos Retorno = null;
            try
            {
                Conexion d = new Conexion();
                Retorno = d.Prestamos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return Retorno;

        }
        public static List<Prestamos> GetLista()
        {
            List<Prestamos> lista = new List<Prestamos>();

            var db = new Conexion();

            lista = db.Prestamos.ToList();

            return lista;
        }
        public static List<Prestamos> GetListaId(int PrestamosId)
        {
            List<Prestamos> list = new List<Prestamos>();

            var db = new Conexion();

            list = db.Prestamos.Where(p => p.PrestamoId == PrestamosId).ToList();

            return list;

        }
        public static List<Prestamos> GetListaIdD(int PrestamosId)
        {
            List<Prestamos> list = new List<Prestamos>();

            var db = new Conexion();

            list = db.Prestamos.Where(p => p.ClienteId == PrestamosId).ToList();

            return list;

        }
        public static List<Prestamos> GetListaNombre(string m)
        {
            List<Prestamos> lista = new List<Prestamos>();

            var db = new Conexion();

            lista = db.Prestamos.Where(p => string.Equals(p.Nombre, m)).ToList();

            return lista;

        }
        public static List<Prestamos> GetListaFecha(DateTime D, DateTime H)
        {
            List<Prestamos> lista = new List<Prestamos>();

            var db = new Conexion();

            lista = db.Prestamos.Where(p => p.Fecha >= D && p.Fecha <= H).ToList();

            return lista;

        }
        public static int Identity()
        {
            int UltimoId = 0;
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Robert\Desktop\ProyectoFinal\ProyectoFinal\Database\DataBase.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand comando = new SqlCommand("Select IDENT_CURRENT('Prestamos')", conn);
            conn.Open();
            UltimoId = Convert.ToInt32(comando.ExecuteScalar());
            conn.Close();
            return UltimoId;
        }
    }
}
