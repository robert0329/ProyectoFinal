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
            e.Usuario = "q";
            e.Contraseña = "q";
            Assert.IsTrue(UsuariosBLL.Guardar(e));
        }

        [TestMethod()]
        public void GetListaNombreUsuarioTest()
        {
            Usuarios us = new Usuarios();
            Assert.IsTrue(UsuariosBLL.GetListaNombreUsuario(Convert.ToString(us)).Count == 0);
        }

        [TestMethod()]
        public void GetContrasenaTest()
        {
            Usuarios us = new Usuarios();
            Assert.IsTrue(UsuariosBLL.GetContrasena(Convert.ToString(us)).Count == 0);
        }
    }
}