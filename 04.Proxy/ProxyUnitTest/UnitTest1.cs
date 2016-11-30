using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proxy;

namespace ProxyUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProxyMethod1()
        {
            Order o = new Order("Break");
            Product p1 = new Product("ToothPaste", 10);
            o.AddItem(p1, 2);

            Assert.AreEqual(20, o.GetTotal());

            Product p2 = new Product("MouthWash", 110);
            o.AddItem(p2, 3);

            Assert.AreEqual(350, o.GetTotal());
        }
    }
}
