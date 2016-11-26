using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractServer
{
    public interface ISwitchAble
    {
        void TurnOn();

        void TurnOff();

        int GetState();
    }
}
