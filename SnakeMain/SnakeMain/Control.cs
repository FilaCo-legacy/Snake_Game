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
        public static void LoadMap(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                XmlSerializer xsReader = new XmlSerializer(typeof(TMap));
                Game.Map = (TMap)xsReader.Deserialize(sr);
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
    }
}
