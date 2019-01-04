using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace SnakeMain
{
    public class Control
    {
        public static TGame Game { get; set; }
        private static TMapPoint[,] ConvInpToMap(string [] input)
        {
            TMapPoint[,] tmp = new TMapPoint[input.Length, input.Length];
            for (int i = 0; i < input.Length; ++i)
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
        public static void LoadMap(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string[] inp = sr.ReadToEnd().Split('\n');
                TMapPoint [,] converted = ConvInpToMap(inp);
                Game.Map = new TMap(converted);
                sr.Close();
            }
        }
        public static void LoadGame(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                XmlSerializer xsReader = new XmlSerializer(typeof(TGame));
                Game = (TGame)xsReader.Deserialize(sr);
                sr.Close();
            }

        }
        public static void SaveGame(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                XmlSerializer xsReader = new XmlSerializer(typeof(TGame));
                xsReader.Serialize(sw, Game);
                sw.Close();
            }
        }
    }
}
