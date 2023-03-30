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
    /*This is a craps game
     * it generates randpm sums of the dice
     * if you roll 2,3, or 11 on the first try, you lose
     * if you roll7 on the first roll, you win
     * if you roll anything else it becomes your "point
     * if you roll 7 on your second roll, you lose
     * if your roll your "point", you win
     */
    public partial class Form1 : Form
    {
        private decimal rolls;
        private decimal pointdecimal;
        
  
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



        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnroll_Click(object sender, EventArgs e)
        {
            //step 1: generates numbers from 1-6
            int randomroll1 = r.Next(1, 7);
            int randomroll2 = r.Next(1, 7);
            int rollsum = randomroll1 + randomroll2;
  
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

            //step 3: output number of rolls
            rolls += 1;
            lblnumberofrolls.Text = rolls.ToString();



            //the first roll of the dice
            if (rollsum == 4 && rolls == 1)
            {
                lblpoints.Text = "4";
                pointdecimal = 4;
                pic4.Visible = true;
                pic5.Visible = false;
                pic6.Visible = false;
                pic8.Visible = false;
                pic9.Visible = false;
                pic10.Visible = false;
            }

            if (rollsum == 5 && rolls == 1)
            {
                lblpoints.Text = "5";
                pointdecimal = 5;
                pic4.Visible = false;
                pic5.Visible = true;
                pic6.Visible = false;
                pic8.Visible = false;
                pic9.Visible = false;
                pic10.Visible = false;

            }

            if (rollsum == 6 && rolls == 1)
            {
                lblpoints.Text = "6";
                pointdecimal = 6;
                pic4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = true;
                pic8.Visible = false;
                pic9.Visible = false;
                pic10.Visible = false;
            }

            if (rollsum == 8 && rolls == 1)
            {
                lblpoints.Text = "8";
                pointdecimal = 8;
                pic4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                pic8.Visible = true;
                pic9.Visible = false;
                pic10.Visible = false;
            }

            if (rollsum == 9 && rolls == 1)
            {
                lblpoints.Text = "9";
                pointdecimal = 9;
                pic4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                pic8.Visible = false;
                pic9.Visible = true;
                pic10.Visible = false;
            }

            if (rollsum == 10 && rolls == 1)
            {
                lblpoints.Text = "10";
                pointdecimal = 10;
                pic4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                pic8.Visible = false;
                pic9.Visible = false;
                pic10.Visible = true;
            }

            if (rolls == 1)
            {
                if (rollsum == 7 || rollsum == 11 && rolls == 1)
                {
                    MessageBox.Show("You Win!");
                    rolls = 0;
                    rollsum = 0;
                    lblnumberofrolls.Text = "0";
                    lbltotal.Text = "0";
                    picdie1.Image = picdie1.Image;
                    picdie2.Image = picdie2.Image;
                    lblpoints.Text = "0";
                    pic4.Visible = false;
                    pic5.Visible = false;
                    pic6.Visible = false;
                    pic8.Visible = false;
                    pic9.Visible = false;
                    pic10.Visible = false;
                }

                if (rollsum == 2 || rollsum == 12 || rollsum == 3 && rolls == 1)
                {
                    MessageBox.Show("You Lose!");
                    rolls = 0;
                    rollsum = 0;
                    lblnumberofrolls.Text = "0";
                    lbltotal.Text = "0";
                    picdie1.Image = picdie1.Image;
                    picdie2.Image = picdie2.Image;
                    lblpoints.Text = "0";
                    pic4.Visible = false;
                    pic5.Visible = false;
                    pic6.Visible = false;
                    pic8.Visible = false;
                    pic9.Visible = false;
                    pic10.Visible = false;
                }

                
            }

            if (rolls >= 2)
            {

                if (rollsum == 7 && rolls >= 2)
                {
                    MessageBox.Show("You Lose!");
                    rolls = 0;
                    rollsum = 0;
                    lblnumberofrolls.Text = "0";
                    lbltotal.Text = "0";
                    picdie1.Image = picdie1.Image;
                    picdie2.Image = picdie2.Image;
                    lblpoints.Text = "0";
                    pic4.Visible = false;
                    pic5.Visible = false;
                    pic6.Visible = false;
                    pic8.Visible = false;
                    pic9.Visible = false;
                    pic10.Visible = false;
                }

                if (rollsum == pointdecimal && rolls >= 2)
                {
                    MessageBox.Show("You win!");
                    rolls = 0;
                    rollsum = 0;
                    lblnumberofrolls.Text = "0";
                    lbltotal.Text = "0";
                    picdie1.Image = picdie1.Image;
                    picdie2.Image = picdie2.Image;
                    lblpoints.Text =pointdecimal.ToString();
                    lblpoints.Text = "0";
                    pic4.Visible = false;
                    pic5.Visible = false;
                    pic6.Visible = false;
                    pic8.Visible = false;
                    pic9.Visible = false;
                    pic10.Visible = false;
                }

            }

        }
        

        private void Btnrules_Click(object sender, EventArgs e)
        {
    }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            //create a message box to show the use the rules of the game
            MessageBox.Show("Rules to Craps:" + "\n" + "\n" + "You win with a roll of 7 or 11." +
                "\n" + "You lose with a roll of 2,3, or 12." + "\n" + "\n" +
                "If you win or lose the game starts over." + "\n" + "If you roll a 4,5,6,7,8,9,10,on the first roll," 
                + "\n" + "you don't win or lose. You receive what is called a point." + "\n" + 
                "The point is equal to the number that you rolled." + "\n" + "\n" + 
                "If you receive the point, the game is not over and the" + "\n" + "dice are rolled again. When they are rolled again:"
                 + "\n" + "\n" + 
                 "You lose with a roll of 7 and you win if you roll your point." + "\n" + "If you don't roll a 7 or your point, " +
                 "you keep rolling until" + "\n" + "you win or lose.");
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
    }

