using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMain
{
    public delegate void GameOverHandler(object source, GameOverHandlerEventArgs args);
    [Serializable]
    public class TGame
    {
        public TMap Map { get; set; }
        public TSnake Snake { get; set; }
        public int Score { get; set; }
        public event GameOverHandler GameOver;
        public TGame()
        {
            Map = null;
            Snake = null;

        }
        private void SnakeSpawn()
        {

        }
        public void GameStart()
        {

        }
        private void CheckState()
        {

        }
        public void Turn()
        {

        }
        public void OnGameOver(object sender, GameOverHandlerEventArgs e)
        {
            GameOver?.Invoke(sender, e);
        }
    }
}
