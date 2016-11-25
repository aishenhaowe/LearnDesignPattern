using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockObserver
{
    public class MockTimeSink : ObServer
    {
        private TimeSource _timeSource;
        private int _hour;
        private int _minite;
        private int _second;

        public MockTimeSink(TimeSource timeSource)
        {
            _timeSource = timeSource;
        }

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

        public void Update()
        {
            _hour = _timeSource.GetHour();
            _minite = _timeSource.GetMinite();
            _second = _timeSource.GetSecond();
        }
    }
}
