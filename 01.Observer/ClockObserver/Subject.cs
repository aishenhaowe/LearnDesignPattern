using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockObserver
{
    public class Subject
    {
        private List<ObServer> _listObserver = new List<ObServer>();

        public void RegisterObserver(ObServer observer)
        {
            _listObserver.Add(observer);
        }

        protected void Notify()
        {
            foreach (var item in _listObserver)
	        {
                item.Update();
	        }
        }
    }
}
