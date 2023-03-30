using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lbloutput_Click(object sender, EventArgs e)
        {
           
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            //add item to the list
            cboveggies.Items.Insert(0, cboveggies.Text);
            cboveggies.Text = "";
        }

        private void Btnremove_Click(object sender, EventArgs e)
        {
            //remove item from list
            cboveggies.Items.Remove(cboveggies.SelectedItem);
        }

        private void Btnindex_Click(object sender, EventArgs e)
        {
            //shows where item is in th elist
            lbloutput.Text = cboveggies.SelectedIndex.ToString();
        }

        private void Btncount_Click(object sender, EventArgs e)
        {
            //tells how many items in the list
            lbloutput.Text = cboveggies.Items.Count.ToString();
        }

        private void Btnabout_Click(object sender, EventArgs e)
        {
            frmabout openAbout = new frmabout();
            openAbout.ShowDialog();
        }

        private void Cboveggies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //output selected item to label
            lbloutput.Text = cboveggies.Items[cboveggies.SelectedIndex].ToString();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //this closes the program
            this.Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this opens the about apge
            frmabout openabout = new frmabout();
            openabout.ShowDialog();
        }
    }
}
