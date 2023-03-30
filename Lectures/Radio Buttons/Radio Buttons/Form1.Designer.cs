namespace Radio_Buttons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radother = new System.Windows.Forms.RadioButton();
            this.radcat = new System.Windows.Forms.RadioButton();
            this.raddog = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkshots = new System.Windows.Forms.CheckBox();
            this.chkgrooming = new System.Windows.Forms.CheckBox();
            this.chkshampoo = new System.Windows.Forms.CheckBox();
            this.btnok = new System.Windows.Forms.Button();
            this.pichappy = new System.Windows.Forms.PictureBox();
            this.picsad = new System.Windows.Forms.PictureBox();
            this.btnhappy = new System.Windows.Forms.Button();
            this.btnsad = new System.Windows.Forms.Button();
            this.picblank = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pichappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picblank)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radother);
            this.groupBox1.Controls.Add(this.radcat);
            this.groupBox1.Controls.Add(this.raddog);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Pet";
            // 
            // radother
            // 
            this.radother.AutoSize = true;
            this.radother.Location = new System.Drawing.Point(73, 158);
            this.radother.Name = "radother";
            this.radother.Size = new System.Drawing.Size(94, 33);
            this.radother.TabIndex = 4;
            this.radother.Text = "Other";
            this.radother.UseVisualStyleBackColor = true;
            // 
            // radcat
            // 
            this.radcat.AutoSize = true;
            this.radcat.Location = new System.Drawing.Point(73, 119);
            this.radcat.Name = "radcat";
            this.radcat.Size = new System.Drawing.Size(70, 33);
            this.radcat.TabIndex = 3;
            this.radcat.Text = "Cat";
            this.radcat.UseVisualStyleBackColor = true;
            // 
            // raddog
            // 
            this.raddog.AutoSize = true;
            this.raddog.Checked = true;
            this.raddog.Location = new System.Drawing.Point(73, 80);
            this.raddog.Name = "raddog";
            this.raddog.Size = new System.Drawing.Size(79, 33);
            this.raddog.TabIndex = 2;
            this.raddog.TabStop = true;
            this.raddog.Text = "Dog";
            this.raddog.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox2.Location = new System.Drawing.Point(401, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type of Service";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkshots);
            this.groupBox3.Controls.Add(this.chkgrooming);
            this.groupBox3.Controls.Add(this.chkshampoo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox3.Location = new System.Drawing.Point(419, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 242);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type of Service";
            // 
            // chkshots
            // 
            this.chkshots.AutoSize = true;
            this.chkshots.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.chkshots.Location = new System.Drawing.Point(17, 159);
            this.chkshots.Name = "chkshots";
            this.chkshots.Size = new System.Drawing.Size(96, 33);
            this.chkshots.TabIndex = 5;
            this.chkshots.Text = "Shots";
            this.chkshots.UseVisualStyleBackColor = true;
            // 
            // chkgrooming
            // 
            this.chkgrooming.AutoSize = true;
            this.chkgrooming.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.chkgrooming.Location = new System.Drawing.Point(17, 120);
            this.chkgrooming.Name = "chkgrooming";
            this.chkgrooming.Size = new System.Drawing.Size(142, 33);
            this.chkgrooming.TabIndex = 4;
            this.chkgrooming.Text = "Grooming";
            this.chkgrooming.UseVisualStyleBackColor = true;
            // 
            // chkshampoo
            // 
            this.chkshampoo.AutoSize = true;
            this.chkshampoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.chkshampoo.Location = new System.Drawing.Point(17, 80);
            this.chkshampoo.Name = "chkshampoo";
            this.chkshampoo.Size = new System.Drawing.Size(139, 33);
            this.chkshampoo.TabIndex = 3;
            this.chkshampoo.Text = "Shampoo";
            this.chkshampoo.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(14, 260);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(165, 46);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.Btnok_Click);
            // 
            // pichappy
            // 
            this.pichappy.Image = ((System.Drawing.Image)(resources.GetObject("pichappy.Image")));
            this.pichappy.Location = new System.Drawing.Point(646, 409);
            this.pichappy.Name = "pichappy";
            this.pichappy.Size = new System.Drawing.Size(54, 29);
            this.pichappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichappy.TabIndex = 3;
            this.pichappy.TabStop = false;
            this.pichappy.Visible = false;
            // 
            // picsad
            // 
            this.picsad.Image = ((System.Drawing.Image)(resources.GetObject("picsad.Image")));
            this.picsad.Location = new System.Drawing.Point(617, 345);
            this.picsad.Name = "picsad";
            this.picsad.Size = new System.Drawing.Size(110, 70);
            this.picsad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsad.TabIndex = 4;
            this.picsad.TabStop = false;
            this.picsad.Visible = false;
            // 
            // btnhappy
            // 
            this.btnhappy.Location = new System.Drawing.Point(234, 293);
            this.btnhappy.Name = "btnhappy";
            this.btnhappy.Size = new System.Drawing.Size(165, 46);
            this.btnhappy.TabIndex = 5;
            this.btnhappy.Text = "Happy";
            this.btnhappy.UseVisualStyleBackColor = true;
            this.btnhappy.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnsad
            // 
            this.btnsad.Location = new System.Drawing.Point(12, 312);
            this.btnsad.Name = "btnsad";
            this.btnsad.Size = new System.Drawing.Size(165, 46);
            this.btnsad.TabIndex = 6;
            this.btnsad.Text = "Sad";
            this.btnsad.UseVisualStyleBackColor = true;
            this.btnsad.Click += new System.EventHandler(this.Btnsad_Click);
            // 
            // picblank
            // 
            this.picblank.Location = new System.Drawing.Point(436, 293);
            this.picblank.Name = "picblank";
            this.picblank.Size = new System.Drawing.Size(115, 75);
            this.picblank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picblank.TabIndex = 7;
            this.picblank.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picblank);
            this.Controls.Add(this.btnsad);
            this.Controls.Add(this.btnhappy);
            this.Controls.Add(this.picsad);
            this.Controls.Add(this.pichappy);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pet Care Clinic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pichappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picblank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radother;
        private System.Windows.Forms.RadioButton radcat;
        private System.Windows.Forms.RadioButton raddog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.CheckBox chkshots;
        private System.Windows.Forms.CheckBox chkgrooming;
        private System.Windows.Forms.CheckBox chkshampoo;
        private System.Windows.Forms.PictureBox pichappy;
        private System.Windows.Forms.PictureBox picsad;
        private System.Windows.Forms.Button btnhappy;
        private System.Windows.Forms.Button btnsad;
        private System.Windows.Forms.PictureBox picblank;
    }
}

