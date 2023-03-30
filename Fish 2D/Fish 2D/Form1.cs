using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*David Lim
 * GITA 1 per 5
 * 12-9-19
 * this program simulates a fish swimming around in an aquarium with a predator fish trying to eat it
 * it swims in an 3x8 environment
 * the fish can move up, down, left, right 1 space
 * if the fish is eaten it is placed in another random space
 */



namespace Fish_2D
{

    public partial class Fish2D : Form
    {
        //global variables
        //declare 2d array
        PictureBox[,] theTank = new PictureBox[3, 8];
        PictureBox[,] theShark = new PictureBox[3, 8];
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        Boolean onoff = false;
        private decimal touchleft;
        private decimal touchright;
        private int timesmoved;
        private int bumpsbottom;
        private int bumpstop;

        private int fishposX = 1;
        private int fishposY = 1;
        private int fishposupdown = 1;
        private decimal fish;

        private int sharkposupdown = 1;
        private int sharkposX = 1;
        private int sharkposY = 1;
        private decimal shark;


        public Fish2D()
        {
            InitializeComponent();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this runs code one time to set things ups
            //set up the tank
            //set up the first row
            theTank[0, 0] = picbox0;
            theTank[0, 1] = picbox1;
            theTank[0, 2] = picbox2;
            theTank[0, 3] = picbox3;
            theTank[0, 4] = picbox4;
            theTank[0, 5] = picbox5;
            theTank[0, 6] = picbox6;
            theTank[0, 7] = picbox7;

            //set up the second row
            theTank[1, 0] = picbox8;
            theTank[1, 1] = picbox9;
            theTank[1, 2] = picbox10;
            theTank[1, 3] = picbox11;
            theTank[1, 4] = picbox12;
            theTank[1, 5] = picbox13;
            theTank[1, 6] = picbox14;
            theTank[1, 7] = picbox15;

            //set up the third row
            theTank[2, 0] = picbox16;
            theTank[2, 1] = picbox17;
            theTank[2, 2] = picbox18;
            theTank[2, 3] = picbox19;
            theTank[2, 4] = picbox20;
            theTank[2, 5] = picbox21;
            theTank[2, 6] = picbox22;
            theTank[2, 7] = picbox23;


            //set up the first row
            theShark[0, 0] = picbox0;
            theShark[0, 1] = picbox1;
            theShark[0, 2] = picbox2;
            theShark[0, 3] = picbox3;
            theShark[0, 4] = picbox4;
            theShark[0, 5] = picbox5;
            theShark[0, 6] = picbox6;
            theShark[0, 7] = picbox7;

            //set up the second row
            theShark[1, 0] = picbox8;
            theShark[1, 1] = picbox9;
            theShark[1, 2] = picbox10;
            theShark[1, 3] = picbox11;
            theShark[1, 4] = picbox12;
            theShark[1, 5] = picbox13;
            theShark[1, 6] = picbox14;
            theShark[1, 7] = picbox15;

            //set up the third row
            theShark[2, 0] = picbox16;
            theShark[2, 1] = picbox17;
            theShark[2, 2] = picbox18;
            theShark[2, 3] = picbox19;
            theShark[2, 4] = picbox20;
            theShark[2, 5] = picbox21;
            theShark[2, 6] = picbox22;
            theShark[2, 7] = picbox23;



            fishposX = r.Next(0, 3);
            fishposY = r.Next(0, 8);

            sharkposX = r.Next(0, 3);
            sharkposY = r.Next(0, 8);

            //draw the fish
            theTank[fishposX, fishposY].Image = picfish.Image;

            theShark[sharkposX, sharkposY].Image = picshark.Image;
        }

