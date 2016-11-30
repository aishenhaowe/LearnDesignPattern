using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Item
    {
        Product _product;
        int _count;

        public Item(Product product, int count)
        {
            _product = product;
            _count = count;
        }

        public Product GetProduct()
        {
            return _product;
        }

        public int GetCount()
        {
            return _count;
        }
    }
}
