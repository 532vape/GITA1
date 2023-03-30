using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slots
{/*David Lim
    Period 5
    11-6-19
    This program rolls 3 different sets of numbers. An image corresponds with each number generated.
    You can enter in bets of $1, $2, $3, $4, and $5 to play
    */
    public partial class Form1 : Form
    {
        System.Random r =
            new System.Random((int)System.DateTime.Now.Ticks);

        private decimal rolls;
        private decimal decimalmoney;
        decimal jackpot = 1000m;
        public Form1()
        {
            InitializeComponent();
        }

        private void Picgold_Click(object sender, EventArgs e)
        {

        }

        private void Btnroll_Click(object sender, EventArgs e)
        {
            //step 1: generates numbers from 1-5 and declare decimals
            int randomroll1 = r.Next(1, 6);
            int randomroll2 = r.Next(1, 6);
            int randomroll3 = r.Next(1, 6);

            try
            {

             
                //#2: count number of rolls
                rolls++;

                //stop people from rolling without credits
                string messagestring = "";

                if (rad1dollar.Checked)
                {
                    if (decimalmoney < 1)
                    {
                        messagestring = "You Are Out of Credits" + "\n" + "Please Insert Money";
                        MessageBox.Show(messagestring, "No Credits", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        picblank.Image = blank.Image;
                        picblank2.Image = blank.Image;
                        picblank3.Image = blank.Image;
                        decimalmoney = 0;
                    }

                    if (decimalmoney >= 1)
                    {
                        decimalmoney -= 1;

                        //#3: calculate rolls for first column
                        if (randomroll1 == 1)
                        {
                            picblank.Image = piccoal.Image;
                        }
                        if (randomroll1 == 2)
                        {
                            picblank.Image = piciron.Image;
                        }
                        if (randomroll1 == 3)
                        {
                            picblank.Image = picgold.Image;
                        }
                        if (randomroll1 == 4)
                        {
                            picblank.Image = picemerald.Image;
                        }
                        if (randomroll1 == 5)
                        {
                            picblank.Image = picdiamond.Image;
                        }

                        //and for second column
                        if (randomroll2 == 1)
                        {
                            picblank2.Image = piccoal.Image;
                        }
                        if (randomroll2 == 2)
                        {
                            picblank2.Image = piciron.Image;
                        }
                        if (randomroll2 == 3)
                        {
                            picblank2.Image = picgold.Image;
                        }
                        if (randomroll2 == 4)
                        {
                            picblank2.Image = picemerald.Image;
                        }
                        if (randomroll2 == 5)
                        {
                            picblank2.Image = picdiamond.Image;
                        }

                        //and for third column
                        if (randomroll3 == 1)
                        {
                            picblank3.Image = piccoal.Image;
                        }
                        if (randomroll3 == 2)
                        {
                            picblank3.Image = piciron.Image;
                        }
                        if (randomroll3 == 3)
                        {
                            picblank3.Image = picgold.Image;
                        }
                        if (randomroll3 == 4)
                        {
                            picblank3.Image = picemerald.Image;
                        }
                        if (randomroll3 == 5)
                        {
                            picblank3.Image = picdiamond.Image;
                        }




                        lblcredits.Text = decimalmoney.ToString();
                        //determine if the user has won
                        if (randomroll1 == randomroll2 && randomroll1 == randomroll3 && randomroll3 == randomroll2)
                        {
                            decimal prize;
                            prize = decimalmoney += jackpot;
                            messagestring = "You Won:" + prize.ToString("C");
                            MessageBox.Show(messagestring, "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lbljackpot.Text = "$1,000.00";
                            jackpot = 1000m;
                            decimalmoney = 0;

                        }
                        else
                        {
                            jackpot += 1;
                            lbljackpot.Text = jackpot.ToString("C");
                        }
                        lblcredits.Text = decimalmoney.ToString();


                    }
                }


                if (rad2dollars.Checked)
                {
                    if (decimalmoney < 2)
                    {
                        messagestring = "You Are Out of Credits" + "\n" + "Please Insert Money";
                        MessageBox.Show(messagestring, "No Credits", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        picblank.Image = blank.Image;
                        picblank2.Image = blank.Image;
                        picblank3.Image = blank.Image;
                        decimalmoney = 0;
                    }

                    if (decimalmoney >= 2)
                    {
                        decimalmoney -= 2;

                        //#3: calculate rolls for first column
                        if (randomroll1 == 1)
                        {
                            picblank.Image = piccoal.Image;
                        }
                        if (randomroll1 == 2)
                        {
                            picblank.Image = piciron.Image;
                        }
                        if (randomroll1 == 3)
                        {
                            picblank.Image = picgold.Image;
                        }
                        if (randomroll1 == 4)
                        {
                            picblank.Image = picemerald.Image;
                        }
                        if (randomroll1 == 5)
                        {
                            picblank.Image = picdiamond.Image;
                        }

                        //and for second column
                        if (randomroll2 == 1)
                        {
                            picblank2.Image = piccoal.Image;
                        }
                        if (randomroll2 == 2)
                        {
                            picblank2.Image = piciron.Image;
                        }
                        if (randomroll2 == 3)
                        {
                            picblank2.Image = picgold.Image;
                        }
                        if (randomroll2 == 4)
                        {
                            picblank2.Image = picemerald.Image;
                        }
                        if (randomroll2 == 5)
                        {
                            picblank2.Image = picdiamond.Image;
                        }

                        //and for third column
                        if (randomroll3 == 1)
                        {
                            picblank3.Image = piccoal.Image;
                        }
                        if (randomroll3 == 2)
                        {
                            picblank3.Image = piciron.Image;
                        }
                        if (randomroll3 == 3)
                        {
                            picblank3.Image = picgold.Image;
                        }
                        if (randomroll3 == 4)
                        {
                            picblank3.Image = picemerald.Image;
                        }
                        if (randomroll3 == 5)
                        {
                            picblank3.Image = picdiamond.Image;
                        }




                        lblcredits.Text = decimalmoney.ToString();
                        //determine if the user has won
                        if (randomroll1 == randomroll2 && randomroll1 == randomroll3 && randomroll3 == randomroll2)
                        {
                            decimal prize;
                            prize = decimalmoney += jackpot;
                            messagestring = "You Won:" + prize.ToString("C");
                            MessageBox.Show(messagestring, "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lbljackpot.Text = "$1,000.00";
                            jackpot = 1000m;
                            decimalmoney = 0;

                        }
                        else
                        {
                            jackpot += 2;
                            lbljackpot.Text = jackpot.ToString("C");
                        }
                        lblcredits.Text = decimalmoney.ToString();


                    }
                }


                if (rad3dollars.Checked)
                {
                    if (decimalmoney < 3)
                    {
                        messagestring = "You Are Out of Credits" + "\n" + "Please Insert Money";
                        MessageBox.Show(messagestring, "No Credits", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        picblank.Image = blank.Image;
                        picblank2.Image = blank.Image;
                        picblank3.Image = blank.Image;
                        decimalmoney = 0;
                    }

                    if (decimalmoney >= 3)
                    {
                        decimalmoney -= 3;

                        //#3: calculate rolls for first column
                        if (randomroll1 == 1)
                        {
                            picblank.Image = piccoal.Image;
                        }
                        if (randomroll1 == 2)
                        {
                            picblank.Image = piciron.Image;
                        }
                        if (randomroll1 == 3)
                        {
                            picblank.Image = picgold.Image;
                        }
                        if (randomroll1 == 4)
                        {
                            picblank.Image = picemerald.Image;
                        }
                        if (randomroll1 == 5)
                        {
                            picblank.Image = picdiamond.Image;
                        }

                        //and for second column
                        if (randomroll2 == 1)
                        {
                            picblank2.Image = piccoal.Image;
                        }
                        if (randomroll2 == 2)
                        {
                            picblank2.Image = piciron.Image;
                        }
                        if (randomroll2 == 3)
                        {
                            picblank2.Image = picgold.Image;
                        }
                        if (randomroll2 == 4)
                        {
                            picblank2.Image = picemerald.Image;
                        }
                        if (randomroll2 == 5)
                        {
                            picblank2.Image = picdiamond.Image;
                        }

                        //and for third column
                        if (randomroll3 == 1)
                        {
                            picblank3.Image = piccoal.Image;
                        }
                        if (randomroll3 == 2)
                        {
                            picblank3.Image = piciron.Image;
                        }
                        if (randomroll3 == 3)
                        {
                            picblank3.Image = picgold.Image;
                        }
                        if (randomroll3 == 4)
                        {
                            picblank3.Image = picemerald.Image;
                        }
                        if (randomroll3 == 5)
                        {
                            picblank3.Image = picdiamond.Image;
                        }




                        lblcredits.Text = decimalmoney.ToString();
                        //determine if the user has won
                        if (randomroll1 == randomroll2 && randomroll1 == randomroll3 && randomroll3 == randomroll2)
                        {
                            decimal prize;
                            prize = decimalmoney += jackpot;
                            messagestring = "You Won:" + prize.ToString("C");
                            MessageBox.Show(messagestring, "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lbljackpot.Text = "$1,000.00";
                            jackpot = 1000m;
                            decimalmoney = 0;

                        }
                        else
                        {
                            jackpot += 3;
                            lbljackpot.Text = jackpot.ToString("C");
                        }
                        lblcredits.Text = decimalmoney.ToString();


                    }
                }


                if (rad4dollars.Checked)
                {
                    if (decimalmoney < 4)
                    {
                        messagestring = "You Are Out of Credits" + "\n" + "Please Insert Money";
                        MessageBox.Show(messagestring, "No Credits", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        picblank.Image = blank.Image;
                        picblank2.Image = blank.Image;
                        picblank3.Image = blank.Image;
                        decimalmoney = 0;
                    }

                    if (decimalmoney >= 4)
                    {
                        decimalmoney -= 4;

                        //#3: calculate rolls for first column
                        if (randomroll1 == 1)
                        {
                            picblank.Image = piccoal.Image;
                        }
                        if (randomroll1 == 2)
                        {
                            picblank.Image = piciron.Image;
                        }
                        if (randomroll1 == 3)
                        {
                            picblank.Image = picgold.Image;
                        }
                        if (randomroll1 == 4)
                        {
                            picblank.Image = picemerald.Image;
                        }
                        if (randomroll1 == 5)
                        {
                            picblank.Image = picdiamond.Image;
                        }

                        //and for second column
                        if (randomroll2 == 1)
                        {
                            picblank2.Image = piccoal.Image;
                        }
                        if (randomroll2 == 2)
                        {
                            picblank2.Image = piciron.Image;
                        }
                        if (randomroll2 == 3)
                        {
                            picblank2.Image = picgold.Image;
                        }
                        if (randomroll2 == 4)
                        {
                            picblank2.Image = picemerald.Image;
                        }
                        if (randomroll2 == 5)
                        {
                            picblank2.Image = picdiamond.Image;
                        }

                        //and for third column
                        if (randomroll3 == 1)
                        {
                            picblank3.Image = piccoal.Image;
                        }
                        if (randomroll3 == 2)
                        {
                            picblank3.Image = piciron.Image;
                        }
                        if (randomroll3 == 3)
                        {
                            picblank3.Image = picgold.Image;
                        }
                        if (randomroll3 == 4)
                        {
                            picblank3.Image = picemerald.Image;
                        }
                        if (randomroll3 == 5)
                        {
                            picblank3.Image = picdiamond.Image;
                        }




                        lblcredits.Text = decimalmoney.ToString();
                        //determine if the user has won
                        if (randomroll1 == randomroll2 && randomroll1 == randomroll3 && randomroll3 == randomroll2)
                        {
                            decimal prize;
                            prize = decimalmoney += jackpot;
                            messagestring = "You Won:" + prize.ToString("C");
                            MessageBox.Show(messagestring, "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lbljackpot.Text = "$1,000.00";
                            jackpot = 1000m;
                            decimalmoney = 0;

                        }
                        else
                        {
                            jackpot += 4;
                            lbljackpot.Text = jackpot.ToString("C");
                        }
                        lblcredits.Text = decimalmoney.ToString();


                    }
                }







                if (rad5dollars.Checked)
                {
                    if (decimalmoney < 5)
                    {
                        messagestring = "You Are Out of Credits" + "\n" + "Please Insert Money";
                        MessageBox.Show(messagestring, "No Credits", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        picblank.Image = blank.Image;
                        picblank2.Image = blank.Image;
                        picblank3.Image = blank.Image;
                        decimalmoney = 0;
                    }

                    if (decimalmoney >= 5)
                    {
                        decimalmoney -= 5;

                        //#3: calculate rolls for first column
                        if (randomroll1 == 1)
                        {
                            picblank.Image = piccoal.Image;
                        }
                        if (randomroll1 == 2)
                        {
                            picblank.Image = piciron.Image;
                        }
                        if (randomroll1 == 3)
                        {
                            picblank.Image = picgold.Image;
                        }
                        if (randomroll1 == 4)
                        {
                            picblank.Image = picemerald.Image;
                        }
                        if (randomroll1 == 5)
                        {
                            picblank.Image = picdiamond.Image;
                        }

                        //and for second column
                        if (randomroll2 == 1)
                        {
                            picblank2.Image = piccoal.Image;
                        }
                        if (randomroll2 == 2)
                        {
                            picblank2.Image = piciron.Image;
                        }
                        if (randomroll2 == 3)
                        {
                            picblank2.Image = picgold.Image;
                        }
                        if (randomroll2 == 4)
                        {
                            picblank2.Image = picemerald.Image;
                        }
                        if (randomroll2 == 5)
                        {
                            picblank2.Image = picdiamond.Image;
                        }

                        //and for third column
                        if (randomroll3 == 1)
                        {
                            picblank3.Image = piccoal.Image;
                        }
                        if (randomroll3 == 2)
                        {
                            picblank3.Image = piciron.Image;
                        }
                        if (randomroll3 == 3)
                        {
                            picblank3.Image = picgold.Image;
                        }
                        if (randomroll3 == 4)
                        {
                            picblank3.Image = picemerald.Image;
                        }
                        if (randomroll3 == 5)
                        {
                            picblank3.Image = picdiamond.Image;
                        }




                        lblcredits.Text = decimalmoney.ToString();
                        //determine if the user has won
                        if (randomroll1 == randomroll2 && randomroll1 == randomroll3 && randomroll3 == randomroll2)
                        {
                            decimal prize;
                            prize = decimalmoney += jackpot;
                            messagestring = "You Won:" + prize.ToString("C");
                            MessageBox.Show(messagestring, "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lbljackpot.Text = "$1,000.00";
                            jackpot = 1000m;
                            decimalmoney = 0;

                        }
                        else
                        {
                            jackpot += 5;
                            lbljackpot.Text = jackpot.ToString("C");
                        }


                    }

                    lblcredits.Text = decimalmoney.ToString();
                    //  decimalmoney -= (rolls * 5);
                }








            }
            catch
            {
                //stop people from rolling without credits
                string messagestring = "";

                    messagestring = "You Are Out of Credits" + "\n" + "Please Insert Money";
                    MessageBox.Show(messagestring, "No Credits", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    picblank.Image = blank.Image;
                    picblank2.Image = blank.Image;
                    picblank3.Image = blank.Image;
                    decimalmoney = 0;

                    
            }
        }

                    private void Piciron_Click(object sender, EventArgs e)
        {

        }

        private void Btnmoney_Click(object sender, EventArgs e)
        {
            try
            {
                decimalmoney += Decimal.Parse(txtmoney.Text);
                btnroll.Enabled = true;
                lblcredits.Text = decimalmoney.ToString();
                txtmoney.Text = "";

            }
            catch
            {
                string messagestring = "";

                    messagestring = "Please Enter Money";
                    MessageBox.Show(messagestring, "No Money", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    picblank.Image = blank.Image;
                    picblank2.Image = blank.Image;
                    picblank3.Image = blank.Image;
                
            }
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
