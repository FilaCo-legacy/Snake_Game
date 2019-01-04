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
        public int Size
        {
            get
            {
                if (next == null)
                    return 1;
                else
                    return next.Size + 1;
            }
        }
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
        public void AddToBegin(T elem)
        {
            Bin_List<T> tmp = Last();
            AddToEnd(Last().Data);
            int curSize = Size;
            for (int i = 1; i < curSize-1; ++i)
            {
                tmp.Data = tmp.pref.Data;
                tmp = tmp.pref;
            }
            Data = elem;
        }
        public Bin_List<T> Last()
        {
            if (next != null)
                return next.Last();
            return this;
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
