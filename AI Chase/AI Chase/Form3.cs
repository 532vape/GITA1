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
    public partial class Form3 : Form
    {
        Thread close;
        private int time = 60;
        private int direction = 3;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            //lblkeyvalue.Text = e.KeyValue.ToString();
            int whickey = e.KeyValue;

            //left arrow
            if (whickey == 37)
            {
                picMiG.Size = new Size(106, 52);
                picMiG.Image = picmigleft.Image;
                picMiG.Left -= 10;

                if (timer2.Enabled == false)
                {
                    picmissile.Size = new Size(40, 10);
                    picmissile2.Size = new Size(40, 10);
                    picmissile2.Image = picmissileleft.Image;
                    picmissile.Image = picmissileleft.Image;

                    picmissile.Top = picMiG.Top + 42;
                    picmissile.Left = picMiG.Left;
                    picmissile2.Left = picMiG.Left;
                    picmissile2.Top = picMiG.Top;
                    direction = 1;
                }

            }

            //right arrow
            if (whickey == 39)
            {
                picMiG.Size = new Size(106, 52);
                picMiG.Image = picmigright.Image;
                picMiG.Left += 10;

                if (timer2.Enabled == false)
                {
                    picmissile.Size = new Size(40, 10);
                    picmissile2.Size = new Size(40, 10);


                    picmissile.Image = picmissileright.Image;
                    picmissile2.Image = picmissileright.Image;


                    picmissile.Left = picMiG.Left + 66;
                    picmissile.Top = picMiG.Top;
                    picmissile2.Left = picMiG.Left + 66;
                    picmissile2.Top = picMiG.Top + 42;
                    direction = 2;
                }
            }

            //up arrow
            if (whickey == 38)
            {
                picMiG.Size = new Size(52, 106);
                picMiG.Image = picmigup.Image;
                picMiG.Top -= 10;



                if (timer2.Enabled == false)
                {
                    picmissile.Size = new Size(10, 40);
                    picmissile2.Size = new Size(10, 40);

                    picmissile.Image = picmissileup.Image;
                    picmissile2.Image = picmissileup.Image;


                    picmissile.Top = picMiG.Top;
                    picmissile.Left = picMiG.Left;
                    picmissile2.Top = picMiG.Top;
                    picmissile2.Left = picMiG.Right - 10;
                    direction = 3;
                }
            }

            //down arrow
            if (whickey == 40)
            {
                picMiG.Size = new Size(52, 106);
                picMiG.Image = picmigdown.Image;
                picMiG.Top += 10;



                if (timer2.Enabled == false)
                {
                    picmissile.Size = new Size(10, 40);
                    picmissile2.Size = new Size(10, 40);

                    picmissile.Image = picmissiledown.Image;
                    picmissile2.Image = picmissiledown.Image;

                    picmissile.Top = picMiG.Top + 66;
                    picmissile.Left = picMiG.Right - 10;
                    picmissile2.Left = picMiG.Left;
                    picmissile2.Top = picMiG.Top + 66;
                    direction = 4;
                }
            }

            //spacebar
            if (whickey == 32)
            {
                picmissile.Enabled = true;
                picmissile2.Enabled = true;
                timer2.Enabled = true;
                picmissile.Visible = true;
                picmissile2.Visible = true;

                if (direction == 3)
                {
                    picmissile.Top -= 10;
                    picmissile2.Top -= 10;
                }
            }

            if (picMiG.Left > 500)
            {
                picMiG.Left = 500;
            }

            if (picMiG.Left < 0)
            {
                picMiG.Left = 0;
            }

            if (picMiG.Top < 25)
            {
                picMiG.Top = 25;
            }

            if (picMiG.Top > 285)
            {
                picMiG.Top = 285;
            }

        }

        private void movemissile()
        {
            //code for the missile to return after it goes out of bounds
            if (picmissile.Top < 25 || picmissile.Top > 350 || picmissile.Left < 0 || picmissile.Left > 500)
            {
                if (direction == 1)
                {
                    timer2.Enabled = false;
                    picmissile.Top = picMiG.Top + 42;
                    picmissile.Left = picMiG.Left;
                    picmissile2.Left = picMiG.Left;
                    picmissile2.Top = picMiG.Top;
                    picmissile.Visible = false;
                    picmissile2.Visible = false;
                    picmissile.Enabled = false;
                    picmissile2.Enabled = false;
                }

                if (direction == 2)
                {
                    timer2.Enabled = false;
                    picmissile.Left = picMiG.Left + 66;
                    picmissile.Top = picMiG.Top;
                    picmissile2.Left = picMiG.Left + 66;
                    picmissile2.Top = picMiG.Top + 42;
                    picmissile.Visible = false;
                    picmissile2.Visible = false;
                    picmissile.Enabled = false;
                    picmissile2.Enabled = false;
                }

                if (direction == 3)
                {
                    timer2.Enabled = false;
                    picmissile.Top = picMiG.Top;
                    picmissile.Left = picMiG.Left;
                    picmissile2.Top = picMiG.Top;
                    picmissile2.Left = picMiG.Right - 10;
                    picmissile.Visible = false;
                    picmissile2.Visible = false;
                    picmissile.Enabled = false;
                    picmissile2.Enabled = false;
                }

                if (direction == 4)
                {
                    timer2.Enabled = false;
                    picmissile.Top = picMiG.Top + 66;
                    picmissile.Left = picMiG.Right - 10;
                    picmissile2.Left = picMiG.Left;
                    picmissile2.Top = picMiG.Top + 66;
                    picmissile.Visible = false;
                    picmissile2.Visible = false;
                    picmissile.Enabled = false;
                    picmissile2.Enabled = false;
                }
            }

            if (direction == 1)
            {
                picmissile.Left -= 10;
                picmissile2.Left -= 10;
            }

            if (direction == 2)
            {
                picmissile.Left += 10;
                picmissile2.Left += 10;
            }

            if (direction == 3)
            {
                picmissile.Top -= 10;
                picmissile2.Top -= 10;
            }

            if (direction == 4)
            {
                picmissile.Top += 10;
                picmissile2.Top += 10;
            }



        }


        private void moveopponent()
        {
            //code to track the player's movements
            if (picMiG.Left + 106 > pictomcat.Left + 106 || picMiG.Left + 52 > pictomcat.Left + 52)
            {
                pictomcat.Image = pictomcatright.Image;
                pictomcat.Left += 10;
                pictomcat.Size = new Size(106, 52);

            }

            else if (picMiG.Left < pictomcat.Left)
            {
                pictomcat.Image = pictomcatleft.Image;
                pictomcat.Left -= 10;
                pictomcat.Size = new Size(106, 52);

            }

            else if (picMiG.Top < pictomcat.Top)
            {
                pictomcat.Image = pictomcatup.Image;
                pictomcat.Top -= 10;
                pictomcat.Size = new Size(52, 106);

            }

            else if (picMiG.Top + 106 > pictomcat.Top + 106 || picMiG.Top + 52 > pictomcat.Top + 52)
            {
                pictomcat.Image = pictomcatdown.Image;
                pictomcat.Top += 10;
                pictomcat.Size = new Size(52, 106);
            }


            //hit code for the opponenet
            if (direction == 1 && picmissile.Left < pictomcat.Left + 106 && picmissile.Left > pictomcat.Left - 106)
            {
                if (picmissile.Enabled == true)
                {
                    pbartomcat.Value -= 5;
                    if (direction == 1)
                    {
                        timer2.Enabled = false;
                        picmissile.Top = picMiG.Top + 42;
                        picmissile.Left = picMiG.Left;
                        picmissile2.Left = picMiG.Left;
                        picmissile2.Top = picMiG.Top;
                        picmissile.Visible = false;
                        picmissile2.Visible = false;
                        picmissile.Enabled = false;
                        picmissile2.Enabled = false;
                    }

                    if (direction == 2)
                    {
                        timer2.Enabled = false;
                        picmissile.Left = picMiG.Left + 66;
                        picmissile.Top = picMiG.Top;
                        picmissile2.Left = picMiG.Left + 66;
                        picmissile2.Top = picMiG.Top + 42;
                        picmissile.Visible = false;
                        picmissile2.Visible = false;
                        picmissile.Enabled = false;
                        picmissile2.Enabled = false;
                    }

                    if (direction == 3)
                    {
                        timer2.Enabled = false;
                        picmissile.Top = picMiG.Top;
                        picmissile.Left = picMiG.Left;
                        picmissile2.Top = picMiG.Top;
                        picmissile2.Left = picMiG.Right - 10;
                        picmissile.Visible = false;
                        picmissile2.Visible = false;
                        picmissile.Enabled = false;
                        picmissile2.Enabled = false;
                    }

                    if (direction == 4)
                    {
                        timer2.Enabled = false;
                        picmissile.Top = picMiG.Top + 66;
                        picmissile.Left = picMiG.Right - 10;
                        picmissile2.Left = picMiG.Left;
                        picmissile2.Top = picMiG.Top + 66;
                        picmissile.Visible = false;
                        picmissile2.Visible = false;
                        picmissile.Enabled = false;
                        picmissile2.Enabled = false;
                    }
                    if (pbartomcat.Value == 0)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        picmissile2.Enabled = false;
                        picmissile.Enabled = false;
                        MessageBox.Show("Game Over!");
                        this.Close();
                        close = new Thread(openform1);
                        close.SetApartmentState(ApartmentState.STA);
                        close.Start();
                    }
                }

            }

            if (direction == 2 && picmissile.Right < pictomcat.Right + 106 && picmissile.Right > pictomcat.Right - 106)
            {
                if (picmissile.Enabled == true)
                {
                    if (direction == 1)
                    {
                        timer2.Enabled = false;
                        picmissile.Top = picMiG.Top + 42;
                        picmissile.Left = picMiG.Left;
                        picmissile2.Left = picMiG.Left;
                        picmissile2.Top = picMiG.Top;
                        picmissile.Visible = false;
                        picmissile2.Visible = false;
                        picmissile.Enabled = false;
                        picmissile2.Enabled = false;
                    }

                    if (direction == 2)
                    {
                        timer2.Enabled = false;
                        picmissile.Left = picMiG.Left + 66;
                        picmissile.Top = picMiG.Top;
                        picmissile2.Left = picMiG.Left + 66;
                        picmissile2.Top = picMiG.Top + 42;
                        picmissile.Visible = false;
                        picmissile2.Visible = false;
                        picmissile.Enabled = false;
                        picmissile2.Enabled = false;
                    }

                    if (direction == 3)
                    {
                        timer2.Enabled = false;
                        picmissile.Top = picMiG.Top;
                        picmissile.Left = picMiG.Left;
                        picmissile2.Top = picMiG.Top;
                        picmissile2.Left = picMiG.Right - 10;
                        picmissile.Visible = false;
                        picmissile2.Visible = false;
                        picmissile.Enabled = false;
                        picmissile2.Enabled = false;
                    }

                    if (direction == 4)
                    {
                        timer2.Enabled = false;
                        picmissile.Top = picMiG.Top + 66;
                        picmissile.Left = picMiG.Right - 10;
                        picmissile2.Left = picMiG.Left;
                        picmissile2.Top = picMiG.Top + 66;
                        picmissile.Visible = false;
                        picmissile2.Visible = false;
                        picmissile.Enabled = false;
                        picmissile2.Enabled = false;
                    }
                    pbartomcat.Value -= 5;
                    if (pbartomcat.Value == 0)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        picmissile2.Enabled = false;
                        picmissile.Enabled = false;
                        MessageBox.Show("Game Over!");
                        this.Close();
                        close = new Thread(openform1);
                        close.SetApartmentState(ApartmentState.STA);
                        close.Start();
                    }
                }
            }

            if (direction == 3 && picmissile.Top < pictomcat.Top + 52 && picmissile.Top > pictomcat.Top - 52)
            {
                if (picmissile.Enabled == true)
                {
                    if (direction == 1)
                    {
                        timer2.Enabled = false;
                        picmissile.Top = picMiG.Top + 42;
                        picmissile.Left = picMiG.Left;
                        picmissile2.Left = picMiG.Left;
                        picmissile2.Top = picMiG.Top;
                        picmissile.Visible = false;
                        picmissile2.Visible = false;
                        picmissile.Enabled = false;
                        picmissile2.Enabled = false;
                    }

                    if (direction == 2)
                    {
                        timer2.Enabled = false;
                        picmissile.Left = picMiG.Left + 66;
                        picmissile.Top = picMiG.Top;
                        picmissile2.Left = picMiG.Left + 66;
                        picmissile2.Top = picMiG.Top + 42;
                        picmissile.Visible = false;
                        picmissile2.Visible = false;
                        picmissile.Enabled = false;
                        picmissile2.Enabled = false;
                    }

                    if (direction == 3)
                    {
                        timer2.Enabled = false;
                        picmissile.Top = picMiG.Top;
                        picmissile.Left = picMiG.Left;
                        picmissile2.Top = picMiG.Top;
                        picmissile2.Left = picMiG.Right - 10;
                        picmissile.Visible = false;
                        picmissile2.Visible = false;
                        picmissile.Enabled = false;
                        picmissile2.Enabled = false;
                    }

                    if (direction == 4)
                    {
                        timer2.Enabled = false;
                        picmissile.Top = picMiG.Top + 66;
                        picmissile.Left = picMiG.Right - 10;
                        picmissile2.Left = picMiG.Left;
                        picmissile2.Top = picMiG.Top + 66;
                        picmissile.Visible = false;
                        picmissile2.Visible = false;
                        picmissile.Enabled = false;
                        picmissile2.Enabled = false;
                    }
                    pbartomcat.Value -= 5;
                    if (pbartomcat.Value == 0)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        picmissile2.Enabled = false;
                        picmissile.Enabled = false;
                        MessageBox.Show("Game Over!");
                        this.Close();
                        close = new Thread(openform1);
                        close.SetApartmentState(ApartmentState.STA);
                        close.Start();
                    }
                }
            }

            if (direction == 4 && picmissile.Bottom < pictomcat.Bottom + 52 && picmissile.Bottom > pictomcat.Bottom - 52)
            {
                if (picmissile.Enabled == true)
                {
                    pbartomcat.Value -= 5;
                    if (pbartomcat.Value == 0)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        picmissile2.Enabled = false;
                        picmissile.Enabled = false;
                        MessageBox.Show("Game Over!");
                        this.Close();
                        close = new Thread(openform1);
                        close.SetApartmentState(ApartmentState.STA);
                        close.Start();
                    }
                }
            }

            //drains your health if you get covered by the enemy
            if (pictomcat.Left < picMiG.Left + 106 && pictomcat.Left > picMiG.Right - 106 &&
                pictomcat.Right < picMiG.Right + 106 && pictomcat.Right > picMiG.Right - 106 &&
                pictomcat.Top < picMiG.Top + 52 && pictomcat.Top > picMiG.Top - 52 &&
                pictomcat.Bottom < picMiG.Bottom + 52 && pictomcat.Bottom > picMiG.Bottom - 52)
            {
                pbarMiG.Value -= 5;
                if (direction == 1)
                {
                    timer2.Enabled = false;
                    picmissile.Top = picMiG.Top + 42;
                    picmissile.Left = picMiG.Left;
                    picmissile2.Left = picMiG.Left;
                    picmissile2.Top = picMiG.Top;
                    picmissile.Visible = false;
                    picmissile2.Visible = false;
                    picmissile.Enabled = false;
                    picmissile2.Enabled = false;
                }

                if (direction == 2)
                {
                    timer2.Enabled = false;
                    picmissile.Left = picMiG.Left + 66;
                    picmissile.Top = picMiG.Top;
                    picmissile2.Left = picMiG.Left + 66;
                    picmissile2.Top = picMiG.Top + 42;
                    picmissile.Visible = false;
                    picmissile2.Visible = false;
                    picmissile.Enabled = false;
                    picmissile2.Enabled = false;
                }

                if (direction == 3)
                {
                    timer2.Enabled = false;
                    picmissile.Top = picMiG.Top;
                    picmissile.Left = picMiG.Left;
                    picmissile2.Top = picMiG.Top;
                    picmissile2.Left = picMiG.Right - 10;
                    picmissile.Visible = false;
                    picmissile2.Visible = false;
                    picmissile.Enabled = false;
                    picmissile2.Enabled = false;
                }

                if (direction == 4)
                {
                    timer2.Enabled = false;
                    picmissile.Top = picMiG.Top + 66;
                    picmissile.Left = picMiG.Right - 10;
                    picmissile2.Left = picMiG.Left;
                    picmissile2.Top = picMiG.Top + 66;
                    picmissile.Visible = false;
                    picmissile2.Visible = false;
                    picmissile.Enabled = false;
                    picmissile2.Enabled = false;
                }
                if (pbarMiG.Value == 0)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    picmissile2.Enabled = false;
                    picmissile.Enabled = false;
                    MessageBox.Show("Game Over!");
                    this.Close();
                    close = new Thread(openform1);
                    close.SetApartmentState(ApartmentState.STA);
                    close.Start();
                }
            }
        }

        private void timer()
        {
            //countdown until you win by default
            time -= 1;

            lbltimer.Text = time.ToString();
            timer1.Start();
            if (time == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                picmissile2.Enabled = false;
                picmissile.Enabled = false;
                MessageBox.Show("Game Over!");
                this.Close();
                close = new Thread(openform1);
                close.SetApartmentState(ApartmentState.STA);
                close.Start();
            }
        
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            movemissile();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            moveopponent();
        }

        private void openform1()
        {
            Application.Run(new Form1());
        }
        private void Pictomcatright_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            timer();
        }

        private void Pictomcatleft_Click(object sender, EventArgs e)
        {

        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //allows you to exit the game and switch sides
            this.Close();
            close = new Thread(openform1);
            close.SetApartmentState(ApartmentState.STA);
            close.Start();
        }
    }
}
