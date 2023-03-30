using System;
using System.Windows.Forms;

namespace College_Bowl
{
    /*David Lim
     * GITA 1 Per 5
     * 12/16/19
     * this shows you the results of multiple bowl games for two different ncaaf football teams
     * you can also see about pages about each team
     */
    public partial class Form1 : Form
    {
        //declare global variables to output text to labels
        private string Opponent;
        private string Score;
        private string Opponent1;
        private string Score1;

        public Form1()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Picairforce_Click(object sender, EventArgs e)
        {

        }

        private void Radairforce_CheckedChanged(object sender, EventArgs e)
        {
            if (radairforce.Checked)
            {
                //make the airforce logo bigger when checked
                picairforce.Visible = true;
                picairforcesmall.Visible = false;
            }

            else
            {
                //make the airforce logo smaller when unchecked
                picairforce.Visible = false;
                picairforcesmall.Visible = true;
            }


        }

        private void Radwashington_CheckedChanged(object sender, EventArgs e)
        {
            if (radwashington.Checked)
            {
                //make the washington logo bigger when checked
                picwashington.Visible = true;
                picwashingtonsmall.Visible = false;
            }

            else
            {
                //make the washington logo smaller when unchecked
                picwashington.Visible = false;
                picwashingtonsmall.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboscheduleaf.SelectedIndex >= 0 || cboschedulews.SelectedIndex >= 0)
            {
                thoughtsOnResultsToolStripMenuItem.Enabled = true;
            }
            //show stats for bowl games for Air Force
            if (cboscheduleaf.SelectedIndex == 0)
            {
                Opponent = "Washington State";
                Score = "TBD";
            }

            if (cboscheduleaf.SelectedIndex == 1)
            {
                Opponent = "South Alabama Jaguars";
                Score = "Win: 45-21";
            }

            if (cboscheduleaf.SelectedIndex == 2)
            {
                Opponent = "California Golden Bears";
                Score = "Loss: 36-55";
            }

            if (cboscheduleaf.SelectedIndex == 3)
            {
                Opponent = "Western Michigan Broncos";
                Score = "Win: 38-24";
            }

            if (cboscheduleaf.SelectedIndex == 4)
            {
                Opponent = "Rice Owls";
                Score = "Loss: 14-33";
            }

            if (cboscheduleaf.SelectedIndex == 5)
            {
                Opponent = "Toledo Rockets";
                Score = "Loss: 41-42";
            }

            if (cboscheduleaf.SelectedIndex == 6)
            {
                Opponent = "Georgia Tech Yellow Jackets";
                Score = "Win: 14-7";
            }

            if (cboscheduleaf.SelectedIndex == 7)
            {
                Opponent = "Houston Cougars";
                Score = "Win: 47-20";
            }

            if (cboscheduleaf.SelectedIndex == 8)
            {
                Opponent = "Houston Cougars";
                Score = "Loss: 28-34";
            }

            if (cboscheduleaf.SelectedIndex == 9)
            {
                Opponent = "California Golden Bears";
                Score = "Loss: 36-42";
            }

            if (cboscheduleaf.SelectedIndex == 10)
            {
                Opponent = "Virginia Tech Hokies";
                Score = "Loss: 13-20";
            }

            if (cboscheduleaf.SelectedIndex == 11)
            {
                Opponent = "Fresno State";
                Score = "Win: 37-34";
            }

            if (cboscheduleaf.SelectedIndex == 12)
            {
                Opponent = "Washington Huskies";
                Score = "Win: 43-25";
            }

            if (cboscheduleaf.SelectedIndex == 13)
            {
                Opponent = "Oregon Ducks";
                Score = "Loss: 13-41";
            }

            if (cboscheduleaf.SelectedIndex == 14)
            {
                Opponent = "Texas Tech Red Raiders";
                Score = "Loss: 41-55";
            }

            if (cboscheduleaf.SelectedIndex == 15)
            {
                Opponent = "Ole Miss Rebels";
                Score = "Loss: 0-13";
            }

            if (cboscheduleaf.SelectedIndex == 16)
            {
                Opponent = "Mississippi State Bulldogs";
                Score = "Win: 31-15";
            }

            if (cboscheduleaf.SelectedIndex == 17)
            {
                Opponent = "Ohio State Buckeyes";
                Score = "Win: 23-11";
            }

            if (cboscheduleaf.SelectedIndex == 18)
            {
                Opponent = "Ole Miss Rebels";
                Score = "Loss: 29-42";
            }

            if (cboscheduleaf.SelectedIndex == 19)
            {
                Opponent = "Arizona State Sun Devils";
                Score = "Loss: 28-33";
            }

            //output text to labels
            lblairforce.Text = cboscheduleaf.Items[cboscheduleaf.SelectedIndex].ToString() +
              "\n" + "\n" + "Opponent: " + Opponent.ToString() +
              "\n" + "\n" + Score.ToString();


        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show each respective teams' schedules
            if (schedule.SelectedIndex == 0)
            {
                picschedule.Image = picairforceseason.Image;
            }
            if (schedule.SelectedIndex == 1)
            {
                picschedule.Image = picwashingtonseason.Image;
            }

        }

