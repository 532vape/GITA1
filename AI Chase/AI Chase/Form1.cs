using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AI_Chase
{
    //David Lim
    //Period 5
    //1/28/2020
    /*this is a game where you control a plane and fly it around, trying to avoid the enemy for a minute or lowering its health bar
     * you can choose sides between the us and ussr
     */
    public partial class Form1 : Form
    {
        Thread close;
        public Form1()
        {
            InitializeComponent();
        }

        private void Picus_Click(object sender, EventArgs e)
        {
            this.Close();
            close = new Thread(closeform1us);
            close.SetApartmentState(ApartmentState.STA);
            close.Start();
        }

        private void Picrussia_Click(object sender, EventArgs e)
        {
            this.Close();
            close = new Thread(closeformussr);
            close.SetApartmentState(ApartmentState.STA);
            close.Start();
        }

        private void closeform1us()
        {
            Application.Run(new Form2());
        }

        private void closeformussr()
        {
            Application.Run(new Form3());
        }
    }
}
