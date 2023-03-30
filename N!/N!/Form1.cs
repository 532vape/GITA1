using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_
{
    /*David Lim
     *Period 5
     * 1/13/2020
     * this program generates sequences of numbers, odd numbers, even numbers, factorials, and 
     * even the fibonacci sequence
     */

    public partial class Form1 : Form
    {
        private int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsequence_Click(object sender, EventArgs e)
        {
            //generate a string of numbers
            string messagestring = "";
            int howmanynumbers = 0;
            howmanynumbers = int.Parse(txtsequence.Text);
            int n = howmanynumbers;

            try
            {
                for (int theCounter = 1; theCounter <= howmanynumbers; theCounter++)
                {
                    messagestring += theCounter + "\n";
                }
                lblsequence.Text = messagestring;

                int res = 1;
                while (n != 1)
                {
                    res = res + n;
                    n = n - 1;
                    lblsequenceoutput.Text = res.ToString();
                }
            }
            catch
            {

            }
        }

        private void Lblsequence_Click(object sender, EventArgs e)
        {

        }

        private void Txtfactorial_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnfactorial_Click(object sender, EventArgs e)
        {
            //generate the numbers that make up a factorial number
            //e.g. 3! = 3 2 1
            string messagestring = "";
            int output = 1;
            string yee = "";
            int howmanynumbers = 0;
            howmanynumbers = int.Parse(txtfactorial.Text);
            int n = howmanynumbers;

            try
            {
                for (int theCounter = 1; theCounter <= howmanynumbers; theCounter ++)
                {
                    messagestring += theCounter + "\n";
                    output *= theCounter;
                    yee = output.ToString();
                    lblfactorialoutput.Text = yee;
                }
                lblfactorial.Text = messagestring;

            }
            catch
            {

            }
        }



        private void Btneven_Click(object sender, EventArgs e)
        {
            //generate a string of even numbers
            string messagestring = "";
            decimal howmanynumbers = 0;
            int total = 0;
            howmanynumbers = int.Parse(txteven.Text);
            int n = int.Parse(txteven.Text);
            howmanynumbers = howmanynumbers * 2;

            try
            {
                for (int theCounter = 2; theCounter <= howmanynumbers; theCounter += 2)
                {
                    messagestring += theCounter + "\n";
                    total += theCounter;
                }
                lbleven.Text = messagestring;
                lblevenoutput.Text = total.ToString();
            }
            catch
            {

            }
        }




        private void Btnodd_Click(object sender, EventArgs e)
        {
            //generate a string of odd numbers
            string messagestring = "";
            decimal howmanynumbers = 0;
            int total = 0;
            howmanynumbers = int.Parse(txtodd.Text);
            howmanynumbers = howmanynumbers * 2;

            try
            {
                for (int theCounter = 1; theCounter <= howmanynumbers; theCounter += 2)
                {
                    messagestring += theCounter + "\n";
                    total += theCounter;
                }
                lblodd.Text = messagestring;
                lbloddoutput.Text = total.ToString();
            }
            catch
            {

            }
        }

        private void Btnfibonacci_Click(object sender, EventArgs e)
        {
            // generate the fibonacci sequence
            string messagestring = "";
            int howmanynumbers = 0;
            int fibonaccitotal = 1;
            howmanynumbers = int.Parse(txtfibonacci.Text);
            int first = 1;
            int second = 1;
            int result = 2;

            try
            {
                for (int i = 2; i <= howmanynumbers; i++)
                {
                    result = first + second;
                    first = second;
                    second = result;

                    messagestring += first + "\n";
                    fibonaccitotal += first;
                }
                lblfibonacci.Text = "1" + "\n" + messagestring;
                lblfibonaccioutput.Text = fibonaccitotal.ToString();
            }
            catch
            {


            }
        }

        private void Txteven_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
      

