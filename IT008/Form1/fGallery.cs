using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void buttonADDIMAGE_Click(object sender, EventArgs e)
        {
            var formAddimage = new fAddImage();
            formAddimage.Show();
        }
    }
}