        private void movefish()
        {
            theTank[fishposX, fishposY].Image = null;
            fishposupdown = r.Next(0, 2);
            fish = r.Next(0, 2);

            theShark[sharkposX, sharkposY].Image = null;
            sharkposupdown = r.Next(0, 2);
            shark = r.Next(0, 2);

            //draw the fish

            timesmoved += 1;
            lbltimesmoved.Text = timesmoved.ToString();
            if (fish == 0)
            {
                fishposY -= 1;
                picfish.Image = picfishleft.Image;

                if (fishposupdown == 0)
                {
                    fishposX -= 1;
                }

                if (fishposX > 2)
                {
                    fishposX = 2;
                    bumpsbottom += 1;
                    lblbumpsbottom.Text = bumpsbottom.ToString();
                }

                if (fishposX < 0)
                {
                    fishposX = 0;
                    bumpstop += 1;
                    lblbumpstop.Text = bumpstop.ToString();
                }

                if (fishposY > 7)
                {
                    fishposY = 7;
                    touchright += 1;
                    lblbumpsright.Text = touchright.ToString();
                }

                if (fishposY < 0)
                {
                    fishposY = 0;
                    touchleft += 1;
                    lblbumpsleft.Text = touchleft.ToString();
                }
            }

            if (fish == 1)
            {
                fishposY += 1;
                picfish.Image = picfishright.Image;

                if (fishposupdown == 1)
                {
                    fishposX += 1;
                }

                if (fishposX > 2)
                {
                    fishposX = 2;
                    bumpsbottom += 1;
                    lblbumpsbottom.Text = bumpsbottom.ToString();
                }

                if (fishposX < 0)
                {
                    fishposX = 0;
                    bumpstop += 1;
                    lblbumpstop.Text = bumpstop.ToString();
                }

                if (fishposY > 7)
                {
                    fishposY = 7;
                    touchright += 1;
                    lblbumpsright.Text = touchright.ToString();
                }

                if (fishposY < 0)
                {
                    fishposY = 0;
                    touchleft += 1;
                    lblbumpsleft.Text = touchleft.ToString();
                }
            }

            //draw the shark
            if (shark == 0)
            {
                sharkposY -= 1;
                picshark.Image = picsharkleft.Image;

                if (sharkposupdown == 0)
                {
                    sharkposX -= 1;
                }

                if (sharkposX > 2)
                {
                    sharkposX = 2;
                    bumpsbottom += 1;
                    lblbumpsbottom.Text = bumpsbottom.ToString();
                }

                if (sharkposX < 0)
                {
                    sharkposX = 0;
                    bumpstop += 1;
                    lblbumpstop.Text = bumpstop.ToString();
                }

                if (sharkposY > 7)
                {
                    sharkposY = 7;
                    touchright += 1;
                    lblbumpsright.Text = touchright.ToString();
                }

                if (sharkposY < 0)
                {
                    sharkposY = 0;
                    touchleft += 1;
                    lblbumpsleft.Text = touchleft.ToString();
                }
            }

            if (shark == 1)
            {
                sharkposY += 1;
                picshark.Image = picsharkright.Image;

                if (sharkposupdown == 1)
                {
                    sharkposX += 1;
                }

                if (sharkposX > 2)
                {
                    sharkposX = 2;
                    bumpsbottom += 1;
                    lblbumpsbottom.Text = bumpsbottom.ToString();
                }

                if (sharkposX < 0)
                {
                    sharkposX = 0;
                    bumpstop += 1;
                    lblbumpstop.Text = bumpstop.ToString();
                }

                if (sharkposY > 7)
                {
                    sharkposY = 7;
                    touchright += 1;
                    lblbumpsright.Text = touchright.ToString();
                }

                if (sharkposY < 0)
                {
                    sharkposY = 0;
                    touchleft += 1;
                    lblbumpsleft.Text = touchleft.ToString();
                }
            }

            theTank[fishposX, fishposY].Image = picfish.Image;
            theShark[sharkposX, sharkposY].Image = picshark.Image;

            if (fishposY == sharkposY && fishposX == sharkposX)
            {
                //set up the first row
                theTank[0, 0] = picbox0;
                theTank[0, 1] = picbox1;
                theTank[0, 2] = picbox2;
                theTank[0, 3] = picbox3;
                theTank[0, 4] = picbox4;
                theTank[0, 5] = picbox5;
                theTank[0, 6] = picbox6;
                theTank[0, 7] = picbox7;

                //set up the second row
                theTank[1, 0] = picbox8;
                theTank[1, 1] = picbox9;
                theTank[1, 2] = picbox10;
                theTank[1, 3] = picbox11;
                theTank[1, 4] = picbox12;
                theTank[1, 5] = picbox13;
                theTank[1, 6] = picbox14;
                theTank[1, 7] = picbox15;

                //set up the third row
                theTank[2, 0] = picbox16;
                theTank[2, 1] = picbox17;
                theTank[2, 2] = picbox18;
                theTank[2, 3] = picbox19;
                theTank[2, 4] = picbox20;
                theTank[2, 5] = picbox21;
                theTank[2, 6] = picbox22;
                theTank[2, 7] = picbox23;

                fishposX = r.Next(0, 3);
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
                    fishposY = r.Next(0, 8);

                    theTank[fishposX, fishposY].Image = picfish.Image;

                    onoff = false;
                    timer1.Enabled = false;
                    MessageBox.Show("The fish was eaten");
                }
            }
        }

        private void Btnmove_Click(object sender, EventArgs e)
        {
            movefish();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Picsharkright_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            movefish();
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

        private void Btnfaster_Click(object sender, EventArgs e)
        {
            //caps how fast the fish goes
            timer1.Interval -= 10;
            if (timer1.Interval < 50)
            {
                timer1.Interval = 50;
            }
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

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
