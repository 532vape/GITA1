using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airplane
{
    public partial class Form1 : Form
    {
        private int time = 100;
        List<PictureBox> bulletlist = new List<PictureBox>();
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        int bulletcount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventArgs key = e;

            if (key.KeyValue == 37)
            {
                pictarget.Left -= 10;
                pictarget.Image = picarizonaleft.Image;
                if (pictarget.Left <= 0)
                {
                    pictarget.Left = 0;
                }
            }

            else if (key.KeyValue == 39)
            {
                pictarget.Left += 10;
                pictarget.Image = picarizonaright.Image;

                if (pictarget.Left >= 525)
                {
                    pictarget.Left = 525;
                }
            }

            if (key.KeyValue == 32)
            {
               
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveenemy();
            
        }

        private void moveprojectile()
        {
            int bombdrop = r.Next(1, 21);

            if (bombdrop == 2 | bombdrop == 4 | bombdrop == 6 | bombdrop == 8 | bombdrop == 10 | bombdrop == 12 | bombdrop == 14 | bombdrop == 16 | bombdrop == 18 | bombdrop == 20)
            {
                if (bulletcount < 20)
                {
                    bulletlist.Add(new PictureBox());
                    //place picbox on the form
                    this.Controls.Add(bulletlist.ElementAt(bulletcount));
                    bulletlist.ElementAt(bulletcount).Height = 10;
                    bulletlist.ElementAt(bulletcount).Width = 10;
                    bulletlist.ElementAt(bulletcount).Image = Image.FromFile("bobm.jpg", true);
                    bulletlist.ElementAt(bulletcount).SizeMode = PictureBoxSizeMode.StretchImage;
                    bulletlist.ElementAt(bulletcount).Left = picairplane.Left + picairplane.Width / 2;
                    bulletlist.ElementAt(bulletcount).Top = picairplane.Bottom;
                    bulletcount++;
                }
            }

            for (int i = 0; i < bulletlist.Count; i++)
            {
                bulletlist.ElementAt(i).Top += 10;
            }

       
            for (int j = 0; j < bulletlist.Count; j++)
            {
                try
                {
                    if (pictarget.Bounds.IntersectsWith(bulletlist.ElementAt(j).Bounds))
                    {
                        prgtarget.Value -= 10;
                    }
                }
                catch
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    MessageBox.Show("Game Over!");
                }

            }
        

            for (int k = 0; k < bulletlist.Count; k++)
            {
                if (bulletlist.ElementAt(k).Top > 500)
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

        private void moveenemy()
        {
            int leftright = r.Next(1, 11);

            if (leftright == 2 | leftright == 4 | leftright == 6 | leftright == 8 | leftright == 10)
            {
                picairplane.Left -= 10;
            }

            else if (leftright == 1 | leftright == 3 | leftright == 5 | leftright == 7 | leftright == 9)
            {
                picairplane.Left += 10;
            }
        }

        private void timer()
        {
            time--;
            for (int i = 0; i < bulletlist.Count; i++)
            {
                for (int k = 0; k < bulletlist.Count; k++)
                {
                    lbltimer.Text = time.ToString();
                }

                if (time <= 0)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    MessageBox.Show("Game Over!");
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer();   
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            moveprojectile();
        }
    }
}
