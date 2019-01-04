using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMain
{
    class Bin_List<T>:IEnumerable
    {
        private Bin_List<T> next, pref;
        public int Size { get; set; }
        public T Data { get; set; }
        public Bin_List()
        {
            Size = 0;
            next = pref = null;
            Data = default(T);
        }
        public Bin_List(T elem)
        {
            Size = 1;
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
        IEnumerator IEnumerable.GetEnumerator()
        {
            Bin_List<T> cur = this;
            do
            {
                yield return cur;
                cur = cur.next;
            } while (cur != null);
        }
    }
}
