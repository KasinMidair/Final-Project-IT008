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
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void buttonSETTING_Click(object sender, EventArgs e)
        {
            var formSetting = new fSetting();
            formSetting.Show();
        }

        private void buttonPLAY_Click(object sender, EventArgs e)
        {
            var formPlayer = new Player();
            formPlayer.Show();
        }
    }
}
