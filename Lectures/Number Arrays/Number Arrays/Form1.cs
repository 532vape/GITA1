using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Arrays
{
    public partial class Form1 : Form
    {
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        int[] arrayofrandoms;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrandom_Click(object sender, EventArgs e)
        {
            
            //this lets the user decide how big of an array to store random numbers
            int howmany = int.Parse(txthowmany.Text);
            arrayofrandoms = new int[howmany];
            string message = "";
            int maxvalue = 0;

            for (int i = 0; i < arrayofrandoms.Length; i++)
            {
                //this fills the array
                int myrandom = r.Next(1, 101);
                arrayofrandoms[i] = myrandom;
            }

            for (int i = 0; i < arrayofrandoms.Length; i++)
            {
                if (arrayofrandoms[i] > maxvalue)
                {
                    maxvalue = arrayofrandoms[i];
                }
            }

            //output the values of the array
            for (int i = 0; i < arrayofrandoms.Length; i++)
            {
                message += arrayofrandoms[i] + "\n";
            }

            message += "MaxValue: " + maxvalue;
            lbloutput.Text = message;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
