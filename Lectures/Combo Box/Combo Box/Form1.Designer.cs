namespace Combo_Box
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
            this.cboveggies = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnindex = new System.Windows.Forms.Button();
            this.btncount = new System.Windows.Forms.Button();
            this.btnabout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(259, 50);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(266, 123);
            this.lbloutput.TabIndex = 0;
            this.lbloutput.Click += new System.EventHandler(this.Lbloutput_Click);
            // 
            // cboveggies
            // 
            this.cboveggies.FormattingEnabled = true;
            this.cboveggies.Items.AddRange(new object[] {
            "bean",
            "corn",
            "lettuce"});
            this.cboveggies.Location = new System.Drawing.Point(12, 50);
            this.cboveggies.Name = "cboveggies";
            this.cboveggies.Size = new System.Drawing.Size(241, 24);
            this.cboveggies.TabIndex = 1;
            this.cboveggies.SelectedIndexChanged += new System.EventHandler(this.Cboveggies_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(72, 80);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 39);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add Item";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(72, 125);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(112, 39);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "Remove Item";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.Btnremove_Click);
            // 
            // btnindex
            // 
            this.btnindex.Location = new System.Drawing.Point(72, 170);
            this.btnindex.Name = "btnindex";
            this.btnindex.Size = new System.Drawing.Size(112, 39);
            this.btnindex.TabIndex = 4;
            this.btnindex.Text = "Show Index";
            this.btnindex.UseVisualStyleBackColor = true;
            this.btnindex.Click += new System.EventHandler(this.Btnindex_Click);
            // 
            // btncount
            // 
            this.btncount.Location = new System.Drawing.Point(72, 215);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(112, 39);
            this.btncount.TabIndex = 5;
            this.btncount.Text = "Item Count";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.Btncount_Click);
            // 
            // btnabout
            // 
            this.btnabout.Location = new System.Drawing.Point(72, 260);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(112, 39);
            this.btnabout.TabIndex = 6;
            this.btnabout.Text = "About Page";
            this.btnabout.UseVisualStyleBackColor = true;
            this.btnabout.Click += new System.EventHandler(this.Btnabout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.exitToolStripMenuItem.Text = "File";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnabout);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.btnindex);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cboveggies);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.ComboBox cboveggies;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnindex;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

