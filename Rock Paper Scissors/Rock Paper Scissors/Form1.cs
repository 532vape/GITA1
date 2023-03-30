using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    //David Lim
    //Period 5
    //11-14-19
    /*This is a rock paper scissors game
     * to play you have to click on one of the three images availible: rock, paper, or scissors
     * player 1 goes first and a prompt appears on screen confirming the decision.
     * player 2 goes next, same thing happens, and a message box tells who the winner is\
     * the scores are displayed at the bottom/
     * */
    public partial class Form1 : Form
    {
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        private DialogResult resultanswer;
        private decimal player1pick;
        private decimal player2pick;
        private int whichone;
        private decimal OneWon = 0;
        private decimal TwoWon = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            resultanswer = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == resultanswer && whichone == 0)
            {
                player1pick = 1;
                MessageBox.Show("Player Two's Turn", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                whichone = 1;
            }
            else if (DialogResult.Yes == resultanswer && whichone == 1)
            {
                player2pick = 1;
                MessageBox.Show("Chosen", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Check();
            }
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            resultanswer = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == resultanswer && whichone == 0)
            {
                player1pick = 2;
                MessageBox.Show("Player Two's Turn", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                whichone = 1;
            }
            else if (DialogResult.Yes == resultanswer && whichone == 1)
            {
                player2pick = 2;
                MessageBox.Show("Chosen", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Check();
            }
        }

        private void Check()
        {
            whichone = 0;

            if (player1pick == 1 && player2pick == 1)
            {
                MessageBox.Show("Both Chose Rock", "Select Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (player1pick == 2 && player2pick == 2)
            {
                MessageBox.Show("Both Chose Paper", "Select Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (player1pick == 3 && player2pick == 3)
            {
                MessageBox.Show("Both Chose Scissors", "Select Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (player1pick == 2 && player2pick == 1)
            {
                MessageBox.Show("Player One Wins", "Select Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OneWon += 1;
            }
            if (player1pick == 1 && player2pick == 2)
            {
                MessageBox.Show("Player Two Wins", "Select Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TwoWon += 1;
            }


            if (player1pick == 3 && player2pick == 2)
            {
                MessageBox.Show("Player One Wins", "Select Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OneWon += 1;
            }
            if (player1pick == 2 && player2pick == 3)
            {
                MessageBox.Show("Player Two Wins", "Select Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TwoWon += 1;
            }


            if (player1pick == 1 && player2pick == 3)
            {
                MessageBox.Show("Player One Wins", "Select Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OneWon += 1;
            }
            if (player1pick == 3 && player2pick == 1)
            {
                MessageBox.Show("Player Two Wins", "Select Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TwoWon += 1;
            }
            player1pick = 0;
            player2pick = 0;

            lblNumOf1.Text = OneWon.ToString();
            lblNumOf2.Text = TwoWon.ToString();
        }

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {

            resultanswer = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == resultanswer && whichone == 0)
            {
                player1pick = 3;
                MessageBox.Show("Player Two's Turn", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                whichone = 1;
            }
            else if (DialogResult.Yes == resultanswer && whichone == 1)
            {
                player2pick = 3;
                MessageBox.Show("Chosen", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Check();
            }

            Check();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            //this clsoes the application
            this.Close();
        }
    }
}
