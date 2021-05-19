using Microsoft.VisualStudio.TestTools.UnitTesting;
using TozziSrc;
using System;
using System.Collections.Generic;

namespace TozziTest
{
    [TestClass]
    public class ClientTest
    {
 
        [TestMethod]
        public void TestMethod1()
        {
            ControllerClient c = new TozziSrc.ControllerClient();

            c.InsertClient("luigi", "bianchi", "ccc");
            c.InsertClient("chiara","tozzi","lfr");
            Assert.IsFalse(c.SearchClient("ghrt"));
            Assert.IsTrue(c.SearchClient("lfr"));
            Assert.IsTrue(c.SearchClient("ccc"));

            c.DeleteClient("lfr");
            Assert.IsFalse(c.SearchClient("lfr"));
            Assert.IsTrue(c.SearchClient("ccc"));

            Client cli = c.GetClient("ccc");
            Client cli1 = c.GetClient("tre");
            Assert.IsNotNull(cli);
            Assert.IsNull(cli1);

            Console.WriteLine("Prova console");
        }
    }
}
