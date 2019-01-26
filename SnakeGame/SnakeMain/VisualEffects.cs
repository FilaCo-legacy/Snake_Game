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
        private static Font TitleFont = new Font("Tahoma", 36.0f);
        private static Random rnd = new Random();
        private static Bitmap spriteGrass = Properties.Resources.Grass;
        private static Bitmap[] spriteWall = new Bitmap[] { Properties.Resources.Wall1, Properties.Resources.Wall2,
        Properties.Resources.Wall3};
        private static Bitmap spriteBody = Properties.Resources.SnakeBodyz;
        private static Bitmap spriteHead = Properties.Resources.SnakeHead;
        private static Bitmap spriteFruit = Properties.Resources.frukt_33;
        public static void DrawState(TMap map, Bitmap buffer, 
            TPoint snakeHead = null)
        {
            using (Graphics g = Graphics.FromImage(buffer))
            {
                for (int i = 0; i < map.Height; ++i)
                {
                    for (int j = 0; j < map.Width; ++j)
                    {
                        int posX = j * buffer.Width / map.Width, posY = i * buffer.Height / map.Height;
                        g.DrawImage(spriteGrass, posX, posY, buffer.Width / map.Width,
                                    buffer.Height / map.Height);
                        if (map[i, j] == TMapPoint.EMPTY)
                            continue;
                        Bitmap sprite = null;
                        switch (map[i, j])
                        {
                            case TMapPoint.FRUIT:
                                sprite = spriteFruit;
                                break;
                            case TMapPoint.WALL:
                                sprite = spriteWall[rnd.Next(0, 3)];
                                break;
                            case TMapPoint.SNAKE:
                                if (snakeHead != null && snakeHead.X == j && snakeHead.Y == i)
                                    sprite = spriteHead;
                                else
                                    sprite = spriteBody;
                                break;
                        }
                        g.DrawImage(sprite, posX, posY, buffer.Width / map.Width,
                                    buffer.Height / map.Height);
                    }
                }
                g.Dispose();
            }
        }
        private static void DrawMessage(string msg, Brush txtColor, Bitmap buffer)
        {
            using (Graphics g = Graphics.FromImage(buffer))
            {
                PointF msgPlace = new PointF(buffer.Width / 2.0f - msg.Length *
                    TitleFont.Size / 2.0f, buffer.Height / 2.0f - TitleFont.Height / 2.0f);
                g.DrawString(msg, TitleFont, txtColor, msgPlace);
            }
        }
        private static void DrawBlackOut (Bitmap buffer)
        {
            Rectangle trgtPlace = new Rectangle(0, 0, buffer.Width, buffer.Height);
            using (Graphics g = Graphics.FromImage(buffer))
            {
                using (SolidBrush br = new SolidBrush(Color.FromArgb(64, Color.Black)))
                {
                    g.FillRectangle(br, trgtPlace);
                }
            }
        }
        public static void DrawState(TMap map, Bitmap bmp, string msg, TPoint snakeHead = null)
        {
            DrawState(map, bmp, snakeHead);
            DrawBlackOut(bmp);
            DrawMessage(msg, Brushes.PaleGreen, bmp);
        }
    }
}