        private void Lblairforce_Click(object sender, EventArgs e)
        {

        }

        private void Cboschedulews_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboscheduleaf.SelectedIndex >= 0 || cboschedulews.SelectedIndex >= 0)
            {
                thoughtsOnResultsToolStripMenuItem.Enabled = true;
            }
            //shows stats for bowl games for Washington State
            if (cboschedulews.SelectedIndex == 0)
            {
                Opponent1 = "Air Force Falcons";
                Score1 = "TBD";
            }

            if (cboschedulews.SelectedIndex == 1)
            {
                Opponent1 = "Iowa State Cyclones";
                Score1 = "Win: 28-26";
            }

            if (cboschedulews.SelectedIndex == 2)
            {
                Opponent1 = "Michigan State Spartans";
                Score1 = "Loss: 17-42";
            }

            if (cboschedulews.SelectedIndex == 3)
            {
                Opponent1 = "Minnesota Golden Gophers";
                Score1 = "Loss: 12-17";
            }

            if (cboschedulews.SelectedIndex == 4)
            {
                Opponent1 = "Miami Hurricanes";
                Score1 = "Win: 20-14";
            }

            if (cboschedulews.SelectedIndex == 5)
            {
                Opponent1 = "Colorado State Rams";
                Score1 = "Loss: 45-48";
            }

            if (cboschedulews.SelectedIndex == 6)
            {
                Opponent1 = "Texas Longhorns";
                Score1 = "Win: 28-20";
            }

            if (cboschedulews.SelectedIndex == 7)
            {
                Opponent1 = "Oklahoma Sooners";
                Score1 = "Loss: 14-34";
            }

            if (cboschedulews.SelectedIndex == 8)
            {
                Opponent1 = "Purdue Boilermakers";
                Score1 = "Win: 33-27";
            }

            if (cboschedulews.SelectedIndex == 9)
            {
                Opponent1 = "Michigan Wolverines";
                Score1 = "Loss: 16-21";
            }

            if (cboschedulews.SelectedIndex == 10)
            {
                Opponent1 = "Baylor Bears";
                Score1 = "Win: 10-3";
            }

            if (cboschedulews.SelectedIndex == 11)
            {
                Opponent1 = "Utah Utes";
                Score1 = "Win: 31-28";
            }

            if (cboschedulews.SelectedIndex == 12)
            {
                Opponent1 = "Houston Cougars";
                Score1 = "Win: 24-22";
            }

            if (cboschedulews.SelectedIndex == 13)
            {
                Opponent1 = "BYU Cougars";
                Score1 = "Loss: 36-38";
            }

            if (cboschedulews.SelectedIndex == 14)
            {
                Opponent1 = "Alabama Crimson Tide";
                Score1 = "Loss: 0-24";
            }

            if (cboschedulews.SelectedIndex == 15)
            {
                Opponent1 = "Brown Bears";
                Score1 = "Win: 14-0";
            }

            //output text to labels
            lblwashington.Text = cboschedulews.Items[cboschedulews.SelectedIndex].ToString() +
              "\n" + "\n" + "Opponent: " + Opponent1.ToString() +
              "\n" + "\n" + Score1.ToString();

        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clear the screen
            cleartext();
        }

        private void cleartext()
        {
            picschedule.Image = null;
            lblairforce.Text = "";
            lblwashington.Text = "";
            cboscheduleaf.Text = "";
            cboschedulews.Text = "";
        }

        private void AirForceFalconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this opens an info page about the air force falcons
            frmairforce openabout = new frmairforce();
            openabout.ShowDialog();
        }

        private void WashingtonStateCougarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this opens an info page about the washington state cougars
            frmaboutws openabout = new frmaboutws();
            openabout.ShowDialog();
        }

        private void ThoughtsOnResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tell opinion
            if (radairforce.Checked && cboscheduleaf.SelectedIndex == 0)
            {
                frmopinionaf openabout = new frmopinionaf();
                openabout.ShowDialog();
            }

            if (radwashington.Checked & cboschedulews.SelectedIndex == 0)
            {
                frmopinionws openabout = new frmopinionws();
                openabout.ShowDialog();
            }

            else if (cboscheduleaf.SelectedIndex >= 1 || cboschedulews.SelectedIndex >= 1)
            {
                frmopinion openabout = new frmopinion();
                openabout.ShowDialog();
            }

        }
    }
}
