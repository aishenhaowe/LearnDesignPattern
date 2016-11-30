using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Order
    {
        private string _userName;
        private int _total = 0;
        private List<Item> _itemList;

        public Order(string userName)
        {
            _userName = userName;
            _itemList = new List<Item>();
        }

        public void AddItem(Product product, int count)
        {
            Item item = new Item(product, count);
            _itemList.Add(item);
        }

        public int GetTotal()
        {
            _total = 0;

            foreach (var item in _itemList)
            {
                _total += item.GetProduct().GetPrice() * item.GetCount();
            }

            return _total;
        }
    }
}
