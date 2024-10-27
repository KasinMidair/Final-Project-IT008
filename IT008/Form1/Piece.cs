using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Form1
{
    public class Piece:PictureBox
    {
        int yIndex;
        int imgIdx;
        int xIndex;
        public int ImgIdx
        {
            set
            {
                imgIdx = value;
            }
            get
            {
                return imgIdx;
            }
        }
        public int XIndex
        {
            set
            {
                xIndex = value;
            }
            get
            {
                return xIndex;
            }
        }
        public int YIndex
        {
            set
            {
                yIndex = value;
            }
            get
            {
                return yIndex;
            }
        }
        public Piece(Piece p)
        {
           
            this.imgIdx = p.imgIdx;
            this.xIndex = p.xIndex;
            this.yIndex = p.yIndex;
            this.SizeMode = PictureBoxSizeMode.AutoSize;    
            this.Width = p.Width;
            this.Height = p.Height;
            this.Image=p.Image;
        }
        public Piece(int xindex,int yindex,int fimgIndx,Image img)
        {
            this.imgIdx = fimgIndx;
            this.xIndex = xindex;
            this.yIndex = yindex;
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Width = img.Width;
            this.Height = img.Height;
            this.Image = img;
        }
        public void SwapPieces(Piece p2)
        {
            Image img = this.Image;
            int tmpImgIdx=this.imgIdx;
            this.Image = p2.Image;
            this.imgIdx = p2.imgIdx;
            p2.Image = img;
            p2.imgIdx =tmpImgIdx;

        }
        public bool Match()
        {
            return xIndex*GameManager.Instance.col + yIndex == imgIdx;
        }
        public int CurrentImgIndex()
        {
            return xIndex * GameManager.Instance.col + yIndex;
 }
    }
}
