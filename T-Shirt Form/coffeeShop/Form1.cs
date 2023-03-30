using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//David Lim
//Date: 10-23-19
//period 5
//project: this program calculates the cst of multiple items and has manager stats.



namespace coffeeShop
{
    public partial class frmMain : Form
    {

        //declare our global level variables
        //declare constants- these hold the prices of the coffees
        const decimal SMALL_PRICE = 10m;
        const decimal MEDIUM_PRICE = 10m;
        const decimal LARGE_PRICE = 10m;
        const decimal EXTRA_LARGE_PRICE = 11m;
        const decimal XXL_PRICE = 12;
        const decimal MONOGRAM_PRICE = 2m;
        const decimal POCKET_PRICE = 1m;


        private decimal subtotal = 0m;
        private decimal totalsales = 0m;
        private decimal averagesale = 0m;
        private int totalcustomers = 0;
        private int ordernumber = 0;

        private decimal totaldecimal = 0m;

        public frmMain()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //this calculates total customer sale
            summaryButton.Enabled = false;
            txtname.Enabled = false;
            //step1: declare local variables
            decimal pricedecimal = 0m;
            int quantityinteger = 0;
            decimal itemamount = 0m;
            lblordernumber.Text = "1";
            try
            {
              


                //step2: get information from the textbox
                quantityinteger = int.Parse(quantityTextBox.Text);

                if (smallRadioButton.Checked)
                {
                    pricedecimal = SMALL_PRICE;
                    if (pocketCheckBox.Checked)
                    {
                        pricedecimal += 1;
                    }
                    if (monogramCheckBox.Checked)
                    {
                        pricedecimal += 2;
                    }
                }
                else if (mediumRadioButton.Checked)
                {
                    pricedecimal = MEDIUM_PRICE;
                    if (pocketCheckBox.Checked)
                    {
                        pricedecimal += 1;
                    }
                    if (monogramCheckBox.Checked)
                    {
                        pricedecimal += 2;
                    }
                }
                else if (largeRadioButton.Checked)
                {
                    pricedecimal = LARGE_PRICE;
                    if (pocketCheckBox.Checked)
                    {
                        pricedecimal += 1;
                    }
                    if (monogramCheckBox.Checked)
                    {
                        pricedecimal += 2;
                    }
                }
                else if (extralargeRadioButton.Checked)
                {
                    pricedecimal = EXTRA_LARGE_PRICE;
                    if (pocketCheckBox.Checked)
                    {
                        pricedecimal += 1;
                    }
                    if (monogramCheckBox.Checked)
                    {
                        pricedecimal += 2;
                    }
                }
                else
                {
                    pricedecimal = XXL_PRICE;
                    if (pocketCheckBox.Checked)
                    {
                        pricedecimal += 1;
                    }
                    if (monogramCheckBox.Checked)
                    {
                        pricedecimal += 2;
                    }
                }

                //step3: calculations
                itemamount = pricedecimal * quantityinteger;
                subtotal += itemamount;
                if (quantityTextBox.Text == "" || txtname.Text == "")
                {
                    MessageBox.Show("Please Enter Correct Information", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtname.Enabled = true;
                }

                //step4: output information
                itemAmountLabel.Text = itemamount.ToString("C");
                totalLabel.Text = subtotal.ToString("C");

            }

            catch
            {
                if (quantityTextBox.Text == "" || txtname.Text == "")
                {
                    MessageBox.Show("Please Enter Correct Information", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtname.Enabled = true;
                }
            



            }


        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //otuputs customer's total cost
            //clear out previous customer's information
            DialogResult resultanswer = DialogResult;
            string messagestring = "";
            resultanswer = MessageBox.Show("Order Complete?",
                "Final Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultanswer == DialogResult.Yes)
            {
                //calculate manager stats
                totalsales += subtotal;
                //totalcustomers += 1;
                ordernumber = 1;
                ordernumber++;
                totalcustomers++;
                lblordernumber.Text = ordernumber.ToString();
                averagesale = totalsales / totalcustomers;
                messagestring = "Your Final Order" + "\n" + "Your Final Price: " + subtotal.ToString("C");

                MessageBox.Show(messagestring, "Thank You!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                subtotal = 0;
                clearButton_Click(sender, e);
                summaryButton.Enabled = true;
                txtname.Enabled = true;
                txtname.Text = "";
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //this clears out the previous information
            quantityTextBox.Clear();
            pocketCheckBox.Checked = false;
            smallRadioButton.Checked = true;
            itemAmountLabel.Text = "";

        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            //output manager stats
            string messagemanager = "";
            messagemanager = "Total Sales: " + totalsales.ToString("C") + "\n" +
                "TotalCustomers: " + totalcustomers.ToString() + "\n" +
                "Average Sale: " + averagesale.ToString("C");

            MessageBox.Show(messagemanager,
                "Store Stats",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ItemAmountLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
