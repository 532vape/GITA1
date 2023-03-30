using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Programmer Name: 
//Date: 10-23-19
//period 5
//project: this program calculates the cst of multiple items and has manager stats



namespace coffeeShop
{
    public partial class frmMain : Form
    {

        //declare our global level variables
        //declare constants- these hold the prices of the coffees
        const decimal CAPUCCINO_PRICE = 2m;
        const decimal ESPRESSO_PRICE = 2.5m;
        const decimal LATTE_PRICE = 1.75m;
        const decimal ICED_LATTE_PRICE = 2.5m;
        const decimal ICED_CAPUCCINO_PRICE = 2.25m;

        const decimal TAX_RATE = 0.08m;

        private decimal subtotal = 0m;
        private decimal totalsales = 0m;
        private decimal averagesale = 0m;
        private int totalcustomers = 0;

        private decimal totaldecimal = 0m;

        public frmMain()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //this calculates total customer sale
            summaryButton.Enabled = false;
            //step1: declare local variables
            decimal pricedecimal = 0m;
            int quantityinteger = 0;
            decimal taxdecimal = 0m;
            decimal itemamount = 0m;

            //step2: get information from the textbox
            quantityinteger = int.Parse(quantityTextBox.Text);

            if (cappuccinoRadioButton.Checked)
            {
                pricedecimal = CAPUCCINO_PRICE;
            }
            else if (espressoRadioButton.Checked)
            {
                pricedecimal = ESPRESSO_PRICE;
            }
            else if (icedLatteRadioButton.Checked)
            {
                pricedecimal = ICED_LATTE_PRICE;
            }
            else if (LatteRadioButton.Checked)
            {
                pricedecimal = LATTE_PRICE;
            }
            else
            {
                pricedecimal = ICED_CAPUCCINO_PRICE;
            }

            //step3: calculations
            itemamount = pricedecimal * quantityinteger;
            subtotal += itemamount;
            if (taxCheckBox.Checked)
            {
                taxdecimal = subtotal * TAX_RATE;
            }
            else
            {
                taxdecimal = 0;
            }
            totaldecimal = subtotal + taxdecimal;

            //step4: output information
            itemAmountLabel.Text = itemamount.ToString("C");
            subtotalLabel.Text = subtotal.ToString("C");
            taxLabel.Text = taxdecimal.ToString("C");
            totalLabel.Text = totaldecimal.ToString("C");
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
                totalcustomers++;
                averagesale = totalsales / totalcustomers;
                messagestring = "Your Final Order" + "\n" + "Your Final Price: " + subtotal.ToString("C");

                MessageBox.Show(messagestring, "Thank You!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                subtotal = 0;
                clearButton_Click(sender, e);
                summaryButton.Enabled = true;
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //this clears out the previous information
            quantityTextBox.Clear();
            taxCheckBox.Checked = false;
            cappuccinoRadioButton.Checked = true;
            itemAmountLabel.Text = "";
            subtotalLabel.Text = "";
            taxLabel.Text = "";
            totalLabel.Text = "";

        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            //output manager stats
            string messagemanager = "";
            messagemanager = "Total Sales: " + totalsales.ToString("C")  +"\n" +
                "TotalCustomers: " + totalcustomers.ToString() + "\n" +
                "Average Sale: " + averagesale.ToString("C");

            MessageBox.Show(messagemanager,
                "Store Stats", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
