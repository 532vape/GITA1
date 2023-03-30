using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays2
{
    public partial class Form1 : Form
    {
        //global variables
        //declare 2d array
        PictureBox[,] theTank = new PictureBox[3, 4];
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        int fishposX = 1;
        int fishposY = 1;
        public Form1()
        {
            InitializeComponent();
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

            //set up the second row
            theTank[1, 0] = picbox4;
            theTank[1, 1] = picbox5;
            theTank[1, 2] = picbox6;
            theTank[1, 3] = picbox7;

            //set up the third row
            theTank[2, 0] = picbox8;
            theTank[2, 1] = picbox9;
            theTank[2, 2] = picbox10;
            theTank[2, 3] = picbox11;

            fishposX = r.Next(0, 3);
            fishposY = r.Next(0, 4);
            //draw the fish
            theTank[fishposX, fishposY].Image = picfish.Image;

        }

        private void movefish()
        {
            theTank[fishposX, fishposY].Image = null;
            fishposX = r.Next(0, 3);
            fishposY = r.Next(0, 4);
            //draw the fish
            theTank[fishposX, fishposY].Image = picfish.Image;
        }

        private void Btnmove_Click(object sender, EventArgs e)
        {
            movefish();
        }
    }
}
