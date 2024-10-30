using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Form1
{
    internal class GameRound
    {
        public List<PictureBox> imgPieces;
        Image img;
        Image tmpImg;
        public int BlackBox_Indx;
        Panel pnlContainer;
        Panel pnlGamePlaySpace;
        public GameRound(Panel Container,Panel GamePlaySpace)
        {
            imgPieces = new List<PictureBox>();
            img = Image.FromFile("D:\\Final-Project-IT008\\IT008\\Form1\\bin\\Debug\\Sprite-0002.png");
            tmpImg = Image.FromFile("D:\\Final-Project-IT008\\IT008\\Form1\\bin\\Debug\\Sprite-0003.png");
            pnlContainer = Container;
            pnlGamePlaySpace = GamePlaySpace;
            BlackBox_Indx = GameManager.Instance.col * GameManager.Instance.row - 1;
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
            pnlContainer.Size = new Size(img.Width + 20, img.Height + 150);
            pnlGamePlaySpace.Size = GameManager.Instance.imgsize;
            imgPieces.ForEach(imgs => {
                pnlGamePlaySpace.Controls.Add(imgs);
            });
            pnlGamePlaySpace.Refresh();


        }


        /// <summary>
        /// split original image into row X col piece
        /// </summary>
        public void SplitIntoPieces()
        {
            int index = 0;
            int i, j;
            imgPieces.Clear();
            Bitmap pieceImg;
            for (i = 0; i < GameManager.Instance.row; ++i)
            {
                for (j = 0; j < GameManager.Instance.col; ++j)
                {
                    if (BlackBox_Indx == (i * GameManager.Instance.col + j))
                    {
                        pieceImg = CreateBitmap(tmpImg, 0, 0, GameManager.Instance.UnitX, GameManager.Instance.UnitY);
                    }
                    else
                    {
                        pieceImg = CreateBitmap(img, j * GameManager.Instance.UnitX, i * GameManager.Instance.UnitY, GameManager.Instance.UnitX, GameManager.Instance.UnitY);
                    }
                    imgPieces.Add(new Piece(i, j, index++, pieceImg)
                    {
                        Location = new Point(j * GameManager.Instance.UnitX, i * GameManager.Instance.UnitY),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = GameManager.Instance.UnitX,
                        Height = GameManager.Instance.UnitY
                    });
                }

            }

        }


        /// <summary>
        /// using  Fisher-Yates algorithm( Knuth shuffle algorithm ) to shuffle all the pieces.
        /// The Fisher-Yates algorithm is a popular algorithm 
        /// for randomly shuffling a list of elements so that each element has an equal probability 
        /// of appearing in each position.
        /// </summary>
        public void Shuffle()
        {
            int pieceIndex = 0;
            Random random = new Random();
            imgPieces.ForEach(p =>
            {
                int randIndex = random.Next(pieceIndex++, imgPieces.Count);
                if (randIndex == BlackBox_Indx)
                    BlackBox_Indx = imgPieces.IndexOf(p);
                ((Piece)p).SwapPieces((Piece)imgPieces[randIndex]);
            });
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
        public Bitmap CreateBitmap(Image imgs, int x, int y, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            g.DrawImage(imgs, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
            g.Flush();
            return bitmap;
        }


        /// <summary>
        ///check constraints and determine blackbox coordinates
        /// </summary>
        /// <param name="mxPos"></param>
        /// <param name="myPos"></param>
        /// <param name="mPos"></param>
        public void MovingPiece(int mxPos, int myPos, ref int mPos)
        {
            if (mxPos > -1 && myPos < GameManager.Instance.col && myPos > -1 && mxPos < GameManager.Instance.row)
            {
                mPos = mxPos * GameManager.Instance.col + myPos;
            }
            else
                mPos = -1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (--GameManager.Instance.PlayTime == 0)
            {
                GameManager.Instance.IsLose();
            }
        }
    }
}
