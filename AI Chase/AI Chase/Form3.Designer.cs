namespace AI_Chase
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.picMiG = new System.Windows.Forms.PictureBox();
            this.pictomcat = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picmissile = new System.Windows.Forms.PictureBox();
            this.picmigleft = new System.Windows.Forms.PictureBox();
            this.picmigup = new System.Windows.Forms.PictureBox();
            this.picmigright = new System.Windows.Forms.PictureBox();
            this.picmigdown = new System.Windows.Forms.PictureBox();
            this.picmissiledown = new System.Windows.Forms.PictureBox();
            this.picmissileup = new System.Windows.Forms.PictureBox();
            this.picmissileleft = new System.Windows.Forms.PictureBox();
            this.picmissileright = new System.Windows.Forms.PictureBox();
            this.picmissile2 = new System.Windows.Forms.PictureBox();
            this.pictomcatdown = new System.Windows.Forms.PictureBox();
            this.pictomcatup = new System.Windows.Forms.PictureBox();
            this.pictomcatleft = new System.Windows.Forms.PictureBox();
            this.pictomcatright = new System.Windows.Forms.PictureBox();
            this.pbartomcat = new System.Windows.Forms.ProgressBar();
            this.pbarMiG = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbltimer = new System.Windows.Forms.Label();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMiG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictomcat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmigleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmigup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmigright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmigdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissiledown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissileup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissileleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissileright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictomcatdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictomcatup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictomcatleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictomcatright)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picMiG
            // 
            this.picMiG.Image = ((System.Drawing.Image)(resources.GetObject("picMiG.Image")));
            this.picMiG.Location = new System.Drawing.Point(371, 357);
            this.picMiG.Name = "picMiG";
            this.picMiG.Size = new System.Drawing.Size(52, 106);
            this.picMiG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMiG.TabIndex = 0;
            this.picMiG.TabStop = false;
            // 
            // pictomcat
            // 
            this.pictomcat.BackColor = System.Drawing.Color.SteelBlue;
            this.pictomcat.Image = ((System.Drawing.Image)(resources.GetObject("pictomcat.Image")));
            this.pictomcat.Location = new System.Drawing.Point(371, 66);
            this.pictomcat.Name = "pictomcat";
            this.pictomcat.Size = new System.Drawing.Size(52, 106);
            this.pictomcat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictomcat.TabIndex = 1;
            this.pictomcat.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // picmissile
            // 
            this.picmissile.Enabled = false;
            this.picmissile.Image = ((System.Drawing.Image)(resources.GetObject("picmissile.Image")));
            this.picmissile.Location = new System.Drawing.Point(371, 357);
            this.picmissile.Name = "picmissile";
            this.picmissile.Size = new System.Drawing.Size(10, 40);
            this.picmissile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmissile.TabIndex = 3;
            this.picmissile.TabStop = false;
            this.picmissile.Visible = false;
            // 
            // picmigleft
            // 
            this.picmigleft.Image = ((System.Drawing.Image)(resources.GetObject("picmigleft.Image")));
            this.picmigleft.Location = new System.Drawing.Point(778, 11);
            this.picmigleft.Name = "picmigleft";
            this.picmigleft.Size = new System.Drawing.Size(10, 10);
            this.picmigleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmigleft.TabIndex = 4;
            this.picmigleft.TabStop = false;
            this.picmigleft.Visible = false;
            // 
            // picmigup
            // 
            this.picmigup.Image = ((System.Drawing.Image)(resources.GetObject("picmigup.Image")));
            this.picmigup.Location = new System.Drawing.Point(778, 11);
            this.picmigup.Name = "picmigup";
            this.picmigup.Size = new System.Drawing.Size(10, 10);
            this.picmigup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmigup.TabIndex = 5;
            this.picmigup.TabStop = false;
            this.picmigup.Visible = false;
            // 
            // picmigright
            // 
            this.picmigright.Image = ((System.Drawing.Image)(resources.GetObject("picmigright.Image")));
            this.picmigright.Location = new System.Drawing.Point(778, 11);
            this.picmigright.Name = "picmigright";
            this.picmigright.Size = new System.Drawing.Size(10, 10);
            this.picmigright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmigright.TabIndex = 6;
            this.picmigright.TabStop = false;
            this.picmigright.Visible = false;
            // 
            // picmigdown
            // 
            this.picmigdown.Image = ((System.Drawing.Image)(resources.GetObject("picmigdown.Image")));
            this.picmigdown.Location = new System.Drawing.Point(778, 11);
            this.picmigdown.Name = "picmigdown";
            this.picmigdown.Size = new System.Drawing.Size(10, 10);
            this.picmigdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmigdown.TabIndex = 7;
            this.picmigdown.TabStop = false;
            this.picmigdown.Visible = false;
            // 
            // picmissiledown
            // 
            this.picmissiledown.Image = ((System.Drawing.Image)(resources.GetObject("picmissiledown.Image")));
            this.picmissiledown.Location = new System.Drawing.Point(762, 11);
            this.picmissiledown.Name = "picmissiledown";
            this.picmissiledown.Size = new System.Drawing.Size(10, 10);
            this.picmissiledown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmissiledown.TabIndex = 9;
            this.picmissiledown.TabStop = false;
            this.picmissiledown.Visible = false;
            // 
            // picmissileup
            // 
            this.picmissileup.Image = ((System.Drawing.Image)(resources.GetObject("picmissileup.Image")));
            this.picmissileup.Location = new System.Drawing.Point(762, 11);
            this.picmissileup.Name = "picmissileup";
            this.picmissileup.Size = new System.Drawing.Size(10, 10);
            this.picmissileup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmissileup.TabIndex = 10;
            this.picmissileup.TabStop = false;
            this.picmissileup.Visible = false;
            // 
            // picmissileleft
            // 
            this.picmissileleft.Image = ((System.Drawing.Image)(resources.GetObject("picmissileleft.Image")));
            this.picmissileleft.Location = new System.Drawing.Point(762, 11);
            this.picmissileleft.Name = "picmissileleft";
            this.picmissileleft.Size = new System.Drawing.Size(10, 10);
            this.picmissileleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmissileleft.TabIndex = 11;
            this.picmissileleft.TabStop = false;
            this.picmissileleft.Visible = false;
            // 
            // picmissileright
            // 
            this.picmissileright.Image = ((System.Drawing.Image)(resources.GetObject("picmissileright.Image")));
            this.picmissileright.Location = new System.Drawing.Point(762, 11);
            this.picmissileright.Name = "picmissileright";
            this.picmissileright.Size = new System.Drawing.Size(10, 10);
            this.picmissileright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmissileright.TabIndex = 12;
            this.picmissileright.TabStop = false;
            this.picmissileright.Visible = false;
            // 
            // picmissile2
            // 
            this.picmissile2.Enabled = false;
            this.picmissile2.Image = ((System.Drawing.Image)(resources.GetObject("picmissile2.Image")));
            this.picmissile2.Location = new System.Drawing.Point(413, 357);
            this.picmissile2.Name = "picmissile2";
            this.picmissile2.Size = new System.Drawing.Size(10, 40);
            this.picmissile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmissile2.TabIndex = 8;
            this.picmissile2.TabStop = false;
            this.picmissile2.Visible = false;
            // 
            // pictomcatdown
            // 
            this.pictomcatdown.BackColor = System.Drawing.SystemColors.Control;
            this.pictomcatdown.Image = ((System.Drawing.Image)(resources.GetObject("pictomcatdown.Image")));
            this.pictomcatdown.Location = new System.Drawing.Point(746, 11);
            this.pictomcatdown.Name = "pictomcatdown";
            this.pictomcatdown.Size = new System.Drawing.Size(10, 10);
            this.pictomcatdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictomcatdown.TabIndex = 13;
            this.pictomcatdown.TabStop = false;
            this.pictomcatdown.Visible = false;
            // 
            // pictomcatup
            // 
            this.pictomcatup.BackColor = System.Drawing.SystemColors.Control;
            this.pictomcatup.Image = ((System.Drawing.Image)(resources.GetObject("pictomcatup.Image")));
            this.pictomcatup.Location = new System.Drawing.Point(746, 11);
            this.pictomcatup.Name = "pictomcatup";
            this.pictomcatup.Size = new System.Drawing.Size(10, 10);
            this.pictomcatup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictomcatup.TabIndex = 14;
            this.pictomcatup.TabStop = false;
            this.pictomcatup.Visible = false;
            // 
            // pictomcatleft
            // 
            this.pictomcatleft.BackColor = System.Drawing.SystemColors.Control;
            this.pictomcatleft.Image = ((System.Drawing.Image)(resources.GetObject("pictomcatleft.Image")));
            this.pictomcatleft.Location = new System.Drawing.Point(746, 11);
            this.pictomcatleft.Name = "pictomcatleft";
            this.pictomcatleft.Size = new System.Drawing.Size(10, 10);
            this.pictomcatleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictomcatleft.TabIndex = 15;
            this.pictomcatleft.TabStop = false;
            this.pictomcatleft.Visible = false;
            this.pictomcatleft.Click += new System.EventHandler(this.Pictomcatleft_Click);
            // 
            // pictomcatright
            // 
            this.pictomcatright.BackColor = System.Drawing.SystemColors.Control;
            this.pictomcatright.Image = ((System.Drawing.Image)(resources.GetObject("pictomcatright.Image")));
            this.pictomcatright.Location = new System.Drawing.Point(746, 11);
            this.pictomcatright.Name = "pictomcatright";
            this.pictomcatright.Size = new System.Drawing.Size(10, 10);
            this.pictomcatright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictomcatright.TabIndex = 16;
            this.pictomcatright.TabStop = false;
            this.pictomcatright.Visible = false;
            this.pictomcatright.Click += new System.EventHandler(this.Pictomcatright_Click);
            // 
            // pbartomcat
            // 
            this.pbartomcat.ForeColor = System.Drawing.Color.Red;
            this.pbartomcat.Location = new System.Drawing.Point(688, 443);
            this.pbartomcat.Name = "pbartomcat";
            this.pbartomcat.Size = new System.Drawing.Size(100, 23);
            this.pbartomcat.TabIndex = 17;
            this.pbartomcat.Value = 100;
            this.pbartomcat.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // pbarMiG
            // 
            this.pbarMiG.ForeColor = System.Drawing.Color.Red;
            this.pbarMiG.Location = new System.Drawing.Point(12, 443);
            this.pbarMiG.Name = "pbarMiG";
            this.pbarMiG.Size = new System.Drawing.Size(100, 23);
            this.pbarMiG.TabIndex = 18;
            this.pbarMiG.Value = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // lbltimer
            // 
            this.lbltimer.BackColor = System.Drawing.SystemColors.Control;
            this.lbltimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltimer.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.Location = new System.Drawing.Point(688, 0);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(112, 28);
            this.lbltimer.TabIndex = 20;
            this.lbltimer.Text = "60";
            this.lbltimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(360, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.pbarMiG);
            this.Controls.Add(this.pbartomcat);
            this.Controls.Add(this.pictomcatright);
            this.Controls.Add(this.pictomcatleft);
            this.Controls.Add(this.pictomcatup);
            this.Controls.Add(this.pictomcatdown);
            this.Controls.Add(this.picmissileright);
            this.Controls.Add(this.picmissileleft);
            this.Controls.Add(this.picmissileup);
            this.Controls.Add(this.picmissiledown);
            this.Controls.Add(this.picmissile2);
            this.Controls.Add(this.picmigdown);
            this.Controls.Add(this.picmigright);
            this.Controls.Add(this.picmigup);
            this.Controls.Add(this.picmigleft);
            this.Controls.Add(this.picmissile);
            this.Controls.Add(this.pictomcat);
            this.Controls.Add(this.picMiG);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "USSR";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMiG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictomcat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmigleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmigup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmigright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmigdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissiledown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissileup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissileleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissileright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmissile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictomcatdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictomcatup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictomcatleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictomcatright)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMiG;
        private System.Windows.Forms.PictureBox pictomcat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox picmissile;
        private System.Windows.Forms.PictureBox picmigleft;
        private System.Windows.Forms.PictureBox picmigup;
        private System.Windows.Forms.PictureBox picmigright;
        private System.Windows.Forms.PictureBox picmigdown;
        private System.Windows.Forms.PictureBox picmissiledown;
        private System.Windows.Forms.PictureBox picmissileup;
        private System.Windows.Forms.PictureBox picmissileleft;
        private System.Windows.Forms.PictureBox picmissileright;
        private System.Windows.Forms.PictureBox picmissile2;
        private System.Windows.Forms.PictureBox pictomcatdown;
        private System.Windows.Forms.PictureBox pictomcatup;
        private System.Windows.Forms.PictureBox pictomcatleft;
        private System.Windows.Forms.PictureBox pictomcatright;
        private System.Windows.Forms.ProgressBar pbartomcat;
        private System.Windows.Forms.ProgressBar pbarMiG;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}