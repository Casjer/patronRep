using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatroRepos.BLL;
using PatroRepos.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatroRepos.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Cuentas cuenta = new Cuentas();
            cuenta.Cuenta = 2;
            cuenta.Descripcion = "Jerry";
            RepositorioBase<Cuentas> repositorio;
            repositorio = new RepositorioBase<Cuentas>();
            Assert.IsTrue(repositorio.Guardar(cuenta));

         
        }
    }
}