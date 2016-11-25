using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockObserver;

namespace ClockObserverUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTimeSink01()
        {
            /* 创建观察者和被观察者对象 */
            MockTimeSource mockTimeSource = new MockTimeSource();
            MockTimeSink mockTimeSink = new MockTimeSink(mockTimeSource);

            /* 设定观察者对象 */
            mockTimeSource.RegisterObserver(mockTimeSink);

            /* Refresh the souce */
            mockTimeSource.SetTime(1, 3, 5);

            Assert.AreEqual(1, mockTimeSink.GetHour());
            Assert.AreEqual(3, mockTimeSink.GetMinite());
            Assert.AreEqual(5, mockTimeSink.GetSecond());
        }

        [TestMethod]
        public void TestTimeSink02()
        {
            /* 创建观察者和被观察者对象 */
            MockTimeSource mockTimeSource = new MockTimeSource();
            MockTimeSink mockTimeSink = new MockTimeSink(mockTimeSource);
            MockTimeSink mockTimeSink1 = new MockTimeSink(mockTimeSource);

            /* 设定观察者对象 */
            mockTimeSource.RegisterObserver(mockTimeSink);
            mockTimeSource.RegisterObserver(mockTimeSink1);

            /* Refresh the souce */
            mockTimeSource.SetTime(1, 3, 5);

            Assert.AreEqual(1, mockTimeSink.GetHour());
            Assert.AreEqual(3, mockTimeSink.GetMinite());
            Assert.AreEqual(5, mockTimeSink.GetSecond());
            Assert.AreEqual(1, mockTimeSink1.GetHour());
            Assert.AreEqual(3, mockTimeSink1.GetMinite());
            Assert.AreEqual(5, mockTimeSink1.GetSecond());
        }

        [TestMethod]
        public void TestTimeSink03()
        {
            /* 创建观察者和被观察者对象 */
            MockTimeSource mockTimeSource = new MockTimeSource();
            MockTimeSink mockTimeSink = new MockTimeSink(mockTimeSource);
            MockTimeSink mockTimeSink1 = new MockTimeSink(mockTimeSource);

            /* 设定观察者对象 */
            mockTimeSource.RegisterObserver(mockTimeSink);
            mockTimeSource.RegisterObserver(mockTimeSink1);

            /* Refresh the souce */
            mockTimeSource.SetTime(1, 3, 5);

            Assert.AreEqual(1, mockTimeSink.GetHour());
            Assert.AreEqual(3, mockTimeSink.GetMinite());
            Assert.AreEqual(5, mockTimeSink.GetSecond());
            Assert.AreEqual(1, mockTimeSink1.GetHour());
            Assert.AreEqual(3, mockTimeSink1.GetMinite());
            Assert.AreEqual(5, mockTimeSink1.GetSecond());

            /* Refresh the souce */
            mockTimeSource.SetTime(2, 4, 6);

            Assert.AreEqual(2, mockTimeSink1.GetHour());
            Assert.AreEqual(4, mockTimeSink1.GetMinite());
            Assert.AreEqual(6, mockTimeSink1.GetSecond());
        }
    }
}
