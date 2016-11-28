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
            Prestamos c = new Prestamos();
            Assert.IsTrue(PrestamosBLL.Guardar(c));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Prestamos e = new Prestamos();
            Assert.IsTrue(PrestamosBLL.Eliminar(e));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNull(PrestamosBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsNotNull(PrestamosBLL.GetLista());
        }

        [TestMethod()]
        public void GetListaIdTest()
        {
            Assert.IsNotNull(PrestamosBLL.GetListaId(1));
        }

        [TestMethod()]
        public void GetListaNombreTest()
        {
            Assert.IsNotNull(PrestamosBLL.GetLista());
        }

        [TestMethod()]
        public void GetListaFechaTest()
        {
            Assert.IsNotNull(PrestamosBLL.GetLista());
        }
        
    }
}