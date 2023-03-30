namespace GraphicsEx
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnpush = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.pichappy = new System.Windows.Forms.PictureBox();
            this.picsad = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfont = new System.Windows.Forms.Button();
            this.btncolor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pichappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 86);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Black;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Green;
            this.lblMessage.Location = new System.Drawing.Point(238, 22);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(377, 71);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "How to Do Graphics";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnpush
            // 
            this.btnpush.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpush.Location = new System.Drawing.Point(367, 96);
            this.btnpush.Name = "btnpush";
            this.btnpush.Size = new System.Drawing.Size(113, 54);
            this.btnpush.TabIndex = 2;
            this.btnpush.Text = "push";
            this.btnpush.UseVisualStyleBackColor = true;
            this.btnpush.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(12, 104);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(139, 63);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.Btnclear_Click);
            // 
            // pichappy
            // 
            this.pichappy.Image = ((System.Drawing.Image)(resources.GetObject("pichappy.Image")));
            this.pichappy.Location = new System.Drawing.Point(12, 346);
            this.pichappy.Name = "pichappy";
            this.pichappy.Size = new System.Drawing.Size(603, 92);
            this.pichappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichappy.TabIndex = 4;
            this.pichappy.TabStop = false;
            this.pichappy.Visible = false;
            this.pichappy.Click += new System.EventHandler(this.Pichappy_Click);
            // 
            // picsad
            // 
            this.picsad.Image = ((System.Drawing.Image)(resources.GetObject("picsad.Image")));
            this.picsad.Location = new System.Drawing.Point(12, 346);
            this.picsad.Name = "picsad";
            this.picsad.Size = new System.Drawing.Size(603, 92);
            this.picsad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsad.TabIndex = 5;
            this.picsad.TabStop = false;
            this.picsad.Click += new System.EventHandler(this.Picsad_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 112);
            this.label1.TabIndex = 6;
            this.label1.Text = "beesechurger";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnfont
            // 
            this.btnfont.Location = new System.Drawing.Point(529, 220);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(182, 65);
            this.btnfont.TabIndex = 7;
            this.btnfont.Text = "font";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.Btnfont_Click);
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(539, 157);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(172, 38);
            this.btncolor.TabIndex = 8;
            this.btncolor.Text = "color";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.Btncolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picsad);
            this.Controls.Add(this.pichappy);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnpush);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "How to do Graphics";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pichappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnpush;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.PictureBox pichappy;
        private System.Windows.Forms.PictureBox picsad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

