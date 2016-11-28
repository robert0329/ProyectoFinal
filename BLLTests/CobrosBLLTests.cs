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
    public class CobrosBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Cobros c = new Cobros();
            Assert.IsTrue(CobrosBLL.Insertar(c));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(CobrosBLL.Buscar(1));
        }

        [TestMethod()]
        public void BuscarTest1()
        {
            Assert.IsNull(CobrosBLL.Buscar(1));
        }
        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(CobrosBLL.GetLista());
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsNotNull(CobrosBLL.GetLista());
        }

        [TestMethod()]
        public void GetListaCTest()
        {
            Assert.IsNotNull(CobrosBLL.GetLista());
        }

        [TestMethod()]
        public void GetListaIdTest()
        {
            Assert.IsNotNull(CobrosBLL.GetLista());
        }

        [TestMethod()]
        public void GetListaFechaTest()
        {
            Assert.IsNotNull(CobrosBLL.GetLista());
        }
    }
}