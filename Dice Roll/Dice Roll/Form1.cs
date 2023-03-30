using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roll
{
    //David Lim
    //Period 5
    //10-15-19
    /*This rolls two dice and calculates the probabilitites of rolling certain sums
     * it also shows you the total sum of the roll and how many times you rolled each sum
     */
    public partial class Form1 : Form
    {
        private decimal rolls;
        private decimal rolls2;
        private decimal rolls3;
        private decimal roll4;
        private decimal rolls5;
        private decimal rolls6;
        private decimal rolls7;
        private decimal rolls8;
        private decimal rolls9;
        private decimal rolls10;
        private decimal rolls11;
        private decimal rolls12;
        System.Random r =
            new System.Random((int)System.DateTime.Now.Ticks);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //step 1: generates numbers from 1-6
            int randomroll1 = r.Next(1, 7);
            int randomroll2 = r.Next(1, 7);
            int rollsum = randomroll1 + randomroll2;
            decimal probability2;
            decimal probability3;
            decimal probability4;
            decimal probability5;
            decimal probability6;
            decimal probability7;
            decimal probability8;
            decimal probability9;
            decimal probability10;
            decimal probability11;
            decimal probability12;

            if (randomroll1 == 1)
            {
                picdie1.Image = picdieside1.Image;
            }
            else if (randomroll1 == 2)
            {
                picdie1.Image = picdieside2.Image;
            }
            else if (randomroll1 == 3)
            {
                picdie1.Image = picdieside3.Image;
            }
            else if (randomroll1 == 4)
            {
                picdie1.Image = picdieside4.Image;
            }
            else if (randomroll1 == 5)
            {
                picdie1.Image = picdieside5.Image;
            }
            else if (randomroll1 == 6)
            {
                picdie1.Image = picdieside6.Image;
            }

            if (randomroll2 == 1)
            {
                picdie2.Image = picdieside1.Image;
            }
            else if (randomroll2 == 2)
            {
                picdie2.Image = picdieside2.Image;
            }
            else if (randomroll2 == 3)
            {
                picdie2.Image = picdieside3.Image;
            }
            else if (randomroll2 == 4)
            {
                picdie2.Image = picdieside4.Image;
            }
            else if (randomroll2 == 5)
            {
                picdie2.Image = picdieside5.Image;
            }
            else if (randomroll2 == 6)
            {
                picdie2.Image = picdieside6.Image;
            }

            //step 2: calculate the totals of the dice
            lbltotal.Text = (randomroll1 + randomroll2).ToString();



            //calculate the probabilities
            if (rollsum == 2)
            {
                rolls += 1;
                rolls2 += 1;
                probability2 = Math.Round((rolls2 / rolls) * 100, 2);
                lblchanceofroll.Text = probability2.ToString() + "%";
                lblnumberofrolls.Text = rolls.ToString();

            }
            else if (rollsum == 3)
            {
                rolls += 1;
                rolls3 += 1;
                probability3 = Math.Round((rolls3 / rolls) * 100, 2);
                lblchanceofroll.Text = probability3.ToString() + "%";
                lblnumberofrolls.Text = rolls.ToString();

            }
            else if (rollsum == 4)
            {
                rolls += 1;
                roll4 += 1;
                probability4 = Math.Round((roll4 / rolls) * 100, 2);
                lblchanceofroll.Text = probability4.ToString() + "%";
                lblnumberofrolls.Text = rolls.ToString();

            }
            else if (rollsum == 5)
            {
                rolls += 1;
                rolls5 += 1;
                probability5 = Math.Round((rolls5 / rolls) * 100, 2);
                lblchanceofroll.Text = probability5.ToString() + "%";
                lblnumberofrolls.Text = rolls.ToString();

            }
            else if (rollsum == 6)
            {
                rolls += 1;
                rolls6 += 1;
                probability6 = Math.Round((rolls6 / rolls) * 100, 2);
                lblchanceofroll.Text = probability6.ToString() + "%";
                lblnumberofrolls.Text = rolls.ToString();

            }
            else if (rollsum == 7)
            {
                rolls += 1;
                rolls7 += 1;
                probability7 = Math.Round((rolls7 / rolls) * 100, 2);
                lblchanceofroll.Text = probability7.ToString() + "%";
                lblnumberofrolls.Text = rolls.ToString();

            }
            else if (rollsum == 8)
            {
                rolls += 1;
                rolls8 += 1;
                probability8 = Math.Round((rolls8 / rolls) * 100, 2);
                lblchanceofroll.Text = probability8.ToString() + "%";
                lblnumberofrolls.Text = rolls.ToString();

            }
            else if (rollsum == 9)
            {
                rolls += 1;
                rolls9 += 1;
                probability9 = Math.Round((rolls9 / rolls) * 100, 2);
                lblchanceofroll.Text = probability9.ToString() + "%";
                lblnumberofrolls.Text = rolls.ToString();

            }
            else if (rollsum == 10)
            {
                rolls += 1;
                rolls10 += 1;
                probability10 = Math.Round((rolls10 / rolls) * 100, 2);
                lblchanceofroll.Text = probability10.ToString() + "%";
                lblnumberofrolls.Text = rolls.ToString();

            }
            else if (rollsum == 11)
            {
                rolls += 1;
                rolls11 += 1;
                probability11 = Math.Round((rolls11 / rolls) * 100, 2);
                lblchanceofroll.Text = probability11.ToString() + "%";
                lblnumberofrolls.Text = rolls.ToString();

            }
            else if (rollsum == 12)
            {
                rolls += 1;
                rolls12 += 1;
                probability12 = Math.Round((rolls12 / rolls) * 100, 2);
                lblchanceofroll.Text = probability12.ToString() + "%";
                lblnumberofrolls.Text = rolls.ToString();

            }
            //step 5: output to labels
            lblroll2.Text = rolls2.ToString();
            lblroll3.Text = rolls3.ToString();
            lblroll4.Text = roll4.ToString();
            lblroll5.Text = rolls5.ToString();
            lblroll6.Text = rolls6.ToString();
            lblroll7.Text = rolls7.ToString();
            lblroll8.Text = rolls8.ToString();
            lblroll9.Text = rolls9.ToString();
            lblroll10.Text = rolls10.ToString();
            lblroll11.Text = rolls11.ToString();
            lblroll12.Text = rolls12.ToString();

        }


        private void Lblroll3_Click(object sender, EventArgs e)
        {

        }

        private void Lblroll11_Click(object sender, EventArgs e)
        {

        }

        private void Lblroll12_Click(object sender, EventArgs e)
        {

        }

        private void Btnreset_Click(object sender, EventArgs e)
        {
            //this clears the code and resets the decimals
            lbltotal.Text = "";
            lblchanceofroll.Text = "";
            lblroll2.Text = "";
            lblroll3.Text = "";
            lblroll4.Text = "";
            lblroll5.Text = "";
            lblroll6.Text = "";
            lblroll7.Text = "";
            lblroll8.Text = "";
            lblroll9.Text = "";
            lblroll10.Text = "";
            lblroll11.Text = "";
            lblroll12.Text = "";
            lblnumberofrolls.Text = "";
            rolls = 0;
            rolls2 = 0;
            rolls3 = 0;
            roll4 = 0;
            rolls5 = 0;
            rolls6 = 0;
            rolls7 = 0;
            rolls8 = 0;
            rolls9 = 0;
            rolls10 = 0;
            rolls11 = 0;
            rolls12 = 0;


        }


    }
}

