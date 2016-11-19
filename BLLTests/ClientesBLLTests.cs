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
            Clientes Cliente = new Clientes();

            Assert.IsTrue(ClientesBLL.Insertar(Cliente));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(ClientesBLL.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(ClientesBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsTrue(ClientesBLL.GetLista().Count != 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsTrue(ClientesBLL.GetLista(1).Count == 0);
        }
    }
}