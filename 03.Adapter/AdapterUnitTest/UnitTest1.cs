using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adapter;

namespace AdapterUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod01()
        {
            LightAdapter light = new LightAdapter();
            MySwitch mySwitch = new MySwitch(light);

            Assert.AreEqual(0, light.GetState());
        }

        [TestMethod]
        public void TestMethod02()
        {
            LightAdapter light = new LightAdapter();
            MySwitch mySwitch = new MySwitch(light);

            mySwitch.SwitchOn();
            Assert.AreEqual(1, light.GetState());
        }

        [TestMethod]
        public void TestMethod03()
        {
            LightAdapter light = new LightAdapter();
            MySwitch mySwitch = new MySwitch(light);

            mySwitch.SwitchOff();
            Assert.AreEqual(0, light.GetState());
        }

        [TestMethod]
        public void TestMethod04()
        {
            LightAdapter light = new LightAdapter();
            MySwitch mySwitch = new MySwitch(light);

            mySwitch.SwitchOn();
            Assert.AreEqual(1, light.GetState());
            mySwitch.SwitchOff();
            Assert.AreEqual(0, light.GetState());
        }

        [TestMethod]
        public void TestMethod05()
        {
            LightAdapter light = new LightAdapter();
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
