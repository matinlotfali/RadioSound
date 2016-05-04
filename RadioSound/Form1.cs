using System;
using System.Windows.Forms;
using System.Media;
using RadioSound.Properties;

namespace RadioSound
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(Resources.radio);
        bool isPlaying = false;

        public Form1()
        {
            InitializeComponent();
            button3_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            player.PlayLooping();
            isPlaying = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            timer1.Enabled = false;
            player.Stop();
            isPlaying = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour >= 8)
            {
                player.Stop();
                isPlaying = false;
            }
            else if (!isPlaying)
                player.PlayLooping();
        }
    }
}
