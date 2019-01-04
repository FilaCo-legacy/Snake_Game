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
        private const int WIDTH = 20, HEIGHT = 20;
        private char[,] matrix;
        public char this[int x, int y]
        {
            get { return matrix[y, x]; }
            set { }
        }
    }
}
