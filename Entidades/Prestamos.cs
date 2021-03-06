﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Prestamo { get; set; }
        public int Interes { get; set; }
        public int Meses { get; set; }
        public string FormaPago { get; set; }
        public DateTime Fecha { get; set; }
        public int GaranteId { get; set; }
        public int MontoFinal{ get; set; }
        public Double InteresFinal { get; set; }
        public int NumeroCuotas { get; set; }
        public Double valorCuotas { get; set; }

        public Prestamos(int PrestamoId, int ClienteId, string Nombre, string Apellidos, int Prestamo, int Interes, int Meses,
            string FormaPago, DateTime Fecha, int GaranteId, int MontoFinal, Double InteresFinal, int NumeroCuotas, Double ValorCuotas)
        {
            this.PrestamoId = this.PrestamoId;
            this.ClienteId = ClienteId;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Prestamo = Prestamo;
            this.Interes = Interes;
            this.Meses = Meses;
            this.FormaPago = FormaPago;
            this.Fecha = Fecha;
            this.GaranteId = GaranteId;
            this.MontoFinal = MontoFinal;
            this.InteresFinal = InteresFinal;
            this.NumeroCuotas = NumeroCuotas;
            this.valorCuotas = ValorCuotas;
        }
        public Prestamos()
        {
        }
    }
}
