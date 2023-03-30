namespace Integer_Array
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
            this.btnrandom = new System.Windows.Forms.Button();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblavg = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnrandom
            // 
            this.btnrandom.Location = new System.Drawing.Point(241, 78);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(85, 29);
            this.btnrandom.TabIndex = 1;
            this.btnrandom.Text = "Generate";
            this.btnrandom.UseVisualStyleBackColor = true;
            this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(241, 45);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(100, 23);
            this.txtquantity.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(20, 45);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(85, 29);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblavg
            // 
            this.lblavg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblavg.Location = new System.Drawing.Point(20, 114);
            this.lblavg.Name = "lblavg";
            this.lblavg.Size = new System.Drawing.Size(171, 31);
            this.lblavg.TabIndex = 7;
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbloutput.Location = new System.Drawing.Point(17, 44);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(213, 218);
            this.lbloutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Average Attempts To Find";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblavg);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(379, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 167);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Array";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbloutput);
            this.groupBox2.Controls.Add(this.btnrandom);
            this.groupBox2.Controls.Add(this.txtquantity);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 292);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Integer Array";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Number Array";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnrandom;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblavg;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

