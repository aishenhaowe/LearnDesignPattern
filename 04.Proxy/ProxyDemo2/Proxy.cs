using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo2
{
    public class Proxy : GiveGift
    {
        private string _name;
        private Pursuit _gg;
        private SchoolGirl _mm;

        public Proxy(string name, string pursuitName, SchoolGirl mm)
        {
            _name = name;
            _mm = mm;
            _gg = new Pursuit(pursuitName, mm);
        }

        public void GiveDoll()
        {
            _gg.GiveDoll();
            _mm.GiftCount++;
        }

        public void GiveChoclate()
        {
            _gg.GiveChoclate();
            _mm.GiftCount++;
        }

        public void GiveFlowers()
        {
            _gg.GiveFlowers();
            _mm.GiftCount++;
        }
    }
}
