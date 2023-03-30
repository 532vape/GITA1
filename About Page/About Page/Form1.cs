using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace About_Page
{// About Page
 // David Lim
 // Period 5
 // 9-16-19
    public partial class title : Form
    {
        public title()
        {
            InitializeComponent();
        }

        private void Picboxlogo_Click(object sender, EventArgs e)
        {

        }

        private void Lblname_Click(object sender, EventArgs e)
        {

        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            //this btn exits the program
            this.Close();
        }

        private void Btntrademark_Click(object sender, EventArgs e)
        {
            //this makes the trademark symbol visible
            picboxtm.Visible = true;
        }

        private void Picboxtm_Click(object sender, EventArgs e)
        {

        }

        private void Btnlogo_Click(object sender, EventArgs e)
        {
            //this makes the logo visible
            picboxlogo.Visible = true;
        }

        private void Lblbackground_Click(object sender, EventArgs e)
        {
          
        }

       
        private void Btncolor_Click(object sender, EventArgs e)
        {
            //this enables color change
            colorDialog1.ShowDialog();
            btncolor.ForeColor = colorDialog1.Color;
            btnfont.ForeColor = colorDialog1.Color;
            lblmessagebackground.ForeColor = colorDialog1.Color;
            lblname.ForeColor = colorDialog1.Color;
            btnlogo.ForeColor = colorDialog1.Color;
            btntrademark.ForeColor = colorDialog1.Color;
            btnclear.ForeColor = colorDialog1.Color;
            btnexit.ForeColor = colorDialog1.Color;
            btnbackground.ForeColor = colorDialog1.Color;
            lblcaption.ForeColor = colorDialog1.Color;
            lblquestions.ForeColor = colorDialog1.Color;
            label7.ForeColor = colorDialog1.Color;
            label8.ForeColor = colorDialog1.Color;
            label9.ForeColor = colorDialog1.Color;
            lblcontact.ForeColor = colorDialog1.Color;
            lblemail.ForeColor = colorDialog1.Color;
            lblsupport.ForeColor = colorDialog1.Color;
            lblphone.ForeColor = colorDialog1.Color;
            btnreset.ForeColor = colorDialog1.Color;
        }

        private void Btnfont_Click(object sender, EventArgs e)
        {
            //this changes the font
            fontDialog1.ShowDialog();
            btncolor.Font = fontDialog1.Font;
            btnfont.Font = fontDialog1.Font;
            lblmessagebackground.Font = fontDialog1.Font;
            lblname.Font = fontDialog1.Font;
            btnlogo.Font = fontDialog1.Font;
            btntrademark.Font = fontDialog1.Font;
            btnclear.Font = fontDialog1.Font;
            btnexit.Font = fontDialog1.Font;
            btnbackground.Font = fontDialog1.Font;
            lblcaption.Font = fontDialog1.Font;
            lblquestions.Font = fontDialog1.Font;
            label7.Font = fontDialog1.Font;
            label8.Font = fontDialog1.Font;
            label9.Font = fontDialog1.Font;
            lblcontact.Font = fontDialog1.Font;
            lblemail.Font = fontDialog1.Font;
            lblsupport.Font = fontDialog1.Font;
            lblphone.Font = fontDialog1.Font;
            btnreset.Font = fontDialog1.Font;
        }

        private void Title_Load(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            picboxcall.Visible = false;
            picboxmail.Visible = true;
        }

        private void Picboxmail_Click(object sender, EventArgs e)
        {
            picboxcall.Visible = true;
            picboxmail.Visible = false;
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            //this clears all labels
            lblname.Text = "";
            btnbackground.Text = "";
            lblcaption.Text = "";
            lblquestions.Text = "";
            lblsupport.Text = "";
            lblcontact.Text = "";
            lblname.Text = "";
            lblmessagebackground.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            lblphone.Text = "";
            lblemail.Text = "";

        }

        private void Lblbackground_Click_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this resets all labels
            lblname.Text = "Patriot Security Help Page";
            lblcaption.Text = "Accessibility";
            lblsupport.Text = "Customer Support";
            btnbackground.Text = "Background";
            lblquestions.Text = "Commonly Asked Questions";
            lblcontact.Text = "Contact Info";
            lblmessagebackground.Text = "We are a security firm with clients across the United States. We offer armed and unarmed security services for all occasions. We offer a wide variety of services, from guard duty to armored vehicle escorts.";
            label7.Text = "- How much does it cost?";
            label8.Text = "- Is it legal?";
            label9.Text = "Where is this service availible?";
            lblemail.Text = "Email - patriotsec@gmail.com";
            lblphone.Text = "Phone - (876) 982-1202";
        }

        private void Lblphone_Click(object sender, EventArgs e)
        {

        }

        private void Btnbackground_Click(object sender, EventArgs e)
        {
            //this makes the background info visible
            lblmessagebackground.Visible = true;
        }

        private void Lblquestions_Click(object sender, EventArgs e)
        {

        }
    }
}
