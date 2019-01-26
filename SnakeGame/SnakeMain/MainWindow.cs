using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SnakeMain
{
    public partial class MainWindow : Form
    {
        private static Regex regMap = new Regex(@".*\.map");
        public Size GetGamePlaceSize { get { return gamePlace.Size; } }
        public MainWindow()
        {
            InitializeComponent();
            Control.InitGame(this);

            topList.SelectAll();
            topList.SelectionAlignment = HorizontalAlignment.Center;
            topList.DeselectAll();

            PreviewKeyDown += MainWindow_PreviewKeyDown;
        }
        private void MainWindow_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            TDirection nDir;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    nDir = TDirection.LEFT;
                    Control.ChangeDirSnake(nDir);
                    break;
                case Keys.Right:
                    nDir = TDirection.RIGHT;
                    Control.ChangeDirSnake(nDir);
                    break;
                case Keys.Up:
                    nDir = TDirection.UP;
                    Control.ChangeDirSnake(nDir);
                    break;
                case Keys.Down:
                    nDir = TDirection.DOWN;
                    Control.ChangeDirSnake(nDir);
                    break;
            }            
        }
        private void itemLoadMap_Click(object sender, EventArgs e)
        {
            if (openMap.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   Control.LoadMap(openMap.FileName);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(this, exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Control.UpdateState();
        }
        public void DrawState(Bitmap source)
        {
            using (Graphics g = gamePlace.CreateGraphics())
                g.DrawImage(source, new Point(0, 0));
        }
    }
}
