using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMain
{
    public class TPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static bool operator == (TPoint p1, TPoint p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }
        public static bool operator !=(TPoint p1, TPoint p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y;
        }

        public TPoint(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
    }
}
