using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CobrosBLL
    {
        public static Prestamos Buscar(string Nombre)
        {
            var Client = new Prestamos();
            var d = new Conexion();

            Client = d.Prestamos.Where(c => c.Nombre.Equals(Nombre)).FirstOrDefault();
            return Client;
        }
        public static Prestamos Modificar(int Monto , string nombre)
        {
            var Conn = new Conexion();
            var prestamo = new Prestamos();

            prestamo = Conn.Prestamos.Where(c => c.Nombre.Equals(nombre)).FirstOrDefault();
            prestamo.MontoPrestado = Monto;
            Conn.SaveChanges();
            return prestamo;
        }
        public static bool Insertar(Cobros cobro , string nombre , int Deuda , int Monto)
        {
            bool retorno = false;
            using (var Conn = new Conexion())
            {
                try
                {
                    var cc = new Cobros();
                    cc = Conn.cobros.Where(c => c.Nombres.Equals(nombre)).FirstOrDefault();

                    if (cc != null)
                    {
                        cc = Conn.cobros.Where(c => c.Nombres.Equals(nombre)).FirstOrDefault();
                        cc.Deuda = Deuda;
                        cc.Nombres = nombre;
                        cc.UltimoPago = Monto;
                        Conn.SaveChanges();
                    }
                    else
                    {
                        cc = Conn.cobros.Add(cobro);
                        Conn.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return retorno;
            }    
        }
        public static List<Cobros> GetLista()
        {
            List<Cobros> lista = new List<Cobros>();

            var db = new Conexion();

            lista = db.cobros.ToList();

            return lista;

        }
        public static List<Cobros> GetLista(string usuarioId)
        {
            List<Cobros> lista = new List<Cobros>();

            var db = new Conexion();

            lista = db.cobros.Where(p => Convert.ToString( p.cobroId) == usuarioId).ToList();

            return lista;

        }
    }
}
