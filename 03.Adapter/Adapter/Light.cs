using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Light
    {
        private int _state;

        public void TurnOn()
        {
            _state = 1;
        }

        public void TurnOff()
        {
            _state = 0;
        }

        public int GetState()
        {
            return _state;
        }
    }
}
