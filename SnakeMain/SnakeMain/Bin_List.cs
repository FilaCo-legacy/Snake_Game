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
        public void ShiftRight(T headValue)
        {
            Bin_List<T> tmp = this;
            while (tmp.next != null)
                tmp = tmp.next;
            while (tmp.pref != null)
            {
                tmp.Data = tmp.pref.Data;
                tmp = tmp.pref;
            }
            Data = headValue;
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
            T tmp = FindLast();
            ShiftRight(elem);
            AddToEnd(tmp);
        }
        public T FindLast()
        {
            if (next != null)
                return next.FindLast();
            return Data;
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
