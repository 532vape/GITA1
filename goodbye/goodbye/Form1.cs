using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goodbye
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void Lblmessage_Click(object sender, EventArgs e)
        {
            picboxgreece.Visible = false;
            picboxgerman.Visible = false;
            picboxkorean.Visible = false;
            picboxrussian.Visible = false;
            picboxamerica.Visible = true;
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            //this button resets the message
            lblmessage.Text = "Goodbye";
            picboxgreece.Visible = false;
            picboxgerman.Visible = false;
            picboxkorean.Visible = false;
            picboxrussian.Visible = false;
            picboxamerica.Visible = true;
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            //this button exits the program
            this.Close(); 
        }

        private void Btnkorean_Click(object sender, EventArgs e)
        {
            //this changes the label to Korean
            lblmessage.Text = "안영하새요";
            picboxgreece.Visible = false;
            picboxgerman.Visible = false;
            picboxkorean.Visible = true;
            picboxrussian.Visible = false;
            picboxamerica.Visible = false;
        }

        private void Btngerman_Click(object sender, EventArgs e)
        {
            //this changes the label to German
            lblmessage.Text = "Auf Wiedersehen";
            picboxgreece.Visible = false;
            picboxgerman.Visible = true;
            picboxkorean.Visible = false;
            picboxrussian.Visible = false;
            picboxamerica.Visible = false;

        }

        private void Btngreek_Click(object sender, EventArgs e)
        {
            //this changes the label to Greek
            lblmessage.Text = "αντιο σας";
            picboxgreece.Visible = true;
            picboxgerman.Visible = false;
            picboxkorean.Visible = false;
            picboxrussian.Visible = false;
            picboxamerica.Visible = false;
        }

        private void Btnrussian_Click(object sender, EventArgs e)
        {
            //this changes the label to Russian
            lblmessage.Text = "Прощай";
            picboxgreece.Visible = false;
            picboxgerman.Visible = false;
            picboxkorean.Visible = false;
            picboxrussian.Visible = true;
            picboxamerica.Visible = false;
        }

        private void Picboxgerman_Click(object sender, EventArgs e)
        {

        }

        private void Picboxgreece_Click(object sender, EventArgs e)
        {

        }

        private void Picboxamerica_Click(object sender, EventArgs e)
        {

        }

        private void Picboxkorean_Click(object sender, EventArgs e)
        {

        }

        private void Title_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
