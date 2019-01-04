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
        private static Regex regGame = new Regex("*.game");
        private static Regex regMap = new Regex("*.map");
        public MainWindow()
        {
            InitializeComponent();
        }
        private void itemLoadFile_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (regGame.IsMatch(openFile.FileName))
                        Control.LoadGame(openFile.FileName);
                    else if (regMap.IsMatch(openFile.FileName))
                        Control.LoadMap(openFile.FileName);
                    else
                        MessageBox.Show(this, "Формат файла неверен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(this, exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void itemSaveGame_Click(object sender, EventArgs e)
        {
            if (saveGame.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Control.SaveGame(saveGame.FileName);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(this, exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
