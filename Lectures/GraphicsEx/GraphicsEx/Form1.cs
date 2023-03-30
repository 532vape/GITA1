using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //this exits the program
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this changes the text and the label
            lblMessage.Text = "happy friday";
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            //puts the original message back
            lblMessage.Text = "How to Do Graphics";
        }

        private void Pichappy_Click(object sender, EventArgs e)
        {
            picsad.Visible = true;
            pichappy.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Picsad_Click(object sender, EventArgs e)
        {
            //this makes sad face invisible
            picsad.Visible = false;
            pichappy.Visible = true;
        }

        private void Btnfont_Click(object sender, EventArgs e)
        {
            //this changes the font in the labels
            fontDialog1.ShowDialog();
            lblMessage.Font = fontDialog1.Font;
        }

        private void Btncolor_Click(object sender, EventArgs e)
        {
            //this changes the font color
            colorDialog1.ShowDialog();
            lblMessage.ForeColor = colorDialog1.Color;
        }
    }
}
