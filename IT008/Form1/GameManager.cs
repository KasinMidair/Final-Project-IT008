using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    public enum GameStatus
    {
        StartGame,
        Playing,
        EndGame
    }
    public class GameManager
    {
        int playTime;
        public int row, col;
        private int score;
        private static volatile GameManager _instance;
        private GameStatus status;
        private static object key = new object();
        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (key)
                    {
                        _instance = new GameManager();
                    }
                }

                return _instance;
            }
        }
        public GameStatus Status 
        { 
            get 
            {
                return status;
            }
            set 
            {
                status = value;
            }
        }
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
               score = value;
            }
        }
        public int PlayTime
        {
            get
            {
                return playTime;
            }
            set
            {
                playTime= value;
            }
        }
        private GameManager() 
        { 
            status = GameStatus.StartGame;
            score = 0;
            playTime = 3*60;
            row = 3; col = 3;
            
        }
        public bool isVertialMove(int mpos)
        {
            return (mpos>0 && mpos <col*row);
        }
        public bool isHorizontalMove(int pos, int direct)
        {
            return ((pos + direct) % col != 0); 
        }
       
    }
}
