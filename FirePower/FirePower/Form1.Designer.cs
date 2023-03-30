namespace FirePower
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
            this.lblspaceship = new System.Windows.Forms.Label();
            this.lbltarget = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblspaceship
            // 
            this.lblspaceship.BackColor = System.Drawing.Color.Lime;
            this.lblspaceship.Location = new System.Drawing.Point(345, 360);
            this.lblspaceship.Name = "lblspaceship";
            this.lblspaceship.Size = new System.Drawing.Size(100, 23);
            this.lblspaceship.TabIndex = 0;
            this.lblspaceship.Text = "Spaceship";
            // 
            // lbltarget
            // 
            this.lbltarget.BackColor = System.Drawing.Color.Red;
            this.lbltarget.Location = new System.Drawing.Point(350, 214);
            this.lbltarget.Name = "lbltarget";
            this.lbltarget.Size = new System.Drawing.Size(100, 23);
            this.lbltarget.TabIndex = 1;
            this.lbltarget.Text = "target";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltarget);
            this.Controls.Add(this.lblspaceship);
            this.Name = "Form1";
            this.Text = "Fire Power";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblspaceship;
        private System.Windows.Forms.Label lbltarget;
        private System.Windows.Forms.Timer timer1;
    }
}

