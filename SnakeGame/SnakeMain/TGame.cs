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
        public enum TResult { GAME_OVER, GROW_UP, NOTHING}
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
        public void GameStart(TMap trgtMap)
        {
            Map = trgtMap;
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
        private void UpdateMap()
        {
            bool needToGenFruit = true;
            for (int i = 0; i < Map.Width; ++i)
            {
                for (int j = 0; j < Map.Height; ++j)
                {
                    if (Map[j, i] == TMapPoint.SNAKE)
                        Map[j, i] = TMapPoint.EMPTY;
                }
            }
            foreach (var cur in Snake)
                Map[cur] = TMapPoint.SNAKE;
            for (int i = 0; i < Map.Width; ++i)           
                for (int j = 0; j < Map.Height; ++j)
                    if (Map[j, i] == TMapPoint.FRUIT)
                    {
                        needToGenFruit = false;
                        break;
                    }
            if (needToGenFruit)
                GenFruit();

        }
        private void GenFruit()
        {
            Random rnd = new Random();
            bool check = false;
            TPoint p = new TPoint(0,0);
            do
            {
                check = Map[p] == TMapPoint.EMPTY;
                if (!check)
                {
                    p.X = rnd.Next(1, Map.Width - 1);
                    p.Y = rnd.Next(1, Map.Height - 1);
                }
            } while (!check);
            Map[p] = TMapPoint.FRUIT;
        }
        public TResult Turn()
        {
            TPoint tmpTail = Snake.Tail;
            Snake.Move();
            TResult res = CheckState();
            switch (res)
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
            UpdateMap();
            return res;
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
