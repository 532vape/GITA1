using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirePower
{
    public partial class Form1 : Form
    {
        // a list to hold bullets
        List<PictureBox> bulletlist = new List<PictureBox>();
        int bulletcount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //move the ship w/left and right arrows
            KeyEventArgs key = e;

            if (key.KeyValue == 37)
            {
                lblspaceship.Left -= 10;
            }

            else if (key.KeyValue == 39)
            {

                lblspaceship.Left += 10;
            }

            if (key.KeyValue == 32)
            {
                if (bulletcount < 10)
                {
                    bulletlist.Add(new PictureBox());
                    //place picbox on the form
                    this.Controls.Add(bulletlist.ElementAt(bulletcount));
                    bulletlist.ElementAt(bulletcount).Height = 10;
                    bulletlist.ElementAt(bulletcount).Width = 10;
                    bulletlist.ElementAt(bulletcount).Image = Image.FromFile("bulletbills.png", true);
                    bulletlist.ElementAt(bulletcount).SizeMode = PictureBoxSizeMode.StretchImage;
                    bulletlist.ElementAt(bulletcount).Left = lblspaceship.Left + lblspaceship.Width / 2;
                    bulletlist.ElementAt(bulletcount).Top = lblspaceship.Top - 10;
                    bulletcount++;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movebullets();
        }

        private void movebullets()
        {
            for (int i = 0; i < bulletlist.Count; i++)
            {
                bulletlist.ElementAt(i).Top -= 10;
            }

            for (int j = 0; j < bulletlist.Count; j++)
            {
                if (lbltarget.Bounds.IntersectsWith(bulletlist.ElementAt(j).Bounds))
                {
                    lbltarget.Width -= 10;
                }
            }

            //remove bullets from offstage
            for (int k = 0; k < bulletlist.Count; k++)
            {
                if (bulletlist.ElementAt(k).Top < 0)
                {
                    this.Controls.Remove(bulletlist.ElementAt(k));
                    bulletlist.Remove(bulletlist.ElementAt(k));
                    bulletcount--;

                    if (bulletcount <= 0)
                    {
                        bulletlist = new List<PictureBox>();
                        bulletcount = 0;
                        break;
                    }
                }
            }
        }
    }
}
    

