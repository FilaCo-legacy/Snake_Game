using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMain
{
    public class Snake
    {
        const int MIN_SIZE = 3;
        public enum TDirection { UP, DOWN, LEFT, RIGHT};
        private Bin_List<TPoint> body;
        public TDirection Direct { get; set; }
        public int Size { get { return body.Size; } }
        public TPoint Head { get { return body.Data; } }
        public TPoint Tail { get { return body.Last().Data; } }
        public Snake (int _x, int _y)
        {
            body = new Bin_List<TPoint>(new TPoint(_x, _y));
        }
        public void Move()
        {
            TPoint nElem = null;
            switch (Direct)
            {
                case TDirection.UP:
                    nElem = new TPoint(Head.X, Head.Y - 1);
                    break;
                case TDirection.DOWN:
                    nElem = new TPoint(Head.X, Head.Y + 1);
                    break;
                case TDirection.LEFT:
                    nElem = new TPoint(Head.X - 1, Head.Y);
                    break;
                case TDirection.RIGHT:
                    nElem = new TPoint(Head.X + 1, Head.Y);
                    break;
            }
            Bin_List<TPoint> tmp = body.Last();
        }
        public void GrowUp()
        {
            TPoint nElem = null;
            switch (Direct)
            {
                case TDirection.UP:
                    nElem = new TPoint(Head.X, Head.Y - 1);
                    break;
                case TDirection.DOWN:
                    nElem = new TPoint(Head.X, Head.Y + 1);
                    break;
                case TDirection.LEFT:
                    nElem = new TPoint(Head.X - 1, Head.Y);
                    break;
                case TDirection.RIGHT:
                    nElem = new TPoint(Head.X + 1, Head.Y);
                    break;
            }
            body.AddToBegin(nElem);
        }
    }
}
