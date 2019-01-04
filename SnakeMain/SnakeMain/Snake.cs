using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMain
{
    class TPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public TPoint(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
    }
    public class Snake
    {
        const int MIN_SIZE = 3;
        public enum TDirection { UP, DOWN, LEFT, RIGHT};
        private Bin_List<TPoint> body;
        public TDirection Direct { get; set; }
        public int Size { get { return body.Size; } }
        public TPoint Head { get { return body.Data; } }
        public TPoint Tail { get { return body.FindLast(); } }
        public Snake (int _x, int _y)
        {
            body = new Bin_List<TPoint>(new TPoint(_x, _y));
        }
        public void GrowUp()
        {

        }
    }
}
