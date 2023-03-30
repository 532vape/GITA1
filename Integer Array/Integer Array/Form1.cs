using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integer_Array
{

    public partial class Form1 : Form
    {/*
        This program generates a series of numbers in two arrays. The first, "search array" generates a 
        number and tries to find it in an array of 5000 numbers
        The second "Integer Array" generates a (user-generated) quantity of random numbers and finds the avg, max, and min value of the
        numbers
        */
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        int[] numberarray;
        int[] searcharray;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrandom_Click(object sender, EventArgs e)
        {
            try
            {
                int howmany = int.Parse(txtquantity.Text);
                int maxvalue = 0;
                int minvalue = 5000;
                int average = 0;
                numberarray = new int[howmany];
                string message = "";
                string message2 = "";
                string message3 = "";

                for (int i = 0; i < numberarray.Length; i++)
                {
                    //fill the array
                    int myrandom = r.Next(1, 5001);
                    numberarray[i] = myrandom;
                    average += numberarray[i] / howmany;
                }

                for (int i = 0; i < numberarray.Length; i++)
                {
                    //detect the greatest value
                    if (numberarray[i] > maxvalue)
                    {
                        maxvalue = numberarray[i];
                    }

                    //detect the min value
                    if (numberarray[i] <= minvalue)
                    {
                        minvalue = numberarray[i];

                        if (numberarray[i] == 0)
                        {
                            minvalue = 0;
                            minvalue = 0;
                        }
                    }
                }


                //output to label
                for (int i = 0; i < numberarray.Length; i++)
                {
                    message += numberarray[i] + "\n";
                }

                message += "MaxValue: " + maxvalue;
                message2 += "MinValue: " + minvalue;
                message3 += "AvgValue: " + average;
                lbloutput.Text = message + "\n" + message2 + "\n" + message3;
            }
            catch
            {

            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int howMany = 5000;
            searcharray = new int[howMany];
            int randomnum = 0;
            int whatnumber = 0;
            int averagenum = 0;

            for (int i = 0; i < searcharray.Length; i++)
            {
                
                for (int N = 0; N < searcharray.Length; N++)
                {
                    //fill the array
                    int randominteger = r.Next(1, 5001);
                    searcharray[N] = randominteger;
                }

                randomnum = r.Next(1, 5001);

                for (int m = 0; m < searcharray.Length; m++)
                {
                    whatnumber++;
                    if (searcharray[m] == randomnum)
                    {
                        //stop the for loop once found
                        break;
                    }
                }
            }
            //output the average to the label
            averagenum = whatnumber / 5000;
            lblavg.Text = averagenum.ToString();
        }
       private void timer1_Tick(object sender, EventArgs e)
        {
 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblattempts_Click(object sender, EventArgs e)
        {

        }
    }
}
