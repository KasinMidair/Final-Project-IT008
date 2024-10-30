using Form1.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames.Image;

namespace Form1
{
    public partial class fGallery : Form
    {
        public fGallery()
        {
            InitializeComponent();
        }

        private void buttonBACK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            var formAddimage = new fAddImage();
            formAddimage.Show();
        }

        private void buttonRENAME_Click(object sender, EventArgs e)
        {

        }

        private void buttonDELLETE_Click(object sender, EventArgs e)
        {

        }

        private List<Image> LoadedImages { get; set; }
        private void fGallery_Load(object sender, EventArgs e)
        {
            LoadImagesFromFolder();

            ImageList images = new ImageList();
            images.ImageSize = new System.Drawing.Size(50, 50);


            foreach (var Image in LoadedImages)
            {
                images.Images.Add(Image);
            }

            imageList.LargeImageList = images;
        }

        private void LoadImagesFromFolder()
        {
            LoadedImages = new List<Image>();
            
        }
    }
}
