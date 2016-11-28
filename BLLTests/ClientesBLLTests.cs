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
    public class ClientesBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            
            Assert.IsTrue(ClientesBLL.Insertar(new Clientes(1,"asdsa","sasfsd","wfsfs","sffsdf","sdfsdfs","sfsf")));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaNombreTest()
        {
            Assert.Fail();
        }
    }
}