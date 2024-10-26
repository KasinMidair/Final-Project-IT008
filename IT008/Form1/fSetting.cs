using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class fSetting : Form
    {
        public fSetting()
        {
            InitializeComponent();
        }

        private void checkBoxBackgroundMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBackgroundMusic.Checked == true)
            {
                BackgroundMusicPlayer("Audio\\BackgroudMusic1");
            }
        }

        public static void BackgroundMusicPlayer(string filepath)
        {
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = filepath;
            musicPlayer.PlayLooping();
        }
    }
}
