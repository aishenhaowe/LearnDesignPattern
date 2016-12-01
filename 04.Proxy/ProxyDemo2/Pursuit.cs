using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo2
{
    public class Pursuit : GiveGift
    {
        private string _name;
        private SchoolGirl _mm;

        public Pursuit(string name, SchoolGirl mm)
        {
            _name = name;
            _mm = mm;
        }

        public void GiveDoll()
        {
            Console.WriteLine(_name + " give " + _mm.Name + " doll ");
        }

        public void GiveChoclate()
        {
            Console.WriteLine(_name + " give " + _mm.Name + " choclate ");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(_name + " give " + _mm.Name + " flowers ");
        }
    }
}
