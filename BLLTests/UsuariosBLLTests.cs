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
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuarios e = new Usuarios();
            Assert.IsTrue(UsuariosBLL.Guardar(e));
        }

        [TestMethod()]
        public void GetListaNombreUsuarioTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetContrasenaTest()
        {
            Assert.Fail();
        }
    }
}