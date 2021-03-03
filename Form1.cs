using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            downPipe_pictureBox.Left -= pipeSpeed;
            upPipe_pictureBox.Left -= pipeSpeed;
            bird_pictureBox.Top += gravity;
            score_label.Text = "SCORE: " + score.ToString();
            if (downPipe_pictureBox.Left < -80)
            {
                downPipe_pictureBox.Left = random.Next(360,500);
                score++;
            }
            if(upPipe_pictureBox.Left < -80)
            {
                upPipe_pictureBox.Left = random.Next(360, 500);
                score++;
            }
             if(score > 1 && score % 10 == 0)
            {
                pipeSpeed += 2;
            }
            if(bird_pictureBox.Bounds.IntersectsWith(downPipe_pictureBox.Bounds) 
                || bird_pictureBox.Bounds.IntersectsWith(upPipe_pictureBox.Bounds)
                || bird_pictureBox.Bounds.IntersectsWith(ground_pictureBox.Bounds))
            {
                timer1.Stop();
                end_label.Text = "SCORE:\n" + score;
                end_pictureBox.Visible = end_label.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (bird_pictureBox.Top > 0 && bird_pictureBox.Top < 452)
                {
                    gravity = -5;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (bird_pictureBox.Top > 0 && bird_pictureBox.Top < 452)
                {
                    gravity = 5;
                }
            }
        }
    }
}
