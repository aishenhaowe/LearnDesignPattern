using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockObserver
{
    public interface TimeSource
    {
        int GetHour();
        int GetMinite();
        int GetSecond();
    }
}
