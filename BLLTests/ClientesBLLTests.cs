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
            Assert.IsTrue(ClientesBLL.Eliminar(new Clientes(1, "asdsa", "sasfsd", "wfsfs", "sffsdf", "sdfsdfs", "sfsf")));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(ClientesBLL.Buscar(1));
        }

        [TestMethod()]
        public void BuscarTest1()
        {
            Assert.IsNull(ClientesBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(ClientesBLL.GetLista());
        }

        [TestMethod()]
        public void GetListaIdTest()
        {
            Assert.IsNotNull(ClientesBLL.GetListaId(1));
        }

        [TestMethod()]
        public void GetListaNombreTest()
        {
            Clientes p = new Clientes();
            Assert.IsNotNull(ClientesBLL.GetListaNombre(Convert.ToString(p)));
        }
    }
}