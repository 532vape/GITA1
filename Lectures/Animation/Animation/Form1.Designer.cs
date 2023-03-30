namespace Animation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblinvader = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblspaceship = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.lblbullet = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblinvader
            // 
            this.lblinvader.BackColor = System.Drawing.Color.Black;
            this.lblinvader.Location = new System.Drawing.Point(316, 90);
            this.lblinvader.Name = "lblinvader";
            this.lblinvader.Size = new System.Drawing.Size(100, 23);
            this.lblinvader.TabIndex = 0;
            this.lblinvader.Text = "label1";
            this.lblinvader.Click += new System.EventHandler(this.Lblinvader_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblspaceship
            // 
            this.lblspaceship.BackColor = System.Drawing.Color.Red;
            this.lblspaceship.Location = new System.Drawing.Point(316, 394);
            this.lblspaceship.Name = "lblspaceship";
            this.lblspaceship.Size = new System.Drawing.Size(100, 23);
            this.lblspaceship.TabIndex = 1;
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.Control;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(633, 48);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(100, 23);
            this.lbloutput.TabIndex = 2;
            // 
            // lblbullet
            // 
            this.lblbullet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblbullet.BackColor = System.Drawing.Color.Blue;
            this.lblbullet.Location = new System.Drawing.Point(361, 384);
            this.lblbullet.Name = "lblbullet";
            this.lblbullet.Size = new System.Drawing.Size(10, 10);
            this.lblbullet.TabIndex = 3;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblbullet);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblspaceship);
            this.Controls.Add(this.lblinvader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblinvader;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblspaceship;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lblbullet;
        private System.Windows.Forms.Timer timer2;
    }
}

