using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Programmer: David Lim
//date: 9-19-19
//Period 5
/*Project Description: Book Sales
 * This calculates price * quantity
 * calculates discount
 * calculates final price
 */

namespace Bookstore
{
    public partial class Form1 : Form
    {

        //these are global level variables
        //they hold their contents through the life of the program
        private decimal totalpeople;
        private decimal totalsales;
        private decimal averagesales;


        public Form1()
        {
            InitializeComponent();
        }

        private void Lblextendedprice_Click(object sender, EventArgs e)
        {

        }

        private void Btncalculate_Click(object sender, EventArgs e)
        {

            //this calculates the discount book price
            //step 1: declare variables to store information

            decimal pricedecimal;
            decimal quanititydecimal;
            decimal extendedpricedecimal;
            decimal discountdecimal;
            decimal discountpricedecimal;
            decimal averagesaledecimal;

            //step 2: gets data from user and stores
            try

            {

                pricedecimal = decimal.Parse(txtprice.Text);
                quanititydecimal = decimal.Parse(txtquantity.Text);

                //step 3: mathematical calculations

                extendedpricedecimal = pricedecimal * quanititydecimal;
                discountdecimal = extendedpricedecimal * (decimal)0.15;

                discountpricedecimal = extendedpricedecimal - discountdecimal;

                //manager's calculations
                totalpeople += 1;
                totalsales += discountpricedecimal;
                averagesaledecimal = totalsales / totalpeople;




                //step 4: output final answers to the labels

                lblextendedprice.Text = extendedpricedecimal.ToString("C");
                lbldiscountamount.Text = discountdecimal.ToString("C");
                lbldiscountprice.Text = discountpricedecimal.ToString("C");

                lbltotalpeople.Text = totalpeople.ToString();
                lbltotalsales.Text = totalsales.ToString("C");
                lblaveragesale.Text = averagesaledecimal.ToString("C");
                clearCode();
            }
            catch
            {

                MessageBox.Show("Enter Data");
            }
        }

        private void Txttitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            //this exits the program
            this.Close();
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            //this calls code to clear textboxes

        }
        //create function to clear textboxes
        private void clearCode()
        {
            txtprice.Text = "";
            txtquantity.Clear();
            txttitle.Clear();
        }

        private void Lbldiscountprice_Click(object sender, EventArgs e)
        {

        }

        private void Lbltotalpeople_Click(object sender, EventArgs e)
        {

        }
    }
}
