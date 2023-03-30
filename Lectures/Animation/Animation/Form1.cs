using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Form1 : Form
    {
        //global level variable
        private int xspeed = 10;    
        public Form1()
        {
            InitializeComponent();
        }

        private void Lblinvader_Click(object sender, EventArgs e)
        {

        }

        private void movealien()
        {
            //moves alien left and right

            if (lblinvader.Right > this.Width)
            {
                xspeed *= -1;
            }

            else if (lblinvader.Left < 0)
            {
                xspeed *= -1;
            }

            lblinvader.Left += xspeed;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            movealien();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lbloutput.Text = e.KeyValue.ToString();
            int whichkey = e.KeyValue;
            //lfet arrow key
            if (whichkey == 37)
            {
                lblspaceship.Left -= 10;
            }

            //move right arrow
            else if (whichkey == 39)
            {
                lblspaceship.Left += 10;
            }

            if (timer2.Enabled == false)
            {
                lblbullet.Left = lblspaceship.Left + lblspaceship.Width / 2;
                lblbullet.Top = lblspaceship.Top - 10;
            }

            if (whichkey == 32)
            {
                timer2.Enabled = true;
            }
        }

            //function to move bullet



        private void movebullet()
        {
            if (lblbullet.Top < 0)
            {
                lblbullet.Left = lblspaceship.Left + lblspaceship.Width / 2;
                lblbullet.Top = lblspaceship.Top - 10;
                timer2.Enabled = false;
            }
           
            lblbullet.Top -= 10;

            if  (lblbullet.Left > lblinvader.Left && lblbullet.Right < lblinvader.Right &&
            lblbullet.Top < lblinvader.Bottom && lblbullet.Top > lblinvader.Top)
            {
                lblbullet.Left = lblspaceship.Left + lblspaceship.Width / 2;
                lblbullet.Top = lblspaceship.Top - 10;
                timer2.Enabled = false;
                lblinvader.Top -= 20;
            }

            }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            movebullet();
        }
    }
}
