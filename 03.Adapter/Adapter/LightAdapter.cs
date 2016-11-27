using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class LightAdapter : ISwitchAble
    {
        private Light _light;
        public LightAdapter(Light light)
        {
            _light = light;
        }

        public void TurnOn()
        {
            _light.TurnOn();
        }

        public void TurnOff()
        {
            _light.TurnOff();
        }
    }
}
