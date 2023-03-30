using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Calculator
{
    //David Lim
    //Period 5
    //10-9-19
    /*test calculator
     * this calculates 2 test grades and compares them together
     * tells you the average score
     * tells you the higher test score
     */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            //this exits the program
            this.Close();
        }

        private void Btncalculate_Click(object sender, EventArgs e)

        {
            try
            {
                //step 1: declare varaibles
                decimal grade1percentdecimal;
                decimal grade2percentdecimal;
                decimal averagegradedecimal;
                decimal grade1top;
                decimal grade1bottom;
                decimal grade2top;
                decimal grade2bottom;
                decimal grade1integer;
                decimal grade2integer;
                decimal gradeavginteger;

                //step 2: get info from textboxes
                grade1top = decimal.Parse(txt1numerator.Text);
                grade1bottom = decimal.Parse(txt1denominator.Text);
                grade2top = decimal.Parse(txt2numerator.Text);
                grade2bottom = decimal.Parse(txt2denominator.Text);

                //step 3: mathematical calculations
                grade1percentdecimal = grade1top / grade1bottom;
                grade2percentdecimal = grade2top / grade2bottom;
                averagegradedecimal = (grade1percentdecimal + grade2percentdecimal) / 2;

                //these are if statments to show the user their letter grade
                if (grade1percentdecimal >= (decimal)0.90)
                {
                    lbl1grade.Text = "A";
                }

                else if (grade1percentdecimal >= (decimal)0.80 && grade1percentdecimal < (decimal)0.90)
                {
                    lbl1grade.Text = "B";
                }

                else if (grade1percentdecimal >= (decimal)0.70 && grade1percentdecimal < (decimal)0.80)
                {
                    lbl1grade.Text = "C";
                }

                else if (grade1percentdecimal >= (decimal)0.60 && grade1percentdecimal < (decimal)0.70)
                {
                    lbl1grade.Text = "D";
                }

                else if (grade1percentdecimal < (decimal)0.60)
                {
                    lbl1grade.Text = "F";
                }

                if (grade2percentdecimal >= (decimal)0.90)
                {
                    lbl2grade.Text = "A";
                }

                else if (grade2percentdecimal >= (decimal)0.80 && grade2percentdecimal < (decimal)0.90)
                {
                    lbl2grade.Text = "B";
                }

                else if (grade2percentdecimal >= (decimal)0.70 && grade2percentdecimal < (decimal)0.80)
                {
                    lbl2grade.Text = "C";
                }

                else if (grade2percentdecimal >= (decimal)0.60 && grade2percentdecimal < (decimal)0.70)
                {
                    lbl2grade.Text = "D";
                }

                else if (grade2percentdecimal < (decimal)0.60)
                {
                    lbl2grade.Text = "F";
                }

                if (averagegradedecimal >= (decimal)0.90)
                {
                    lblavggrade.Text = "A";
                }

                else if (averagegradedecimal >= (decimal)0.80 && averagegradedecimal < (decimal)0.90)
                {
                    lblavggrade.Text = "B";
                }

                else if (averagegradedecimal >= (decimal)0.70 && averagegradedecimal < (decimal)0.80)
                {
                    lblavggrade.Text = "C";
                }

                else if (averagegradedecimal >= (decimal)0.60 && averagegradedecimal < (decimal)0.70)
                {
                    lblavggrade.Text = "D";
                }

                else if (averagegradedecimal < (decimal)0.60)
                {
                    lblavggrade.Text = "F";
                }


                //step 3: output decimals to the labels
                grade1integer = Math.Round(grade1percentdecimal, 2);
                grade2integer = Math.Round(grade2percentdecimal, 2);
                gradeavginteger = Math.Round(averagegradedecimal, 2);
                lbl1percent.Text = ((grade1integer * 100) + "%").ToString();
                lbl2percentage.Text = ((grade2integer * 100) + "%").ToString();
                lblavgpercentage.Text = ((gradeavginteger * 100) + "%").ToString();

                if (grade1percentdecimal == 1)
                {
                    lbl1percent.Text = "100%";
                }

                if (grade2percentdecimal == 1)
                {
                    lbl2percentage.Text = "100%";
                }

                if (averagegradedecimal == 1)
                {
                    lblavgpercentage.Text = "100%";
                }

                //step 4: show which test score is higher
                if (grade1integer > grade2integer)
                {
                    lblhighertest.Text = "Test 1";
                }

                else if (grade2integer > grade1integer)
                {
                    lblhighertest.Text = "Test 2";
                }

                if (grade1integer == grade2integer)
                {
                    lblhighertest.Text = "Scores are the same";
                }
                clearcode();
                        
            }
            catch
            {
                MessageBox.Show("Enter Score");
            }




        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            //clears info in the program
            lbl1grade.Text = " ";
            lbl2grade.Text = " ";
            lbl1percent.Text = " ";
            lbl2percentage.Text = " ";
            lblavggrade.Text = " ";
            lblavgpercentage.Text = " ";
            lblhighertest.Text = " ";
            //creates a function to clear the textboxes in the program
        }
        private void clearcode()
        {
            txt1numerator.Text = "";
            txt1denominator.Clear();
            txt2numerator.Clear();
            txt2denominator.Clear();
           
        }
    }
}
