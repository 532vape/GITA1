using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fish_2D
{
    /*David Lim
     * 11-20-19
     * period 5
     * This program simulates the 2D movement of a fish from the left to the right side of the tank
     * it tracks how many times the fish has moved and how many times it has bumped the right/left,
     * you can either manually move the fish or make it automatic
     * you can also slow down/speed up the fish (there are caps preventing the fish from going
     * too slow/fast
     */

    public partial class Form1 : Form
    {
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        Boolean onoff = false;
        PictureBox[] theTank = new PictureBox[8];
        private decimal mover;
        private decimal touchleft;
        private decimal touchright;
        private int randompos = 0;
        private int fishpos = 0;
        private int timesmoved;


        public Form1()
        {
            InitializeComponent();
        }

        private void Picfish_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)//btnmove
        {
            //this randomly places the fish in a box
            movefish();
        }

        private void Btnauto_Click(object sender, EventArgs e)
        {
                //this turns timer on/off
                if (onoff == false)
                {
                    timer1.Enabled = true;
                    onoff = true;
                }
                else if (onoff == true)
                {
                    timer1.Enabled = false;
                    onoff = false;
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this runs code one time for setup purposes
            theTank[0] = picbox0;
            theTank[1] = picbox1;
            theTank[2] = picbox2;
            theTank[3] = picbox3;
            theTank[4] = picbox4;
            theTank[5] = picbox5;
            theTank[6] = picbox6;
            theTank[7] = picbox7;
            randompos = r.Next(0, 8);
            theTank[randompos].Image = picfish.Image;
            fishpos = randompos;
        }

        private void movefish()
        {
            //randomly moves the fish without having to click multiple times
            theTank[fishpos].Image = null;
            theTank[randompos].Image = null;
            mover = r.Next(0, 2);
            

            if (mover == 0)
            {
                fishpos -= 1;
                picmover.Image = picfish.Image;

                if (fishpos < 0)
                {
                    touchleft += 1;
                    fishpos = 0;
                    //tracks how many times the fish bumped the left side of the tank
                    lblbumpsleft.Text = touchleft.ToString();
                }

                if (fishpos > 0 && fishpos < 7)
                {
                    timesmoved += 1;
                    //tracks how many times the fish moved, excluding bumps
                    lbltimesmoved.Text = timesmoved.ToString();
                }
            }

            else if (mover == 1)
            {
                fishpos += 1;
                picmover.Image = picfishinv.Image;

                if (fishpos > 7)
                {
                    touchright += 1;
                    fishpos = 7;
                    //tracks how many times the fish bumped the right side of the tank
                    lblbumpsright.Text = touchright.ToString();
                }

                if (fishpos > 0 && fishpos < 7)
                {
                    timesmoved += 1;
                    //tracks how many times the fish moved, excluding bumps
                    lbltimesmoved.Text = timesmoved.ToString();
                }
            }
            theTank[fishpos].Image = picmover.Image;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            movefish();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Btnfaster_Click(object sender, EventArgs e)
        {
            //caps how fast the fish goes
            timer1.Interval -= 10;
            if (timer1.Interval < 50)
            {
                timer1.Interval = 50;
            }
        }

        private void Btnslower_Click(object sender, EventArgs e)
        {
            //caps how slow the fish goes
            timer1.Interval += 100;
            if (timer1.Interval > 500)
            {
                timer1.Interval = 500;
            }
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        private void Picbox0_Click(object sender, EventArgs e)
        {

        }
    }
}
