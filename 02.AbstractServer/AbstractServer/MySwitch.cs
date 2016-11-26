using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractServer
{
    public class MySwitch
    {
        private ISwitchAble _equipment;
        public MySwitch(ISwitchAble equipment)
        {
            _equipment = equipment;
        }

        public void SwitchOn()
        {
            _equipment.TurnOn();
        }

        public void SwitchOff()
        {
            _equipment.TurnOff();
        }
    }
}
