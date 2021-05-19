using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TozziTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(3 == 3.0);
            Console.WriteLine("Prova console");
        }
    }
}
