using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SnakeMain
{
    public class VisualEffects
    {
        private static Font TitleFont = new Font("Microsoft Sans Seriff", 36.0f);
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
        public static void DrawMessage(string msg, int trgtWidth, int trgtHeight, out Bitmap buffer)
        {
            buffer = new Bitmap(trgtWidth, trgtHeight);
            using (Graphics g = Graphics.FromImage(buffer))
            {
                g.DrawString(msg, TitleFont, Brushes.Red, new PointF(trgtWidth / 2.0f - msg.Length * 
                    TitleFont.Size / 2.0f, trgtHeight / 2.0f - TitleFont.Height / 2.0f));
            }
        }
        public static void DrawBlackOut(int trgtWidth, int trgtHeight, out Bitmap buffer)
        {
            buffer = new Bitmap(trgtWidth, trgtHeight);
            Rectangle trgtPlace = new Rectangle(0, 0, trgtWidth, trgtHeight);
            using (Graphics g = Graphics.FromImage(buffer))
            {
                using (SolidBrush br = new SolidBrush(Color.FromArgb(64, Color.Black)))
                {
                    g.FillRectangle(br, trgtPlace);
                }
            }
        }
    }
}
