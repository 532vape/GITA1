namespace STarfield
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
            this.lblstar0 = new System.Windows.Forms.Label();
            this.lblstar1 = new System.Windows.Forms.Label();
            this.lblstar2 = new System.Windows.Forms.Label();
            this.lblstar3 = new System.Windows.Forms.Label();
            this.lblstar4 = new System.Windows.Forms.Label();
            this.lblstar5 = new System.Windows.Forms.Label();
            this.lblstar6 = new System.Windows.Forms.Label();
            this.lblstar7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblstar0
            // 
            this.lblstar0.BackColor = System.Drawing.Color.White;
            this.lblstar0.Location = new System.Drawing.Point(254, 120);
            this.lblstar0.Name = "lblstar0";
            this.lblstar0.Size = new System.Drawing.Size(100, 23);
            this.lblstar0.TabIndex = 0;
            // 
            // lblstar1
            // 
            this.lblstar1.BackColor = System.Drawing.Color.White;
            this.lblstar1.Location = new System.Drawing.Point(360, 120);
            this.lblstar1.Name = "lblstar1";
            this.lblstar1.Size = new System.Drawing.Size(100, 23);
            this.lblstar1.TabIndex = 1;
            // 
            // lblstar2
            // 
            this.lblstar2.BackColor = System.Drawing.Color.White;
            this.lblstar2.Location = new System.Drawing.Point(466, 120);
            this.lblstar2.Name = "lblstar2";
            this.lblstar2.Size = new System.Drawing.Size(100, 23);
            this.lblstar2.TabIndex = 2;
            // 
            // lblstar3
            // 
            this.lblstar3.BackColor = System.Drawing.Color.White;
            this.lblstar3.Location = new System.Drawing.Point(572, 120);
            this.lblstar3.Name = "lblstar3";
            this.lblstar3.Size = new System.Drawing.Size(100, 23);
            this.lblstar3.TabIndex = 3;
            // 
            // lblstar4
            // 
            this.lblstar4.BackColor = System.Drawing.Color.White;
            this.lblstar4.Location = new System.Drawing.Point(254, 155);
            this.lblstar4.Name = "lblstar4";
            this.lblstar4.Size = new System.Drawing.Size(100, 23);
            this.lblstar4.TabIndex = 4;
            // 
            // lblstar5
            // 
            this.lblstar5.BackColor = System.Drawing.Color.White;
            this.lblstar5.Location = new System.Drawing.Point(360, 155);
            this.lblstar5.Name = "lblstar5";
            this.lblstar5.Size = new System.Drawing.Size(100, 23);
            this.lblstar5.TabIndex = 5;
            // 
            // lblstar6
            // 
            this.lblstar6.BackColor = System.Drawing.Color.White;
            this.lblstar6.Location = new System.Drawing.Point(466, 155);
            this.lblstar6.Name = "lblstar6";
            this.lblstar6.Size = new System.Drawing.Size(100, 23);
            this.lblstar6.TabIndex = 6;
            // 
            // lblstar7
            // 
            this.lblstar7.BackColor = System.Drawing.Color.White;
            this.lblstar7.Location = new System.Drawing.Point(572, 155);
            this.lblstar7.Name = "lblstar7";
            this.lblstar7.Size = new System.Drawing.Size(100, 23);
            this.lblstar7.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblstar7);
            this.Controls.Add(this.lblstar6);
            this.Controls.Add(this.lblstar5);
            this.Controls.Add(this.lblstar4);
            this.Controls.Add(this.lblstar3);
            this.Controls.Add(this.lblstar2);
            this.Controls.Add(this.lblstar1);
            this.Controls.Add(this.lblstar0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Starfield";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblstar0;
        private System.Windows.Forms.Label lblstar1;
        private System.Windows.Forms.Label lblstar2;
        private System.Windows.Forms.Label lblstar3;
        private System.Windows.Forms.Label lblstar4;
        private System.Windows.Forms.Label lblstar5;
        private System.Windows.Forms.Label lblstar6;
        private System.Windows.Forms.Label lblstar7;
        private System.Windows.Forms.Timer timer1;
    }
}

