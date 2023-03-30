using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloworldp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this exits the program
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnpush_Click(object sender, EventArgs e)
        {
            //this change message in label
            lblmessage.Text = "FOR THE MOTHERLAND";
        }

        private void Btnpush2_Click(object sender, EventArgs e)
        {
            //changes message as well
            lblmessage.Text = "death to the facists";
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            //clears the label
            lblmessage.Text = "Into gulag with you comrade. За Родину";
        }
    }
}
