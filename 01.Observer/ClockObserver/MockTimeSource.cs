using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockObserver
{
    public class MockTimeSource : Subject, TimeSource
    {
        private int _hour;
        private int _minite;
        private int _second;

        public int GetHour()
        {
            return _hour;
        }

        public int GetMinite()
        {
            return _minite;
        }

        public int GetSecond()
        {
            return _second;
        }

        public void SetTime(int hour, int minite, int second)
        {
            _hour = hour;
            _minite = minite;
            _second = second;

            Notify();
        }
    }
}
