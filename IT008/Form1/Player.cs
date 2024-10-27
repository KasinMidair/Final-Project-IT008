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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form1
{
    public partial class Player : Form
    {
        bool fullMatch;
        List<PictureBox> imgPieces;
        Image img;
        Image tmpImg;
        int BlackBox_Indx;
        int unit;

        public Player()
        {
            InitializeComponent();
            imgPieces = new List<PictureBox>();
            img = Image.FromFile("D:\\Final-Project-IT008\\IT008\\Form1\\bin\\Debug\\Sprite-0002.png");
            tmpImg = Image.FromFile("D:\\Final-Project-IT008\\IT008\\Form1\\bin\\Debug\\Sprite-0003.png");
            fullMatch = false;
            unit = img.Size.Width / GameManager.Instance.col;
            BlackBox_Indx = GameManager.Instance.col * GameManager.Instance.row - 1;
            StartGame();
        }
        /// <summary>
        /// Create a bitmap to set Image for Splited Image 
        /// </summary>
        /// <param name="imgs"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public Bitmap CreateBitmap(Image imgs, int x, int y,  int width,int height)
        {
            Bitmap bitmap = new Bitmap(width,height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            g.DrawImage(imgs, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
            g.Flush();      
            return bitmap;
        }

        /// <summary>
        /// split original image into row X col piece
        /// </summary>
        public void SplitIntoPieces()
        {
            int index = 0;
            int i,j;
            imgPieces.Clear();
            Bitmap pieceImg;
            for (i = 0; i < GameManager.Instance.row ; ++i)
            {
                for(j=0 ;j< GameManager.Instance.col;++j)
                {
                    if (BlackBox_Indx == (i * GameManager.Instance.col + j))
                    {
                        pieceImg = CreateBitmap(tmpImg,0,0, unit, unit);
                    }
                    else 
                    {
                        pieceImg = CreateBitmap(img, j * unit, i * unit, unit, unit);
                    }
                    imgPieces.Add(new Piece(i,j, index++, pieceImg) { Location= new Point(j*unit,i*unit),
                    SizeMode=PictureBoxSizeMode.StretchImage,Width=unit,Height=unit});
                }
               
            }

        }
         
        private void Player_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Add Piece into Controls of pnlGamePlaySpace and Playing
        /// </summary>
        public void StartGame()
        {
            
            if (GameManager.Instance.Status == GameStatus.StartGame)
            {
                SplitIntoPieces();
                Shuffle();
            }
            if (imgPieces == null)
                return;
            panel1.Size= new Size(img.Width+20, img.Height+150);
            pnlGamePlaySpace.Size = new Size(img.Width, img.Height);
            imgPieces.ForEach(imgs => { 
                pnlGamePlaySpace.Controls.Add(imgs);
            });
            pnlGamePlaySpace.Refresh();
            //timer1.Start();

        }
        /// <summary>
        /// countdown playing time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (--GameManager.Instance.PlayTime == 0)
            {
                IsLose();
            }
        }

        public void IsLose()
        {
            GameManager.Instance.Status = GameStatus.EndGame;
            MessageBox.Show("Lose!");
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
            Piece tmp = (Piece)imgPieces[BlackBox_Indx];
            switch (keyData)
            {
                case Keys.Down:
                    MovingPiece(tmp.XIndex-1, tmp.YIndex, ref moveIndex);
                    break;
                case Keys.Up:
                    MovingPiece(tmp.XIndex+1, tmp.YIndex, ref moveIndex);
                    break;
                case Keys.Left:
                    MovingPiece(tmp.XIndex,tmp.YIndex + 1, ref moveIndex);
                    break;
                case Keys.Right:
                    MovingPiece(tmp.XIndex, tmp.YIndex - 1, ref moveIndex);
                    break;
            }
            if(moveIndex==-1)
                return false;
            tmp.SwapPieces((Piece)imgPieces[moveIndex]);
            BlackBox_Indx = moveIndex;
            UpdateStatus(tmp,(Piece) imgPieces[moveIndex]);

            if (fullMatch==true)
                Win();
            return true;
        }
        /// <summary>
        /// add status of 2 piece after moving
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        public bool UpdateStatus(Piece p1, Piece p2)
        {
            for (int i = 0; i < GameManager.Instance.row*GameManager.Instance.col-1; ++i)
            {
                if (!((Piece)imgPieces[i]).Match())
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// check the constraint after moving piece
        /// </summary>
        /// <param name="mxPos"></param>
        /// <param name="myPos"></param>
        /// <param name="mPos"></param>
        public void MovingPiece(int mxPos,int myPos,ref int mPos)
        {
            if (mxPos > -1 && myPos < GameManager.Instance.col && myPos > -1 && mxPos < GameManager.Instance.row)
            { 
                mPos= mxPos * GameManager.Instance.col + myPos;
            }
            else
                mPos=-1;
        }

        public void Win()
        {
            MessageBox.Show("win");
        }
        public void Shuffle()
        {
            int pieceIndex = 0;
            Random random = new Random();
            imgPieces.ForEach(p =>
            {
                int randIndex = random.Next(pieceIndex++, imgPieces.Count);
                if(randIndex==BlackBox_Indx)
                    BlackBox_Indx=imgPieces.IndexOf(p);
                ((Piece)p).SwapPieces((Piece)imgPieces[randIndex]);
            });
        }


    }
}
