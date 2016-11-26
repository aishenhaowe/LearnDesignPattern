using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractServer;

namespace AbstractServerUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod01()
        {
            ISwitchAble light = new Light();
            MySwitch mySwitch = new MySwitch(light);

            Assert.AreEqual(0, light.GetState());
        }

        [TestMethod]
        public void TestMethod02()
        {
            ISwitchAble light = new Light();
            MySwitch mySwitch = new MySwitch(light);

            mySwitch.SwitchOn();
            Assert.AreEqual(1, light.GetState());
        }

        [TestMethod]
        public void TestMethod03()
        {
            ISwitchAble light = new Light();
            MySwitch mySwitch = new MySwitch(light);

            mySwitch.SwitchOn();
            Assert.AreEqual(1, light.GetState());
            mySwitch.SwitchOff();
            Assert.AreEqual(0, light.GetState());
        }

        [TestMethod]
        public void TestMethod04()
        {
            ISwitchAble light = new Light();
            MySwitch mySwitch = new MySwitch(light);

            mySwitch.SwitchOn();
            Assert.AreEqual(1, light.GetState());
            mySwitch.SwitchOff();
            Assert.AreEqual(0, light.GetState());
            mySwitch.SwitchOn();
            Assert.AreEqual(1, light.GetState());
        }
    }
}
