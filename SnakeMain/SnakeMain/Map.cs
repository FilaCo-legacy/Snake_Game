using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMain
{
    enum TPoint { EMPTY, FRUIT, SNAKE }
    class Map 
    {
        private const int MAX_WIDTH = 20, MAX_HEIGHT = 20;
        private TPoint[,] matrix;
        public int Width { get { return matrix.GetLength(1); } }
        public int Height { get { return matrix.GetLength(0); } }
        public TPoint this[int x, int y]
        {
            get { return matrix[y, x]; }
            set { matrix[y, x] = value; }
        }
        public Map(TPoint [,] _map)
        {
            matrix = _map;
        }
    }
}
