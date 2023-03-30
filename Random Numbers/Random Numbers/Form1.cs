using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Numbers
{
    public partial class Form1 : Form
    {
        System.Random r = 
            new System.Random((int)System.DateTime.Now.Ticks);

        public Form1()
        {
            InitializeComponent();
        }

        private void Picsad_Click(object sender, EventArgs e)
        {

        }

        private void Btnrandom_Click(object sender, EventArgs e)
        {

            //generates a random number from 1-100
            int myRandom = r.Next(1, 100);

            //output our number
            lblmessage.Text = myRandom.ToString();
            if (myRandom >= 50)
            {
                picblank.Image = pichappy.Image;
            }
            else if (myRandom > 25 && myRandom < 50)
            {
                picblank.Image = picsad.Image;
            }
            else
            {
                picblank.Image = null;
            }

            //or situation
            if (myRandom == 7 || myRandom == 11)
            {
                MessageBox.Show("winner, winner");
            }


        }
    }
}
