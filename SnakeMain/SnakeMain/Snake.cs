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
        public enum TDirection { UP, DOWN, LEFT, RIGHT};
        private Bin_List<TPoint> body;
        public TDirection Direct { get; set; }
    }
}
