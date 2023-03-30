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
//Period 5
//9-17-19
//this is a program that allows you to enter in information and output a complete mailing label

namespace Mailing_Label
{
    public partial class title : Form
    {
        public title()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Title_Load(object sender, EventArgs e)
        {

        }

        private void Lblmessage_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this changes the label to the content of the of the textboxes
            lblmessage.Text = txtfirstname.Text + ", " + txtlastname.Text + "\n" + txtstreet.Text + "\n" + txtcity.Text + ", " + txtstate.Text + "  " + txtzip.Text;
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            //this clears all textboxes and labels
            txtlastname.Text = " ";
            txtfirstname.Text = " ";
            txtstreet.Text = " ";
            txtcity.Text = " ";
            txtstate.Text = " ";
            txtzip.Text = " ";
            lblmessage.Text = "Label Appears Here";
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            //this exits the program
            this.Close();
        }

        private void Txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
