using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMain
{
    public enum TDirection { UP, DOWN, LEFT, RIGHT };
    public class TSnake
    {
        const int MIN_SIZE = 3;        
        private TBinList<TPoint> body;
        private TDirection direct;
        public TDirection Direct
        {
            get { return direct; }
            set
            {
                switch (value)
                {
                    case TDirection.DOWN:
                        if (body.GetNext.Y != body.Data.Y + 1)
                            direct = value;
                        break;
                    case TDirection.UP:
                        if (body.GetNext.Y != body.Data.Y - 1)
                            direct = value;
                        break;
                    case TDirection.LEFT:
                        if (body.GetNext.X != body.Data.X - 1)
                            direct = value;
                        break;
                    case TDirection.RIGHT:
                        if (body.GetNext.X != body.Data.X + 1)
                            direct = value;
                        break;
                }
            }
        }
        public int Size { get { return body.Size; } }
        public TPoint Head { get { return body.Data; } }
        public TPoint Tail { get { return body.FindLast(); } }
        public TSnake (int _x, int _y)
        {
            Direct = TDirection.UP;
            body = new TBinList<TPoint>(new TPoint(_x, _y));
            //for (int i = 1; i < MIN_SIZE; ++i)
            //{
            //    GrowUp();
            //}
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
            body.ShiftRight(nElem);
        }
        public void GrowUp(TPoint tail)
        {
            body.AddToEnd(tail);
        }
    }
}
