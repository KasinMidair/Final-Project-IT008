using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class fAddImage : Form
    {
        public fAddImage()
        {
            InitializeComponent();
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCHOOSEIMAGE_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            File.Copy(textBox1.Text, Path.Combine("F:\\School\\IT008\\Final-Project-IT008\\IT008\\Form1\\Resources\\image\\", Path.GetFileName(textBox1.Text)), true);
            MessageBox.Show("Image Added");
        }
    }
}
