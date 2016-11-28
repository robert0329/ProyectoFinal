using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Insertar(Clientes Cliente)
        {
            bool resultado = false;
            using (var conexion = new Conexion())
            {
                try
                {
                    conexion.clientes.Add(Cliente);
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
        public static bool Eliminar(Clientes existente)
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
        public static Clientes Buscar(int id)
        {
            var Cliente = new Clientes();
            using (var conexion = new Conexion())
            {
                try
                {
                    Cliente = conexion.clientes.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Cliente;
        }
        public static Clientes Buscar(string Nombre)
        {
            var Cliente = new Clientes();
            using (var conexion = new Conexion())
            {
                try
                {
                    Cliente = conexion.clientes.Where(c => c.Nombre.Equals(Nombre)).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Cliente;
        }
        public static List<Clientes> GetLista()
        {
            var lista = new List<Clientes>();
            using (var conexion = new Conexion())
            {
                try
                {
                    lista = conexion.clientes.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;

        }
        public static List<Clientes> GetLista(int usuarioId)
        {
            List<Clientes> lista = new List<Clientes>();
            using (var conexion = new Conexion())
            {
                try
                {
                    lista = conexion.clientes.Where(p => p.ClienteId == usuarioId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;

        }
        public static List<Clientes> GetListaM(string aux)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new Conexion();

            lista = db.clientes.Where(p => p.Nombre== aux).ToList();

            return lista;

        }
        public static void Modificar(int id, Clientes cliente)
        {
            using (var db = new Conexion())
            {
                try
                {
                    Clientes cc = db.clientes.Find(id);
                    cc.Nombre = cliente.Nombre;
                    cc.Apellidos = cliente.Apellidos;
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
