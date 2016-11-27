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
            Light light = new Light();
            LightAdapter lightAdapter = new LightAdapter(light);
            MySwitch mySwitch = new MySwitch(lightAdapter);

            Assert.AreEqual(0, light.GetState());
        }

        [TestMethod]
        public void TestMethod02()
        {
            Light light = new Light();
            LightAdapter lightAdapter = new LightAdapter(light);
            MySwitch mySwitch = new MySwitch(lightAdapter);

            mySwitch.SwitchOn();
            Assert.AreEqual(1, light.GetState());
        }

        [TestMethod]
        public void TestMethod03()
        {
            Light light = new Light();
            LightAdapter lightAdapter = new LightAdapter(light);
            MySwitch mySwitch = new MySwitch(lightAdapter);

            mySwitch.SwitchOff();
            Assert.AreEqual(0, light.GetState());
        }

        [TestMethod]
        public void TestMethod04()
        {
            Light light = new Light();
            LightAdapter lightAdapter = new LightAdapter(light);
            MySwitch mySwitch = new MySwitch(lightAdapter);

            mySwitch.SwitchOn();
            Assert.AreEqual(1, light.GetState());
            mySwitch.SwitchOff();
            Assert.AreEqual(0, light.GetState());
        }

        [TestMethod]
        public void TestMethod05()
        {
            Light light = new Light();
            LightAdapter lightAdapter = new LightAdapter(light);
            MySwitch mySwitch = new MySwitch(lightAdapter);

            mySwitch.SwitchOn();
            Assert.AreEqual(1, light.GetState());
            mySwitch.SwitchOff();
            Assert.AreEqual(0, light.GetState());
            mySwitch.SwitchOn();
            Assert.AreEqual(1, light.GetState());
        }
    }
}
