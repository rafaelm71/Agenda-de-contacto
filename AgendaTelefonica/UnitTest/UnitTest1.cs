using AgendaTelefonica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var buscar = new Class3();

          var result = buscar.re != null;

            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            var buscar = new Class3();

            var result = buscar.Dui != null;

            Assert.IsNotNull(result);
        }
    }
}
