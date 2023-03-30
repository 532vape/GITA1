using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Programmer
//date
//period
//project description

namespace Textbox
{
    public partial class Textboxes : Form
    {
        public Textboxes()
        {
            InitializeComponent();
        }

        private void Btnpush_Click(object sender, EventArgs e)
        {
            //this btn changes the message
            lblmessage.Text = txtname.Text + " loves football and " + "\n" + txtphrase.Text;
        }
    }
}
