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
        private enum TResult { GAME_OVER, GROW_UP, NOTHING}
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
        private TResult CheckState()
        {
            //if (Snake.Intersected())
            //    return TResult.GAME_OVER;
            switch (Map[Snake.Head])
            {
                case TMapPoint.SNAKE:
                    return TResult.GAME_OVER;
                case TMapPoint.WALL:
                    return TResult.GAME_OVER;
                case TMapPoint.FRUIT:
                    return TResult.GROW_UP;
                default:
                    return TResult.NOTHING;                    
            }
        }
        public void Turn()
        {
            TPoint tmpTail = Snake.Tail;
            Snake.Move();
            switch (CheckState())
            {
                case TResult.GAME_OVER:
                    OnGameOver(this, new GameOverHandlerEventArgs(Score)); 
                    break;
                case TResult.GROW_UP:
                    Snake.GrowUp(tmpTail);
                    break;
                default:
                    break;
            }
        }
        public void OnGameOver(object sender, GameOverHandlerEventArgs e)
        {
            GameOver?.Invoke(sender, e);
        }
        public void ChangeDirSnake(TDirection _dir)
        {
            Snake.Direct = _dir;
        }
    }
}
