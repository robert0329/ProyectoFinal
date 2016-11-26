using System;
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
        public int PrestamoID { get; set; }
        public string Nombres { get; set; }
        public int CantidadCuotas { get; set; }
        public int Interes { get; set; }
        public int MontoPrestado { get; set; }
        public int Meses { get; set; }
        public string FormaDePago { get; set; }
        public string Garante { get; set; }
        public string Hasta { get; set; }
        public int Cuotas { get; set; }
        public int Total { get; set; }
        public int DiasgraciasMonatoria { get; set; }
        public int MontoDiaMonatoria { get; set; }
        public virtual List<Clientes> LClientes { get; set; }
        public Prestamos(int PrestamoID,string Nombres ,int CantidadCuotas, int Interes, int MontoPrestado ,int Meses ,string FormaDePago, string Garante, string Hasta,  int Total,int DiasgraciasMonatoria,int MontoDiaMonatoria)
        {
            this.PrestamoID = PrestamoID;
            this.Nombres = Nombres;
            this.CantidadCuotas = CantidadCuotas;
            this.Interes = Interes;
            this.MontoPrestado = MontoPrestado;
            this.Meses = Meses;
            this.FormaDePago = FormaDePago;
            this.Garante = Garante;
            this.Hasta = Hasta;
            this.Total = Total;
            this.DiasgraciasMonatoria = DiasgraciasMonatoria;
            this.MontoDiaMonatoria = MontoDiaMonatoria;
        }
        public Prestamos()
        {

        }
    }
}
