using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;

namespace SnakeMain
{
    public class Control
    {
        private const string GameOverString = "GAME OVER";
        private const string PauseString = "Pause";
        public static TGame Game { get; set; }
        public static MainWindow OwnerForm { get; set; } 
        private static TMapPoint[,] ConvInpToMap(string [] input)
        {
            TMapPoint[,] tmp = new TMapPoint[input.Length-1, input.Length-1];
            for (int i = 0; i < input.Length-1; ++i)
            {
                input[i] = input[i].Replace("\t", "");
                for (int j = 0; j < input[i].Length; ++j)
                {
                    if (Enum.IsDefined(typeof(TMapPoint), input[i][j] - '0'))
                        tmp[i, j] = (TMapPoint)input[i][j] - '0';
                    else
                        throw new Exception("Неверный формат входного файла");
                }
            }
            return tmp;
        }
        public static void InitGame(MainWindow owner)
        {
            Game = new TGame();
            OwnerForm = owner;
            Game.GameOver += GameOver;
        }
        public static void LoadMap(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string inpStr = sr.ReadToEnd().Replace("\r", "");
                string[] inp = inpStr.Split('\n');
                TMapPoint [,] converted = ConvInpToMap(inp);
                Game.Map = new TMap(converted);
                sr.Close();
            }
        }
        public static void ChangeDirSnake(TDirection _dir)
        {
            Game.ChangeDirSnake(_dir);
        }
        public static void UpdateState()
        {
            TGame.TResult curRes = Game.Turn();
            if (curRes == TGame.TResult.GAME_OVER)
                return;
            Bitmap bmp = new Bitmap(OwnerForm.GetGamePlaceSize.Width, OwnerForm.GetGamePlaceSize.Height);
            VisualEffects.DrawState(Game.Map, bmp, Game.Snake.Head);
            OwnerForm.DrawState(bmp);
        }
        public static void GameOver(object sender, GameOverHandlerEventArgs args)
        {
            Bitmap bmp = new Bitmap(OwnerForm.GetGamePlaceSize.Width, OwnerForm.GetGamePlaceSize.Height);
            VisualEffects.DrawState(Game.Map, bmp, string.Format($"{GameOverString}\n Score: {args.Score}"), Game.Snake.Head);
            OwnerForm.DrawState(bmp);
        }
    }
}
