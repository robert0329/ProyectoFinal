using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BLL
{
    public class GaranteBLL
    {
        public static bool Insertar(Garantes nuevo)
        {
            bool resultado = false;
            using (var conexion = new Conexion())
            {
                try
                {
                    if (Buscar(nuevo.GaranteId) == null)
                        conexion.garante.Add(nuevo);
                    else
                        conexion.Entry(nuevo).State = EntityState.Modified;
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
        public static bool Insertar(List<Garantes> lista)
        {
            bool resultado = false;
            using (var conexion = new Conexion())
            {
                try
                {
                    int id = BLL.PrestamosBLL.Identity();
                    foreach (var garante in lista)
                    {
                        garante.PrestamoId = id;
                    }
                    conexion.garante.AddRange(lista);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception e )
                {
                    MessageBox.Show(e.ToString());
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
        public static List<Garantes> GetLista(int prestamoId)
        {
            List<Garantes> lista = new List<Garantes>();
            using (var conexion = new Conexion())
            {
                try
                {
                    lista.AddRange(conexion.garante.Where(g => g.PrestamoId == prestamoId));
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;

        }
        public static int Identity()
        {
            int UltimoId = 0;
            SqlConnection conn = new SqlConnection(@"C:\Users\Robert\Desktop\ProyectoFinal\ProyectoFinal\Database\DataBase.mdf");
            SqlCommand comando = new SqlCommand("Select IDENT_CURRENT('Garantes')", conn);
            conn.Open();
            UltimoId = Convert.ToInt32(comando.ExecuteReader());
            conn.Close();
            return UltimoId;
        }
        public static List<Garantes> GetListaId(int PrestamosId)
        {
            List<Garantes> list = new List<Garantes>();

            var db = new Conexion();

            list = db.garante.Where(p => p.GaranteId == PrestamosId).ToList();

            return list;

        }
        public static List<Garantes> GetListaNombre(string m)
        {
            List<Garantes> lista = new List<Garantes>();

            var db = new Conexion();

            lista = db.garante.Where(p => string.Equals(p.Nombres, m)).ToList();

            return lista;

        }
    }
}
