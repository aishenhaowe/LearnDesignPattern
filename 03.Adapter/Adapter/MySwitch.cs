using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MySwitch
    {
        private ISwitchAble myAdapter;

        public MySwitch(ISwitchAble adapter)
        {
            myAdapter = adapter;
        }

        public void SwitchOn()
        {
            myAdapter.TurnOn();
        }

        public void SwitchOff()
        {
            myAdapter.TurnOff();
        }
    }
}
