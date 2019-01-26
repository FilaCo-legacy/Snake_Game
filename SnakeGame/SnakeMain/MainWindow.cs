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
        private Bitmap buf;
        private Graphics g;
        public MainWindow()
        {
            InitializeComponent();
            Control.InitGame(this);
            buf = new Bitmap(gamePlace.Width, gamePlace.Height);
            g = gamePlace.CreateGraphics();

            topList.SelectAll();
            topList.SelectionAlignment = HorizontalAlignment.Center;
            topList.DeselectAll();
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
        private void gamePlace_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
