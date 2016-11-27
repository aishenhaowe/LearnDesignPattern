using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class LightAdapter : Light, ISwitchAble
    {
        private Light _light;

        public void TurnOn()
        {
            base.TurnOn();
        }

        public void TurnOff()
        {
            base.TurnOff();
        }
    }
}
