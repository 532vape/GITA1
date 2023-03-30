namespace Number_Arrays
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
            this.txthowmany = new System.Windows.Forms.TextBox();
            this.btnrandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(641, 9);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(147, 394);
            this.lbloutput.TabIndex = 0;
            // 
            // txthowmany
            // 
            this.txthowmany.Location = new System.Drawing.Point(413, 74);
            this.txthowmany.Name = "txthowmany";
            this.txthowmany.Size = new System.Drawing.Size(100, 22);
            this.txthowmany.TabIndex = 1;
            // 
            // btnrandom
            // 
            this.btnrandom.Location = new System.Drawing.Point(216, 84);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(75, 23);
            this.btnrandom.TabIndex = 2;
            this.btnrandom.Text = "Random";
            this.btnrandom.UseVisualStyleBackColor = true;
            this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrandom);
            this.Controls.Add(this.txthowmany);
            this.Controls.Add(this.lbloutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txthowmany;
        private System.Windows.Forms.Button btnrandom;
    }
}

