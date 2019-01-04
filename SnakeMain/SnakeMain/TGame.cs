using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMain
{
    [Serializable]
    public class TGame
    {
        public TMap Map { get; set; }
        public TSnake Snake { get; set; }
    }
}
