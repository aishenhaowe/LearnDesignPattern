using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Product
    {
        private string _name;
        private int _price;

        public Product(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}
