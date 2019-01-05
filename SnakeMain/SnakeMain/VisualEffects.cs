using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeMain
{
    public class VisualEffects
    {
        private static Random rnd = new Random();
        private static Bitmap spriteGrass = Properties.Resources.Grass;
        private static Bitmap[] spriteWall = new Bitmap[] { Properties.Resources.Wall1, Properties.Resources.Wall2,
        Properties.Resources.Wall3};
        public static void DrawState(TMap map, int trgtWidth, int trgtHeight, out Bitmap buffer, 
            TPoint snakeHead = null, TPoint snakeTail = null)
        {
            buffer = new Bitmap(trgtWidth, trgtHeight);
            using (Graphics g = Graphics.FromImage(buffer))
            {
                for (int i = 0; i < map.Height; ++i)
                {
                    for (int j = 0; j < map.Width; ++j)
                    {
                        int posX = j * trgtWidth / map.Width, posY = i * trgtHeight / map.Height;
                        g.DrawImage(spriteGrass, posX, posY, trgtWidth / map.Width,
                                    trgtHeight / map.Height);
                        if (map[i, j] == TMapPoint.EMPTY)
                            continue;
                        Bitmap sprite = null;
                        switch (map[i, j])
                        {
                            case TMapPoint.FRUIT:
                                break;
                            case TMapPoint.WALL:
                                sprite = spriteWall[rnd.Next(0, 3)];
                                break;
                            case TMapPoint.SNAKE:
                                break;
                        }
                        g.DrawImage(sprite, posX, posY, trgtWidth / map.Width,
                                    trgtHeight / map.Height);
                    }
                }
                g.Dispose();
            }
        }
    }
}
