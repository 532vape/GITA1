namespace ForLoops
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
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnloop = new System.Windows.Forms.Button();
            this.btnrandom = new System.Windows.Forms.Button();
            this.txthowmany = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbloutput.Location = new System.Drawing.Point(606, 9);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(182, 432);
            this.lbloutput.TabIndex = 0;
            this.lbloutput.Click += new System.EventHandler(this.Lbloutput_Click);
            // 
            // btnloop
            // 
            this.btnloop.Location = new System.Drawing.Point(12, 12);
            this.btnloop.Name = "btnloop";
            this.btnloop.Size = new System.Drawing.Size(148, 75);
            this.btnloop.TabIndex = 1;
            this.btnloop.Text = "Loop";
            this.btnloop.UseVisualStyleBackColor = true;
            this.btnloop.Click += new System.EventHandler(this.Btnloop_Click);
            // 
            // btnrandom
            // 
            this.btnrandom.Location = new System.Drawing.Point(12, 93);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(148, 75);
            this.btnrandom.TabIndex = 2;
            this.btnrandom.Text = "Random";
            this.btnrandom.UseVisualStyleBackColor = true;
            this.btnrandom.Click += new System.EventHandler(this.Btnrandom_Click);
            // 
            // txthowmany
            // 
            this.txthowmany.Location = new System.Drawing.Point(247, 38);
            this.txthowmany.Name = "txthowmany";
            this.txthowmany.Size = new System.Drawing.Size(264, 22);
            this.txthowmany.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txthowmany);
            this.Controls.Add(this.btnrandom);
            this.Controls.Add(this.btnloop);
            this.Controls.Add(this.lbloutput);
            this.Name = "Form1";
            this.Text = "How to do for loops";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnloop;
        private System.Windows.Forms.Button btnrandom;
        private System.Windows.Forms.TextBox txthowmany;
    }
}

