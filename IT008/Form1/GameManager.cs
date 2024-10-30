using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


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
        int unitX;
        int unitY;
        public Size imgsize;
        public int UnitX
        {
            get 
            { 
                return unitX;
            }
            set
            {
                unitX= value;
            }
        }
        public int UnitY
        {
            get 
            { 
                return unitY;
            }
            set
            {
                unitY= value;
            }
        }
        int playTime;
        public int row, col;
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
            playTime = 2*60;
            row = 3; col = 3;
            imgsize = new Size(360,360);
            UnitX = imgsize.Width / col;
            UnitY = imgsize.Height / row;


        }
        /// <summary>
        /// add status of 2 piece after moving
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        public bool UpdateStatus(List<PictureBox>imgPieces,Piece p1, Piece p2)
        {
            for (int i = 0; i < GameManager.Instance.row * GameManager.Instance.col - 1; ++i)
            {
                if (!((Piece)imgPieces[i]).Match())
                {
                    return false;
                }
            }
            return true;
        }
        public void IsLose()
        {
            GameManager.Instance.Status = GameStatus.EndGame;
            MessageBox.Show("Lose!");
        }

        public void IsWin()
        {
            MessageBox.Show("win");
        }

        /// <summary>
        /// countdown playing time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

    }
}
