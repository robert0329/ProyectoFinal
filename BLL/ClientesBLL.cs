﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{

    public class ClientesBLL
    {
        public static bool Insertar(Clientes Cliente)
        {
            bool retorno = false;

            try
            {
                Conexion Conn = new Conexion();

                Conn.Clientes.Add(Cliente);

                Conn.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }

        public static void Eliminar(int id)
        {
            var db = new Conexion();

            Clientes Cliente = Buscar(id);

            db.Clientes.Remove(Cliente);
            db.SaveChanges();
        }

        public static Clientes Buscar(int id)
        {
            var db = new Conexion();

            return db.Clientes.Find(id);

        }

        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new Conexion();

            lista = db.Clientes.ToList();

            return lista;

        }

        public static List<Clientes> GetLista(int usuarioId)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new Conexion();

            lista = db.Clientes.Where(p => p.ClienteId == usuarioId).ToList();

            return lista;

        }
    }
}
