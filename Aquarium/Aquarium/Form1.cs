using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarium
{
    public partial class Form1 : Form
    {
        /*David Lim
         *Period 5
         * 2/15/2020
         * this program simulates an aquarium, with fish moving around and a shark chasing after them
         * there is also a boat that catches the fish
         */
        PictureBox[] theBox = new PictureBox[20];
        PictureBox[] bubbles = new PictureBox[20];
        PictureBox[] metaknight = new PictureBox[1];
        PictureBox[] halberd = new PictureBox[1];
        PictureBox[] net = new PictureBox[1];
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        private int i = 0;
        private int Hit = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void movekirb()
        {
            //move the "fish"

            //set the direction of the "fish"
            for (int i = 0; i < theBox.Length; i++)
            {
                int direction = r.Next(0, 2);
                int updown = r.Next(0, 2);

                if (theBox[i].Left > net[0].Left && theBox[i].Right < net[0].Right && theBox[i].Top > net[0].Top
     && theBox[i].Top < net[0].Bottom && theBox[i].Enabled == true)
                {
                    //hit code for net and predator
                    if (Hit == 0)
                    {
                        Hit = i;
                        Hit = 1;
                        theBox[i].Enabled = false;
                        timer6.Enabled = true;

                        if (theBox[i].Enabled == false)
                        {
                            theBox[i].Visible = false;
                        }
                    }
                    else if (Hit == 1)
                    {
                        theBox[i].Visible = false;
                        theBox[i].Enabled = false;
                    }
                }

                if (theBox[i].Left > picmetaknight.Left && theBox[i].Right < picmetaknight.Right &&
theBox[i].Top > picmetaknight.Top && theBox[i].Top < picmetaknight.Bottom && theBox[i].Enabled == true)
                    {
                        theBox[i].Image = pickirbyisdead.Image;
                        theBox[i].Top = 400;
                        theBox[i].Enabled = false;
                    }

                //fish move
                if (theBox[i].Enabled == true)
                {

                    if (direction == 0)
                    {
                        theBox[i].Image = pickirbyleft.Image;
                        theBox[i].Left -= 7;

                        if (theBox[i].Left <= 0)
                        {
                            theBox[i].Left += 7;
                        }
                    }

                    else if (direction == 1)
                    {
                        theBox[i].Image = pickirbyright.Image;
                        theBox[i].Left += 7;

                        if (theBox[i].Left >= 1000)
                        {
                            theBox[i].Left -= 7;
                        }
                    }

                    if (updown == 0)
                    {
                        theBox[i].Top += 7;

                        if (theBox[i].Top >= 416)
                        {
                            theBox[i].Top -= 7;
                        }
                    }

                    else if (updown == 1)
                    {
                        theBox[i].Top -= 7;

                        if (theBox[i].Top <= 227)
                        {
                            theBox[i].Top += 7;
                        }
                    }
                }
            }
        }
    

        private void metaknights()
        {
            //move the predator
            for (int i = 0; i < metaknight.Length || i < theBox.Length; i++)
            {
                int direction = r.Next(0, 10);
                int updown = r.Next(0, 10);

                if (direction == 0 || direction == 2 || direction == 4 || direction == 6 ||
                    direction == 8)
                {
                    metaknight[0].Image = picmetaknightleft.Image;
                    metaknight[0].Left -= 4;

                    if (metaknight[0].Left <= 0)
                    {
                        metaknight[0].Left += 4;
                    }
                }

                else if (direction == 1 || direction == 3 || direction == 5 || direction == 7
                    || direction == 9)
                {
                     metaknight[0].Image = picmetaknightright.Image;
                     metaknight[0].Left += 4;

                     if (metaknight[0].Left >= 1000)
                     {
                        metaknight[0].Left -= 4;
                     }
                }

                if (updown == 0 || updown == 2 || updown == 4 || updown == 6 || updown == 8)
                {
                    metaknight[0].Top += 4;

                    if (metaknight[0].Top >= 416)
                    {
                        metaknight[0].Top -= 4;
                    }
                }

                else if (updown == 1 || updown == 3 || updown == 5 || updown == 7 || updown == 9)
                {
                    metaknight[0].Top -= 4;

                    if (metaknight[0].Top <= 227)
                    {
                        metaknight[0].Top += 4;
                    }
                }

                
            }
        }
        private void bubble()
        {
            //move the bubbles up
            for (int n = 0; n < bubbles.Length; n++)
            {
                int movebubble = r.Next(0, 2);
                int leftright = r.Next(0, 2);

                if (movebubble == 0)
                {
                    bubbles[n].Top -= 10;
                }

                else if (movebubble == 1)
                {
                    bubbles[n].Top -= 10;
                }

                if (leftright == 0)
                {
                    bubbles[n].Left += 7;

                }

                else if (leftright == 1)
                {
                    bubbles[n].Left -= 7;

                }

                if (bubbles[n].Top <= 227)
                {
                    bubbles[n].Top = 500;
                }
            }
        }

        private void movehalberd()
        {
            for (int n = 0; n < halberd.Length; n++)
            {
                int leftright = r.Next(0, 8);

                if (leftright == 0 || leftright == 2 || leftright == 4 || leftright == 6)
                {
                    pichalberd.Image = pichalberdleft.Image;
                    halberd[n].Left -= 10;
                    picnet.Image = picnetleft.Image;
                    picnet.Left = halberd[n].Left + (278 - 75);
                    if (halberd[0].Left <= 0)
                        {
                            halberd[0].Left += 10;
                        }
                }

                else if (leftright == 1 || leftright == 3 || leftright == 5 || leftright == 7)
                {
                    halberd[n].Left += 10;
                    pichalberd.Image = pichalberdright.Image;
                    picnet.Image = picnetright.Image;
                    picnet.Left = halberd[n].Left;
                    if (halberd[0].Left >= 722)
                    {
                        halberd[0].Left -= 10;
                    }
                }
            }
        }
            
        private void Timer1_Tick(object sender, EventArgs e)
        {
            movekirb();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load the form
            theBox[0] = pic0;
            theBox[1] = pic1;
            theBox[2] = pic2;
            theBox[3] = pic3;
            theBox[4] = pic4;
            theBox[5] = pic5;
            theBox[6] = pic6;
            theBox[7] = pic7;
            theBox[8] = pic8;
            theBox[9] = pic9;
            theBox[10] = pic10;
            theBox[11] = pic11;
            theBox[12] = pic12;
            theBox[13] = pic13;
            theBox[14] = pic14;
            theBox[15] = pic15;
            theBox[16] = pic16;
            theBox[17] = pic17;
            theBox[18] = pic18;
            theBox[19] = pic19;

            bubbles[0] = picbubble0;
            bubbles[1] = picbubble1;
            bubbles[2] = picbubble2;
            bubbles[3] = picbubble3;
            bubbles[4] = picbubble4;
            bubbles[5] = picbubble5;
            bubbles[6] = picbubble6;
            bubbles[7] = picbubble7;
            bubbles[8] = picbubble8;
            bubbles[9] = picbubble9;
            bubbles[10] = picbubble10;
            bubbles[11] = picbubble11;
            bubbles[12] = picbubble12;
            bubbles[13] = picbubble13;
            bubbles[14] = picbubble14;
            bubbles[15] = picbubble15;
            bubbles[16] = picbubble16;
            bubbles[17] = picbubble17;
            bubbles[18] = picbubble18;
            bubbles[19] = picbubble19;

            metaknight[0] = picmetaknight;

            halberd[0] = pichalberd;

            net[0] = picnet;

            //place the entities in random positions
            for (int n = 0; n < theBox.Length; n++)
            {
                int randomx = r.Next(0, 1000);
                int randomy = r.Next(227, 416);

                theBox[n].Left = randomx;
                theBox[n].Top = randomy;

            }

            for (int n = 0; n < bubbles.Length; n++)
            {
                int randomx = r.Next(0, 1000);
                int randomy = r.Next(227, 416);

                bubbles[n].Left = randomx;
                bubbles[n].Top = randomy;
            }

            for (int n = 0; n < metaknight.Length; n++)
            {
                int randomx = r.Next(0, 1000);
                int randomy = r.Next(227, 416);

                metaknight[n].Left = randomx;
                metaknight[n].Top = randomy;
            }

            for (int n = 0; n < halberd.Length; n++)
            {
                int randomx = r.Next(227, 1000);

                pichalberd.Left = randomx;
                pichalberd.Top = 25;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            bubble();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            metaknights();
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            movehalberd();
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theBox[0] = pic0;
            theBox[1] = pic1;
            theBox[2] = pic2;
            theBox[3] = pic3;
            theBox[4] = pic4;
            theBox[5] = pic5;
            theBox[6] = pic6;
            theBox[7] = pic7;
            theBox[8] = pic8;
            theBox[9] = pic9;
            theBox[10] = pic10;
            theBox[11] = pic11;
            theBox[12] = pic12;
            theBox[13] = pic13;
            theBox[14] = pic14;
            theBox[15] = pic15;
            theBox[16] = pic16;
            theBox[17] = pic17;
            theBox[18] = pic18;
            theBox[19] = pic19;

            bubbles[0] = picbubble0;
            bubbles[1] = picbubble1;
            bubbles[2] = picbubble2;
            bubbles[3] = picbubble3;
            bubbles[4] = picbubble4;
            bubbles[5] = picbubble5;
            bubbles[6] = picbubble6;
            bubbles[7] = picbubble7;
            bubbles[8] = picbubble8;
            bubbles[9] = picbubble9;
            bubbles[10] = picbubble10;
            bubbles[11] = picbubble11;
            bubbles[12] = picbubble12;
            bubbles[13] = picbubble13;
            bubbles[14] = picbubble14;
            bubbles[15] = picbubble15;
            bubbles[16] = picbubble16;
            bubbles[17] = picbubble17;
            bubbles[18] = picbubble18;
            bubbles[19] = picbubble19;

            metaknight[0] = picmetaknight;

            halberd[0] = pichalberd;

            net[0] = picnet;

            theBox[i].Image = pickirbyleft.Image;

            for (int n = 0; n < theBox.Length; n++)
            {
                int randomx = r.Next(0, 1000);
                int randomy = r.Next(227, 416);

                theBox[n].Left = randomx;
                theBox[n].Top = randomy;

            }

            for (int n = 0; n < bubbles.Length; n++)
            {
                int randomx = r.Next(0, 1000);
                int randomy = r.Next(227, 416);

                bubbles[n].Left = randomx;
                bubbles[n].Top = randomy;
            }

            for (int n = 0; n < metaknight.Length; n++)
            {
                int randomx = r.Next(0, 1000);
                int randomy = r.Next(227, 416);

                metaknight[n].Left = randomx;
                metaknight[n].Top = randomy;
            }

            for (int n = 0; n < halberd.Length; n++)
            {
                int randomx = r.Next(227, 1000);

                pichalberd.Left = randomx;
                pichalberd.Top = 25;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            theBox[0].Left = picnet.Left - 10;
            theBox[0].Top = picnet.Top;
            theBox[0].Visible = false;
        }


        private void timer6_Tick(object sender, EventArgs e)
        {
            theBox[Hit].Left = picnet.Left;
            theBox[Hit].Top = picnet.Top;
        }
    }
}
