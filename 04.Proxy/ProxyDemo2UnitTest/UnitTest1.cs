using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProxyDemo2;

namespace ProxyDemo2UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SchoolGirl jj = new SchoolGirl("JiaoJiao");
            Proxy dl = new Proxy("Daili", "ZuoJiayi", jj);

            dl.GiveDoll();
            dl.GiveChoclate();
            dl.GiveFlowers();

            Assert.AreEqual(3, jj.GetGiftCount());
        }
    }
}
