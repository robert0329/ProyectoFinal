using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            string dateTime = "01/08/2008 14:50:50.42"; DateTime dt = Convert.ToDateTime(dateTime);
            Prestamos p = new Prestamos();
            p.PrestamoID = 01;
            p.Nombres = "q";
            p.CantidadCuotas = 1;
            p.Interes = 1;
            p.MontoPrestado = 1;
            p.Meses = 1;
            p.FormaDePago = "Prestado";
            p.Garante = "Prestado";
            p.Hasta  = dt;
            p.DiasgraciasMonatoria = 1;
            p.MontoDiaMonatoria = 1;
            p.Cuotas = 1;
            p.Total = 1;

            Assert.IsTrue(PrestamosBLL.Guardar(p));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Prestamos c = new Prestamos();
            Assert.IsTrue(PrestamosBLL.Eliminar(c));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsTrue(PrestamosBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsTrue(PrestamosBLL.GetLista().Count >= 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsTrue(PrestamosBLL.GetLista(1).Count >= 0);
        }
    }
}