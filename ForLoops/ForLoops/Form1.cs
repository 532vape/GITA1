using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lbloutput_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnloop_Click(object sender, EventArgs e)
        {
            //how a for loop counter works
            string messagestring = "";
            int howmanynumbers = 0;
            howmanynumbers = int.Parse(txthowmany.Text);
            for (int theCounter = 1; theCounter < howmanynumbers; theCounter++)
            {
                messagestring += theCounter + "\n";
            }
            lbloutput.Text = messagestring;
        }

        private void Btnrandom_Click(object sender, EventArgs e)
        {
            //this outputs a user-determined amount of random numbers
            string messagestring = "";
            int howmanynumbers = 0;
            howmanynumbers = int.Parse(txthowmany.Text);
            System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
            int totalvalue = 0;
            int maxvalue = 0;
            int randomnumber = 0;
            for (int theCounter = 0; theCounter < howmanynumbers; theCounter++)
            {
                randomnumber = r.Next(1, 11);
                messagestring += randomnumber + "\n";
                totalvalue += randomnumber;

                if (randomnumber > maxvalue)
                {
                    maxvalue = randomnumber;
                }
            }

            messagestring += "The total: " + totalvalue + "\n";
            messagestring += "Max Value: " + maxvalue + "\n";
            lbloutput.Text = messagestring;
        }
    }
}

