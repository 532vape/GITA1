using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: David Lim
//Date: 11-18-19
//Period 5
//This porject teaches you arrays and how to use them
namespace arrays
{
    public partial class Form1 : Form
    {
        int fishpos = 0;
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        Boolean onoff = false;
        PictureBox[] theTank = new PictureBox[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnmove_Click(object sender, EventArgs e)
        {
            //this randomly places the fish in a box
            movefish();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this runs code one tome for setup purposes
            theTank[0] = picbox0;
            theTank[1] = picbox1;
            theTank[2] = picbox2;
            theTank[3] = picbox3;
            int randompos = r.Next(0, 4);
            theTank[randompos].Image = picfish.Image;
        }

        private void movefish()
        {
            //randomly moves the fish
            theTank[fishpos].Image = null;
            fishpos = r.Next(0, 4);
            theTank[fishpos].Image = picfish.Image;
        }

        private void Btnauto_Click(object sender, EventArgs e)
        {
            //this turns timer on/off
            if(onoff == false)
            {
                timer1.Enabled = true;
                onoff = true;
            }
            else if(onoff == true)
            {
                timer1.Enabled = false;
                onoff = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            movefish();
        }
    }
}
