using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form1
{
    public partial class Player : Form
    {

        GameRound player;
        public Player()
        {
            InitializeComponent();
            player = new GameRound(panel1, pnlGamePlaySpace);

        }



        /// <summary>
        /// using key press event to mowing blackPiece around
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int moveIndex=-1;
            Piece tmp = (Piece)player.imgPieces[player.BlackBox_Indx];
            switch (keyData)
            {
                case Keys.Down:
                    player.MovingPiece(tmp.XIndex-1, tmp.YIndex, ref moveIndex);
                    break;
                case Keys.Up:
                    player.MovingPiece(tmp.XIndex+1, tmp.YIndex, ref moveIndex);
                    break;
                case Keys.Left:
                    player.MovingPiece(tmp.XIndex,tmp.YIndex + 1, ref moveIndex);
                    break;
                case Keys.Right:
                    player.MovingPiece(tmp.XIndex, tmp.YIndex - 1, ref moveIndex);
                    break;
            }
            if(moveIndex==-1)
                return false;
            ((Piece)player.imgPieces[player.BlackBox_Indx]).SwapPieces((Piece)player.imgPieces[moveIndex]);
            player.BlackBox_Indx = moveIndex;

            if (GameManager.Instance.UpdateStatus(player.imgPieces,tmp, (Piece)player.imgPieces[moveIndex]))
                GameManager.Instance.IsWin();
            return true;
        }

        private void Player_Load(object sender, EventArgs e)
        {
            player.StartGame();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameManager.Instance.PlayTime--;
            if(GameManager.Instance.PlayTime==0)
                GameManager.Instance.IsLose();
        }
    }
}
