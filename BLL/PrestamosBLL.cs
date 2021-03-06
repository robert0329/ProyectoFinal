﻿using System;
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
        public static bool Insertar(Prestamos nuevo)
        {
            bool resultado = false;
            using (var conexion = new Conexion())
            {
                try
                {
                    var c = Buscar(nuevo.PrestamoId);
                    if (c == null)
                        conexion.Prestamos.Add(nuevo);
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
        public static bool Eliminar(string nombre)
        {
            try
            {
                Conexion db = new Conexion();
                Prestamos Pre = db.Prestamos.Where(c => c.Nombre.Equals(nombre)).FirstOrDefault();
                {
                    db.Prestamos.Remove(Pre);
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
        public static Prestamos Buscar(string Nombre)
        {
            var Pre = new Prestamos();
            using (var conexion = new Conexion())
            {
                try
                {
                    Pre = conexion.Prestamos.Where(c => c.Nombre.Equals(Nombre)).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Pre;
        }
        public static List<Prestamos> GetLista()
        {
            List<Prestamos> lista = new List<Prestamos>();

            var db = new Conexion();

            lista = db.Prestamos.ToList();

            return lista;
        }
        public static List<Prestamos> GetLista(int Id)
        {
            var lista = new List<Prestamos>();
            using (var conexion = new Conexion())
            {
                try
                {
                    lista.AddRange(conexion.Prestamos.Where(c => c.PrestamoId == Id));
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
        public static List<Prestamos> GetListaId(int PrestamosId)
        {
            List<Prestamos> list = new List<Prestamos>();

            var db = new Conexion();

            list = db.Prestamos.Where(p => p.PrestamoId == PrestamosId).ToList();

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
