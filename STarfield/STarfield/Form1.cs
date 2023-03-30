using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STarfield
{
    /* David Lim
     * Period 5
     * 01/30/2020
     * this simulates you moving through space
     */

    public partial class Form1 : Form
    {
        //create an array to contain our stars
        Label[] Universe = new Label[8];
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            movestars();
        }

        private void movestars()
        {
            //grow the stars
            for (int m = 0; m < Universe.Length; m++)
            {
                Universe[m].Width += 2;
                Universe[m].Height += 2;

                if (Universe[m].Width >= 10)
                {
                    Universe[m].Left = r.Next(0, this.Width);
                    Universe[m].Top = r.Next(0, this.Height);
                    Universe[m].Width = 1;
                    Universe[m].Height = 1;
                }

                if (Universe[m].Left < 409)
                {
                    Universe[m].Left -= 10;
                    if (Universe[m].Top < 249)
                    { 
                        Universe[m].Top -= 10;
                    }

                    if (Universe[m].Top > 249)
                    {
                        Universe[m].Top += 10;
                    }
                }

                if (Universe[m].Left > 409)
                {
                    Universe[m].Left += 10;
                    if (Universe[m].Top < 249)
                    {
                        Universe[m].Top -= 10;
                    }

                    if (Universe[m].Top > 249)
                    {
                        Universe[m].Top += 10;
                    }
                }
            }

                
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this runs code 1 time at start up
            //organize the universe
            Universe[0] = lblstar0;
            Universe[1] = lblstar1;
            Universe[2] = lblstar2;
            Universe[3] = lblstar3;
            Universe[4] = lblstar4;
            Universe[5] = lblstar5;
            Universe[6] = lblstar6;
            Universe[7] = lblstar7;

            for (int n = 0; n < Universe.Length; n++)
            {
                int randomx = r.Next(0, this.Width);
                int randomy = r.Next(0, this.Height);

                Universe[n].Left = randomx;
                Universe[n].Top = randomy;
                int thewidth = r.Next(1, 11);
                Universe[n].Width = thewidth;
                Universe[n].Height = thewidth;
            }
        }


    }
}
