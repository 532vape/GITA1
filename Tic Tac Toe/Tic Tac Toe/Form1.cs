using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* David Lim
 * Period5
 * 01-09-2020
 * this program runs a game of tic tac toe, resetting the board when someone wins or a tie occurs
 */

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Boolean onoff = false;
        private decimal picture0;
        private decimal picture1;
        private decimal picture2;
        private decimal picture3;
        private decimal picture4;
        private decimal picture5;
        private decimal picture6;
        private decimal picture7;
        private decimal picture8;

        public Form1()
        {
            InitializeComponent();
        }


        private void picturebox()
        {
            //create function for x or o
            //was called only to pic0 because it did not allow the pic0 to reset to a blank image
            if (onoff == false)
            {
                pic0.Image = picx.Image;
                onoff = true;
            }

            else if (onoff == true)
            {
                pic0.Image = pico.Image;
                onoff = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pic0_Click(object sender, EventArgs e)
        {
            picturebox();
            if (pic0.Image == picx.Image)
            {
                picture0 = 1;
            }

            else if (pic0.Image == pico.Image)
            {
                picture0 = 2;
            }

            pic0.Enabled = false;
            win_condition();
        }

        private void Pic1_Click(object sender, EventArgs e)
        {
            if (onoff == false)
            {
                pic1.Image = picx.Image;
                onoff = true;
            }

            else if (onoff == true)
            {
                pic1.Image = pico.Image;
                onoff = false;
            }

            if (pic1.Image == picx.Image)
            {
                picture1 = 1;
            }

            else if (pic1.Image == pico.Image)
            {
                picture1 = 2;
            }

            pic1.Enabled = false;
            win_condition();
        }

        private void Pic2_Click(object sender, EventArgs e)
        {
            if (onoff == false)
            {
                pic2.Image = picx.Image;
                onoff = true;
            }

            else if (onoff == true)
            {
                pic2.Image = pico.Image;
                onoff = false;
            }

            if (pic2.Image == picx.Image)
            {
                picture2 = 1;
            }

            else if (pic2.Image == pico.Image)
            {
                picture2 = 2;
            }

            pic2.Enabled = false;
            win_condition();
        }

        private void Pic3_Click(object sender, EventArgs e)
        {
            if (onoff == false)
            {
                pic3.Image = picx.Image;
                onoff = true;
            }

            else if (onoff == true)
            {
                pic3.Image = pico.Image;
                onoff = false;
            }

            if (pic3.Image == picx.Image)
            {
                picture3 = 1;
            }

            else if (pic3.Image == pico.Image)
            {
                picture3 = 2;
            }

            pic3.Enabled = false;
            win_condition();
        }

        private void Pic4_Click(object sender, EventArgs e)
        {
            if (onoff == false)
            {
                pic4.Image = picx.Image;
                onoff = true;
            }

            else if (onoff == true)
            {
                pic4.Image = pico.Image;
                onoff = false;
            }

            if (pic4.Image == picx.Image)
            {
                picture4 = 1;
            }

            else if (pic4.Image == pico.Image)
            {
                picture4 = 2;
            }

            pic4.Enabled = false;
            win_condition();
        }

        private void Pic5_Click(object sender, EventArgs e)
        {
            if (onoff == false)
            {
                pic5.Image = picx.Image;
                onoff = true;
            }

            else if (onoff == true)
            {
                pic5.Image = pico.Image;
                onoff = false;
            }

            if (pic5.Image == picx.Image)
            {
                picture5 = 1;
            }

            else if (pic5.Image == pico.Image)
            {
                picture5 = 2;
            }

            pic5.Enabled = false;
            win_condition();
        }

        private void Pic6_Click(object sender, EventArgs e)
        {
            if (onoff == false)
            {
                pic6.Image = picx.Image;
                onoff = true;
            }

            else if (onoff == true)
            {
                pic6.Image = pico.Image;
                onoff = false;
            }

            if (pic6.Image == picx.Image)
            {
                picture6 = 1;
            }

            else if (pic6.Image == pico.Image)
            {
                picture6 = 2;
            }

            pic6.Enabled = false;
            win_condition();
        }

        private void Pic7_Click(object sender, EventArgs e)
        {
            if (onoff == false)
            {
                pic7.Image = picx.Image;
                onoff = true;
            }

            else if (onoff == true)
            {
                pic7.Image = pico.Image;
                onoff = false;
            }

            if (pic7.Image == picx.Image)
            {
                picture7 = 1;
            }

            else if (pic7.Image == pico.Image)
            {
                picture7 = 2;
            }

            pic7.Enabled = false;
            win_condition();
        }

        private void Pic8_Click(object sender, EventArgs e)
        {
            if (onoff == false)
            {
                pic8.Image = picx.Image;
                onoff = true;
            }

            else if (onoff == true)
            {
                pic8.Image = pico.Image;
                onoff = false;
            }

            if (pic8.Image == picx.Image)
            {
                picture8 = 1;
            }

            else if (pic8.Image == pico.Image)
            {
                picture8 = 2;
            }
            
            pic8.Enabled = false;
            win_condition();
        }

        private void win_condition()
        {
            //create a win condition function for all 3 in a row possiblitites

            //player 1 (X)
            if (//horizontal
                (picture0 == 1 && picture1 == 1 && picture2 == 1) ||
                (picture3 == 1 && picture4 == 1 && picture5 == 1) ||
                (picture6 == 1 && picture7 == 1 && picture8 == 1) ||
                /*vertical*/
                (picture0 == 1 && picture3 == 1 && picture6 == 1) ||
                (picture1 == 1 && picture4 == 1 && picture7 == 1) || 
                (picture2 == 1 && picture5 == 1 && picture8 == 1) ||
                /*diagonal*/
                (picture0 == 1 && picture4 == 1 && picture8 == 1) ||
                (picture2 == 1 && picture4 == 1 && picture6 == 1))
            {
                MessageBox.Show("P1 Wins");

                pic0.Image = null;
                pic1.Image = null;
                pic2.Image = null;
                pic3.Image = null;
                pic4.Image = null;
                pic5.Image = null;
                pic6.Image = null;
                pic7.Image = null;
                pic8.Image = null;
                pic0.Enabled = true;
                pic1.Enabled = true;
                pic2.Enabled = true;
                pic3.Enabled = true;
                pic4.Enabled = true;
                pic5.Enabled = true;
                pic6.Enabled = true;
                pic7.Enabled = true;
                pic8.Enabled = true;

                picture0 = 0;
                picture1 = 0;
                picture2 = 0;
                picture3 = 0;
                picture4 = 0;
                picture5 = 0;
                picture6 = 0;
                picture7 = 0;
                picture8 = 0;
                onoff = false;
            }

            //player 2 (O)
            if (//horizontal
                (picture0 == 2 && picture1 == 2 && picture2 == 2) ||
                (picture3 == 2 && picture4 == 2 && picture5 == 2) ||
                (picture6 == 2 && picture7 == 2 && picture8 == 2) ||
                /*vertical*/
                (picture0 == 2 && picture3 == 2 && picture6 == 2) ||
                (picture1 == 2 && picture4 == 2 && picture7 == 2) ||
                (picture2 == 2 && picture5 == 2 && picture8 == 2) ||
                /*diagonal*/
                (picture0 == 2 && picture4 == 2 && picture8 == 2) ||
                (picture2 == 2 && picture4 == 2 && picture6 == 2))
            {
                MessageBox.Show("P2 Wins");

                pic0.Image = null;
                pic1.Image = null;
                pic2.Image = null;
                pic3.Image = null;
                pic4.Image = null;
                pic5.Image = null;
                pic6.Image = null;
                pic7.Image = null;
                pic8.Image = null;
                pic0.Enabled = true;
                pic1.Enabled = true;
                pic2.Enabled = true;
                pic3.Enabled = true;
                pic4.Enabled = true;
                pic5.Enabled = true;
                pic6.Enabled = true;
                pic7.Enabled = true;
                pic8.Enabled = true;

                picture0 = 0;
                picture1 = 0;
                picture2 = 0;
                picture3 = 0;
                picture4 = 0;
                picture5 = 0;
                picture6 = 0;
                picture7 = 0;
                picture8 = 0;
                onoff = false;
            }

                if ((pic0.Image == picx.Image || pic0.Image == pico.Image) &&
                    (pic1.Image == picx.Image || pic1.Image == pico.Image) &&
                    (pic2.Image == picx.Image || pic2.Image == pico.Image) &&
                    (pic3.Image == picx.Image || pic3.Image == pico.Image) &&
                    (pic4.Image == picx.Image || pic4.Image == pico.Image) &&
                    (pic5.Image == picx.Image || pic5.Image == pico.Image) &&
                    (pic6.Image == picx.Image || pic6.Image == pico.Image) &&
                    (pic7.Image == picx.Image || pic7.Image == pico.Image) &&
                    (pic8.Image == picx.Image || pic8.Image == pico.Image))
                {
                    MessageBox.Show("Tie!");
                pic0.Image = null;
                pic1.Image = null;
                pic2.Image = null;
                pic3.Image = null;
                pic4.Image = null;
                pic5.Image = null;
                pic6.Image = null;
                pic7.Image = null;
                pic8.Image = null;
                pic0.Enabled = true;
                pic1.Enabled = true;
                pic2.Enabled = true;
                pic3.Enabled = true;
                pic4.Enabled = true;
                pic5.Enabled = true;
                pic6.Enabled = true;
                pic7.Enabled = true;
                pic8.Enabled = true;

                picture0 = 0;
                picture1 = 0;
                picture2 = 0;
                picture3 = 0;
                picture4 = 0;
                picture5 = 0;
                picture6 = 0;
                picture7 = 0;
                picture8 = 0;
                onoff = false;
            }
            }
        }
    }

