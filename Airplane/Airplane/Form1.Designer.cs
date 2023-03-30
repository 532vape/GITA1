namespace Airplane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picairplane = new System.Windows.Forms.PictureBox();
            this.pictarget = new System.Windows.Forms.PictureBox();
            this.piczeroleft = new System.Windows.Forms.PictureBox();
            this.piczeroright = new System.Windows.Forms.PictureBox();
            this.picarizonaleft = new System.Windows.Forms.PictureBox();
            this.picarizonaright = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prgtarget = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbltimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picairplane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piczeroleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piczeroright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picarizonaleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picarizonaright)).BeginInit();
            this.SuspendLayout();
            // 
            // picairplane
            // 
            this.picairplane.Image = ((System.Drawing.Image)(resources.GetObject("picairplane.Image")));
            this.picairplane.Location = new System.Drawing.Point(338, 87);
            this.picairplane.Name = "picairplane";
            this.picairplane.Size = new System.Drawing.Size(100, 50);
            this.picairplane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picairplane.TabIndex = 0;
            this.picairplane.TabStop = false;
            // 
            // pictarget
            // 
            this.pictarget.Image = ((System.Drawing.Image)(resources.GetObject("pictarget.Image")));
            this.pictarget.Location = new System.Drawing.Point(338, 347);
            this.pictarget.Name = "pictarget";
            this.pictarget.Size = new System.Drawing.Size(100, 50);
            this.pictarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictarget.TabIndex = 1;
            this.pictarget.TabStop = false;
            // 
            // piczeroleft
            // 
            this.piczeroleft.Image = ((System.Drawing.Image)(resources.GetObject("piczeroleft.Image")));
            this.piczeroleft.Location = new System.Drawing.Point(778, 12);
            this.piczeroleft.Name = "piczeroleft";
            this.piczeroleft.Size = new System.Drawing.Size(10, 10);
            this.piczeroleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piczeroleft.TabIndex = 2;
            this.piczeroleft.TabStop = false;
            this.piczeroleft.Visible = false;
            // 
            // piczeroright
            // 
            this.piczeroright.Image = ((System.Drawing.Image)(resources.GetObject("piczeroright.Image")));
            this.piczeroright.Location = new System.Drawing.Point(778, 12);
            this.piczeroright.Name = "piczeroright";
            this.piczeroright.Size = new System.Drawing.Size(10, 10);
            this.piczeroright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piczeroright.TabIndex = 3;
            this.piczeroright.TabStop = false;
            this.piczeroright.Visible = false;
            // 
            // picarizonaleft
            // 
            this.picarizonaleft.Image = ((System.Drawing.Image)(resources.GetObject("picarizonaleft.Image")));
            this.picarizonaleft.Location = new System.Drawing.Point(778, 12);
            this.picarizonaleft.Name = "picarizonaleft";
            this.picarizonaleft.Size = new System.Drawing.Size(10, 10);
            this.picarizonaleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picarizonaleft.TabIndex = 4;
            this.picarizonaleft.TabStop = false;
            this.picarizonaleft.Visible = false;
            // 
            // picarizonaright
            // 
            this.picarizonaright.Image = ((System.Drawing.Image)(resources.GetObject("picarizonaright.Image")));
            this.picarizonaright.Location = new System.Drawing.Point(778, 12);
            this.picarizonaright.Name = "picarizonaright";
            this.picarizonaright.Size = new System.Drawing.Size(10, 10);
            this.picarizonaright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picarizonaright.TabIndex = 5;
            this.picarizonaright.TabStop = false;
            this.picarizonaright.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prgtarget
            // 
            this.prgtarget.Location = new System.Drawing.Point(12, 12);
            this.prgtarget.Name = "prgtarget";
            this.prgtarget.Size = new System.Drawing.Size(195, 30);
            this.prgtarget.TabIndex = 6;
            this.prgtarget.Value = 100;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lbltimer
            // 
            this.lbltimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.Location = new System.Drawing.Point(706, 12);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(82, 69);
            this.lbltimer.TabIndex = 7;
            this.lbltimer.Text = "100";
            this.lbltimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.prgtarget);
            this.Controls.Add(this.picarizonaright);
            this.Controls.Add(this.picarizonaleft);
            this.Controls.Add(this.piczeroright);
            this.Controls.Add(this.piczeroleft);
            this.Controls.Add(this.pictarget);
            this.Controls.Add(this.picairplane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picairplane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piczeroleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piczeroright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picarizonaleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picarizonaright)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picairplane;
        private System.Windows.Forms.PictureBox pictarget;
        private System.Windows.Forms.PictureBox piczeroleft;
        private System.Windows.Forms.PictureBox piczeroright;
        private System.Windows.Forms.PictureBox picarizonaleft;
        private System.Windows.Forms.PictureBox picarizonaright;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar prgtarget;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbltimer;
    }
}

