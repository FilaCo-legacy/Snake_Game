using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMain
{
    class Bin_List<T>
    {
        private Bin_List<T> next, pref;
        public T Data { get; set; }
        public Bin_List(T elem)
        {
            next = pref = null;
            Data = elem;
        }
        public void AddToEnd(T elem)
        {
            if (next != null)
                next.AddToEnd(elem);
            Bin_List<T> nElem = new Bin_List<T>(elem);
            next = nElem;
            nElem.pref = next;
        }
    }
}
