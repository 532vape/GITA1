using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    //David Lim
    //Period 5
    //October 1 2019
    //bmi calculator
     /*This project calculates your bmi and tells you how healthy you are
     * it converts your height in feet and inches to meters
     * it also converts your wiehgt in lb to kg
     * it also trakcs total people calculated and the average bmi
     */
    public partial class Form1 : Form
    {
        //these are global variables
        //they hold their contentes through the life of the program

        private decimal totalpeople;
        private decimal averagebmi;
        private decimal totalbmi;

        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Btncalculate_Click(object sender, EventArgs e)
        {

            //this calculates the BMI of a person and converts height and weight from imperial to metric
            //step 1: declare variables to declare variables

            decimal heightftdecimal;
            decimal heightindecimal;
            decimal weightlbdecimal;
            decimal heightinmetersdecimal;
            decimal weightkgdecimal;
            decimal bmidecimal;
            decimal heightimperialdecimal;
            decimal feettoinchesdecimal;
            decimal averagebmidecimal;


            //step 2: gets data from user and stores

            try

            {

                heightftdecimal = decimal.Parse(txtheightft.Text);
                heightindecimal = decimal.Parse(txtheightin.Text);
                weightlbdecimal = decimal.Parse(txtweightlbs.Text);

                //step 3: mathematical calculations

                weightkgdecimal = weightlbdecimal * (decimal)0.454;
                feettoinchesdecimal = heightftdecimal * 12;
                heightimperialdecimal = feettoinchesdecimal + heightindecimal;
                heightinmetersdecimal = heightimperialdecimal * (decimal)0.0254;
                bmidecimal = Math.Round(weightkgdecimal / (heightinmetersdecimal * heightinmetersdecimal),2);




                //manager calculations
                totalpeople += 1;
                totalbmi += bmidecimal;
                averagebmidecimal = totalbmi / totalpeople;


                //step 4: output final answers to the labels
                lblkgoutput.Text = weightkgdecimal.ToString();
                lblmoutput.Text = heightinmetersdecimal.ToString();
                lblbmioutput.Text = bmidecimal.ToString();

                lbltotalpeopleoutput.Text = totalpeople.ToString();
                lblaveragebmioutput.Text = averagebmidecimal.ToString();
                clearCode();

                //step 5: input image to display how healthy the person is

                if (bmidecimal >= 30)
                {
                    lblhealth.Visible = true;
                    lblobese.Visible = false;
                    lblveryobese.Visible = false;
                    lblunderweight.Visible = false;
                    lblnormal.Visible = false;
                    lblhealth.Visible = false;
                    lbloverweight.Visible = false;
                }

                if (bmidecimal < (decimal)18.5)
                {
                    lblhealth.Visible = false;
                    lblobese.Visible = false;
                    lblveryobese.Visible = false;
                    lblunderweight.Visible = true;
                    lblnormal.Visible = false;
                    lblhealth.Visible = false;
                    lbloverweight.Visible = false;
                }

                if (bmidecimal >= (decimal)18.5)
                {
                    lblhealth.Visible = false;
                    lblobese.Visible = false;
                    lblveryobese.Visible = false;
                    lblunderweight.Visible = false;
                    lblnormal.Visible = true;
                    lblhealth.Visible = false;
                    lbloverweight.Visible = false;
                }

                if (bmidecimal >= 25)
                {
                    lblhealth.Visible = false;
                    lblobese.Visible = false;
                    lblveryobese.Visible = false;
                    lblunderweight.Visible = false;
                    lblnormal.Visible = false;
                    lblhealth.Visible = false;
                    lbloverweight.Visible = true;
                }

                if (bmidecimal >= 30)
                {
                    lblhealth.Visible = false;
                    lblobese.Visible = true;
                    lblveryobese.Visible = false;
                    lblunderweight.Visible = false;
                    lblnormal.Visible = false;
                    lblhealth.Visible = false;
                    lbloverweight.Visible = false; ;
                }

                if (bmidecimal >= 35)
                {
                    lblhealth.Visible = false;
                    lblobese.Visible = false;
                    lblveryobese.Visible = true;
                    lblunderweight.Visible = false;
                    lblnormal.Visible = false;
                    lblhealth.Visible = false;
                    lbloverweight.Visible = false; ;
                }



                }
            catch
            {

                MessageBox.Show("Enter Data");

            }



            { 

            }
                

        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            //this calls code to clear textboxes
            //this clears the labels
            lblmoutput.Text = " ";
            lblkgoutput.Text = " ";
            lblbmioutput.Text = " ";
            lbltotalpeopleoutput.Text = " ";
            lblaveragebmioutput.Text = " ";
        }
        //create function to clear textboxes

        private void clearCode()
        {
            txtheightft.Text = "";
            txtheightin.Clear();
            txtweightlbs.Clear();
        }

        private void Picperson_Click(object sender, EventArgs e)
        {

        }

        private void Picbmichart_Click(object sender, EventArgs e)
        {

        }

        private void Lblhealth_Click(object sender, EventArgs e)
        {

        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            //this exits the program
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtheightft_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
