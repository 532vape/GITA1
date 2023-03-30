using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Histogram
{
    public partial class Form1 : Form
    {
        /*David Lim
         * Period 5
         * 3/5/20
         * This program randomly generates a series of test scores and sorts them into grade categories using a string array
         */
        string[] testarray;
        int[] tests;
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnoutput_Click(object sender, EventArgs e)
        {
            int howmany = 100;
            testarray = new string[] { "A", "B", "C", "D", "F", "Output" };
            tests = new int[howmany];
            int turn = 0;

            for (int m = 0; m < testarray.Length; m++)
            {

                for (int i = 0; i < testarray.Length; i++)
                {
                    int testscore = r.Next(0, 101);
                    tests[i] = testscore;
                }

                for (int i = 0; i < testarray.Length; i ++)
                {
                    turn++;
                    if (tests[i] <= 59)
                    {
                        testarray[4] += "*";
                    }

                    if (tests[i] <= 69 && tests[i] >= 60)
                    {
                        testarray[3] += "*";
                    }

                    if (tests[i] <= 79 && tests[i] >= 70)
                    {
                        testarray[2] += "*";
                    }

                    if (tests[i] <= 89 && tests[i] >= 80)
                    {
                        testarray[1] += "*";
                    }

                    if (tests[i] <= 100 && tests[i] >= 90)
                    {
                        testarray[0] += "*";
                    }

                    if (turn > 100)
                    {
                        break;
                    }
                }

                testarray[5] = testarray[0] + "\n" + testarray[1] + "\n" + testarray[2] + "\n" + testarray[3] + "\n" + testarray[4];
                lbloutput.Text = testarray[5].ToString();
                
            }
                        

        }
    }
}
