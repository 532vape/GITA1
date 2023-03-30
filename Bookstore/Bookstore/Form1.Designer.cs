namespace Bookstore
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
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblextendedprice = new System.Windows.Forms.Label();
            this.lbldiscountamount = new System.Windows.Forms.Label();
            this.lbldiscountprice = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblaveragesale = new System.Windows.Forms.Label();
            this.lbltotalsales = new System.Windows.Forms.Label();
            this.lbltotalpeople = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(339, 11);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(146, 22);
            this.txttitle.TabIndex = 0;
            this.txttitle.TextChanged += new System.EventHandler(this.Txttitle_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(339, 39);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(146, 22);
            this.txtprice.TabIndex = 1;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(339, 67);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(146, 22);
            this.txtquantity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(-4, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(805, 2);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label5.Location = new System.Drawing.Point(140, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Extended Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Discount Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Discount Price";
            // 
            // lblextendedprice
            // 
            this.lblextendedprice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblextendedprice.Location = new System.Drawing.Point(339, 129);
            this.lblextendedprice.Name = "lblextendedprice";
            this.lblextendedprice.Size = new System.Drawing.Size(146, 23);
            this.lblextendedprice.TabIndex = 10;
            this.lblextendedprice.Click += new System.EventHandler(this.Lblextendedprice_Click);
            // 
            // lbldiscountamount
            // 
            this.lbldiscountamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldiscountamount.Location = new System.Drawing.Point(339, 158);
            this.lbldiscountamount.Name = "lbldiscountamount";
            this.lbldiscountamount.Size = new System.Drawing.Size(146, 23);
            this.lbldiscountamount.TabIndex = 11;
            // 
            // lbldiscountprice
            // 
            this.lbldiscountprice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldiscountprice.Location = new System.Drawing.Point(339, 187);
            this.lbldiscountprice.Name = "lbldiscountprice";
            this.lbldiscountprice.Size = new System.Drawing.Size(146, 23);
            this.lbldiscountprice.TabIndex = 12;
            this.lbldiscountprice.Click += new System.EventHandler(this.Lbldiscountprice_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btncalculate.Location = new System.Drawing.Point(540, 123);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(155, 36);
            this.btncalculate.TabIndex = 13;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.Btncalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblaveragesale);
            this.groupBox1.Controls.Add(this.lbltotalsales);
            this.groupBox1.Controls.Add(this.lbltotalpeople);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(145, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 150);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager Info.";
            // 
            // lblaveragesale
            // 
            this.lblaveragesale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblaveragesale.Location = new System.Drawing.Point(131, 74);
            this.lblaveragesale.Name = "lblaveragesale";
            this.lblaveragesale.Size = new System.Drawing.Size(100, 23);
            this.lblaveragesale.TabIndex = 5;
            // 
            // lbltotalsales
            // 
            this.lbltotalsales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltotalsales.Location = new System.Drawing.Point(131, 51);
            this.lbltotalsales.Name = "lbltotalsales";
            this.lbltotalsales.Size = new System.Drawing.Size(100, 23);
            this.lbltotalsales.TabIndex = 4;
            // 
            // lbltotalpeople
            // 
            this.lbltotalpeople.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltotalpeople.Location = new System.Drawing.Point(131, 28);
            this.lbltotalpeople.Name = "lbltotalpeople";
            this.lbltotalpeople.Size = new System.Drawing.Size(100, 23);
            this.lbltotalpeople.TabIndex = 3;
            this.lbltotalpeople.Click += new System.EventHandler(this.Lbltotalpeople_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Average Sale";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total Sales";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total People";
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnclear.Location = new System.Drawing.Point(540, 165);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(155, 45);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.Btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnexit.Location = new System.Drawing.Point(633, 387);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(155, 51);
            this.btnexit.TabIndex = 16;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lbldiscountprice);
            this.Controls.Add(this.lbldiscountamount);
            this.Controls.Add(this.lblextendedprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txttitle);
            this.Name = "Form1";
            this.Text = "How to Calculate Book Sales";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblextendedprice;
        private System.Windows.Forms.Label lbldiscountamount;
        private System.Windows.Forms.Label lbldiscountprice;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblaveragesale;
        private System.Windows.Forms.Label lbltotalsales;
        private System.Windows.Forms.Label lbltotalpeople;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

