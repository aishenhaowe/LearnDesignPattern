using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo2
{
    public class SchoolGirl
    {
        public SchoolGirl(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int GiftCount { get; set; }

        public int GetGiftCount()
        {
            return GiftCount;
        }
    }
}
