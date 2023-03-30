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
        private decimal totalsales;
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
            decimal extendedpricedecimal;
            decimal milespricedecimal;
            decimal averagesalesdecimal;

            //step 2:gets data from user and stores
            try

            {
                txtodometerstartdecimal = decimal.Parse(txtstartingodometer.Text);
                txtodometerenddecimal = decimal.Parse(txtendingodometer.Text);
                daysrenteddecimal = decimal.Parse(txtdaysrented.Text);

                //step 3: mathematical calculations

                milesdrivendecimal = txtodometerenddecimal - txtodometerstartdecimal;
                milespricedecimal = milesdrivendecimal * (decimal)0.12;
                daysrenteddecimal = daysrenteddecimal * 15;
                extendedpricedecimal = milespricedecimal + daysrenteddecimal;

                //manager's calculations

                carsreturned += 1;
                totalsales += extendedpricedecimal;
                averagesales = totalsales / carsreturned;

                //step4: output final answers to labels

                lbltotalcost2.Text = extendedpricedecimal.ToString("C");
                lblmiles.Text = milesdrivendecimal.ToString();

                lblcarsreturned.Text = carsreturned.ToString();
                labeltotalsales.Text = totalsales.ToString("C");
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
            clearcode();

            

            
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Lblmiles_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
