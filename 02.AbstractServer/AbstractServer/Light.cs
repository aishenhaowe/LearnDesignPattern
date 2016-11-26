using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractServer
{
    public class Light : ISwitchAble
    {
        private int _state;

        public int GetState()
        {
            return _state;
        }

        public void TurnOn()
        {
            _state = 1;
        }

        public void TurnOff()
        {
            _state = 0;
        }
    }
}
