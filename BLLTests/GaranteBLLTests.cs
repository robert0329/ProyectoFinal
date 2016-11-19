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
    public class GaranteBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Garantes garante = new Garantes();
            Assert.IsTrue(GaranteBLL.Guardar(garante));
        }

        [TestMethod()]
        public void EliminarGTest()
        {
            Garantes c = new Garantes();
            Assert.IsTrue(GaranteBLL.Eliminar(c));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsTrue(GaranteBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsTrue(GaranteBLL.GetLista().Count != 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsTrue(GaranteBLL.GetLista().Count != 0);
        }
    }
}