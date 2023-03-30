using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//David Lim
//Date: 9-23-19
//Period 5
/*Car rental
 * this calculates (miles driven * 0.12) + (day rented * 15)
 * calculates average sales
 * calculates total sales
 * calculates how many cars returned
 */

namespace Car_Rental_1
{

    public partial class Form1 : Form
    {

        //these are global level variables
        //they hold their content through the life of the program
        private decimal carsreturned;
        private decimal allsales;
        private decimal averagesales;
 


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Lblmessage_Click(object sender, EventArgs e)
        {

        }

        private void Lblmilesdriven_Click(object sender, EventArgs e)
        {

        }

        private void Txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Lbltotalcost_Click(object sender, EventArgs e)
        {

        }

        private void Lblendingodometer_Click(object sender, EventArgs e)
        {

        }

        private void Btncalculate_Click(object sender, EventArgs e)
        {
            //this gets the information from the textboxes into the label

            lblmessage.Text = txtfirstname.Text + " " + txtlastname.Text + "\n" + txtaddress.Text
                + "\n" + txtcity.Text + ", " + txtstate.Text + " " + txtzipcode.Text;

            //this calculates the car rental cost
            //step 1: declare variables to store information

            decimal txtodometerstartdecimal;
            decimal txtodometerenddecimal;
            decimal milesdrivendecimal;
            decimal daysrenteddecimal;
            decimal milespricedecimal;
            decimal priceperdaydecimal;
            decimal totalsalesdecimal;
            decimal milesdrivenalternate;
         
 



            //step 2:gets data from user and stores
            try

            {
                txtodometerstartdecimal = decimal.Parse(txtstartingodometer.Text);
                txtodometerenddecimal = decimal.Parse(txtendingodometer.Text);
                daysrenteddecimal = decimal.Parse(txtdaysrented.Text);
                priceperdaydecimal = 0;
                milespricedecimal = 0;
                
              
                
                 
                



                //step 3: mathematical calculations

                milesdrivendecimal = (txtodometerenddecimal - txtodometerstartdecimal);
                milesdrivenalternate = milesdrivendecimal;

                if (milesdrivendecimal <= 100)
                {

                    milesdrivendecimal = 0;

                }

                else if (milesdrivendecimal >= 100)
                {

                    milesdrivendecimal = milesdrivendecimal - 100;

                }

                if (chkbosesound.Checked)
                {

                    priceperdaydecimal = priceperdaydecimal + 3;

                }

                if (chkleather.Checked)
                {

                    priceperdaydecimal = priceperdaydecimal + 2 ;

                }

                //step 4: this determines the price of the car

                if (radhummer.Checked)
                {

                    picpic = pichummer;
                    priceperdaydecimal = (priceperdaydecimal + 15) * daysrenteddecimal;
                    milespricedecimal = milesdrivendecimal * (decimal)0.12;
                    totalsalesdecimal = priceperdaydecimal + milespricedecimal;

                    

                }

                else if (radhumvee.Checked)
                {

                    picpic = picboxhumvee;
                    priceperdaydecimal = (priceperdaydecimal + 20) * daysrenteddecimal;
                    milespricedecimal = milesdrivendecimal * (decimal)0.15;
                    totalsalesdecimal = priceperdaydecimal + milespricedecimal;

                }

                else if (radm1abrams.Checked)
                {

                    picpic = picm1abrams;
                    priceperdaydecimal = (priceperdaydecimal + 25) * daysrenteddecimal;
                    milespricedecimal = milesdrivendecimal * (decimal)0.20;
                    totalsalesdecimal = priceperdaydecimal + milespricedecimal;

                }

                

                //manager's calculations

                carsreturned += 1;
                allsales += (priceperdaydecimal + milespricedecimal);
                averagesales = allsales / carsreturned;

                //step 5: output final answers to labels

                lbltotalcost2.Text = allsales.ToString("C");
                lblmiles.Text = milesdrivenalternate.ToString();
                lblcarsreturned.Text = carsreturned.ToString();
                labeltotalsales.Text = allsales.ToString("C");
                labelaveragesales.Text = averagesales.ToString("C");
                clearcode();


            }

            catch
            {

                MessageBox.Show("Enter Data");
            }


        }

        private void Txtzipcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            //calls code to clear textboxes


        }
        //create a function to clear textboxes
        private void clearcode()
        {
            txtfirstname.Text = "";
            txtlastname.Clear();
            txtaddress.Clear();
            txtcity.Clear();
            txtstate.Clear();
            txtzipcode.Clear();
            txtstartingodometer.Clear();
            txtendingodometer.Clear();
            txtdaysrented.Clear();

        }

        private void Btnclearall_Click(object sender, EventArgs e)
        {
            //this clears all information in the program

            lblcarsreturned.Text = " ";
            labeltotalsales.Text = " ";
            labelaveragesales.Text = " ";
            lbltotalcost2.Text = " ";
            lblmiles.Text = " ";
            lblmessage.Text = " ";
            labelvehicle.Text = " ";
            lblpriceperday.Text = " ";
            lblpricepermile.Text = " ";
            clearcode();




        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Lblmiles_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Lblblank_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Radhummer_CheckedChanged(object sender, EventArgs e)
        {
            

                labelvehicle.Text = "Hummer";
                lblpriceperday.Text = "$15/Day";
                lblpricepermile.Text = "$0.12/Mile";
                picpic.Image = pichummer.Image;
                
            
        }

        private void Chkleather_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lblhummer2_Click(object sender, EventArgs e)
        {

        }

        private void Radhumvee_CheckedChanged(object sender, EventArgs e)
        {

            picpic.Image = picboxhumvee.Image;
            labelvehicle.Text = "Humvee";
            lblpriceperday.Text = "$20/Day";
            lblpricepermile.Text = "$0.15/Day";
        }

        private void Label15_Click_1(object sender, EventArgs e)
        {

        }

        private void Radm1abrams_CheckedChanged(object sender, EventArgs e)
        {

            picpic.Image = picm1abrams.Image;
            labelvehicle.Text = "M1 Abrams";
            lblpriceperday.Text = "$25/Day";
            lblpricepermile.Text = "$0.20/Day";

        }
    }
}
