using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnok_Click(object sender, EventArgs e)
        {
            //this determines client services
            int servicecount = 0;
            String messagesString = "";
            //how to do check boxes

            if (chkshampoo.Checked)

            {
                servicecount += 1;
            }
            if (chkgrooming.Checked)

            {
                servicecount += 1;
            }
            if (chkshots.Checked)

            {
                servicecount += 1;
            }

            //how to do radio buttons

            if (raddog.Checked)
            {
                messagesString = "Dog Selected";
            }

            else if (radcat.Checked)
            {
                messagesString = "Cat Selected";
            }

            else
            {
                messagesString = "Other Selected";
            }

            messagesString += "\n" +
                "Number of Service: " +
                servicecount;

            MessageBox.Show(messagesString,
                "RSVP",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            if (servicecount > 2)
            {
                MessageBox.Show("Pay Day",
                    "Yaa Dog",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
               
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this puts the happy image into the blank picture box
            picblank.Image = pichappy.Image;
        }

        private void Btnsad_Click(object sender, EventArgs e)
        {
            //this puts the sad image into the blank picture box
            picblank.Image = picsad.Image;

            this.Text = Math.Round((decimal)1 / 3,2) + "";
        }
    }
}
