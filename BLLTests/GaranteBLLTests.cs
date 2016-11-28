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
        public void InsertarTest()
        {
            Garantes c = new Garantes();
            Assert.IsTrue(GaranteBLL.Insertar(c));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Garantes e = new Garantes();
            Assert.IsTrue(GaranteBLL.Eliminar(e));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(GaranteBLL.Buscar(1));
        }

        [TestMethod()]
        public void BuscarTest1()
        {
            Assert.IsNull(GaranteBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(GaranteBLL.GetLista());
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsNotNull(GaranteBLL.GetLista());
        }

        [TestMethod()]
        public void GetListaMTest()
        {
            Assert.IsNotNull(GaranteBLL.GetLista());
        }
    }
}