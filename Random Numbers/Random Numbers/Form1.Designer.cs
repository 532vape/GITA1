namespace Random_Numbers
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
            this.pichappy = new System.Windows.Forms.PictureBox();
            this.picsad = new System.Windows.Forms.PictureBox();
            this.picblank = new System.Windows.Forms.PictureBox();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btnrandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pichappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picblank)).BeginInit();
            this.SuspendLayout();
            // 
            // pichappy
            // 
            this.pichappy.Image = ((System.Drawing.Image)(resources.GetObject("pichappy.Image")));
            this.pichappy.Location = new System.Drawing.Point(258, 261);
            this.pichappy.Name = "pichappy";
            this.pichappy.Size = new System.Drawing.Size(104, 86);
            this.pichappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichappy.TabIndex = 0;
            this.pichappy.TabStop = false;
            this.pichappy.Visible = false;
            // 
            // picsad
            // 
            this.picsad.Image = ((System.Drawing.Image)(resources.GetObject("picsad.Image")));
            this.picsad.Location = new System.Drawing.Point(409, 261);
            this.picsad.Name = "picsad";
            this.picsad.Size = new System.Drawing.Size(104, 86);
            this.picsad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsad.TabIndex = 1;
            this.picsad.TabStop = false;
            this.picsad.Visible = false;
            this.picsad.Click += new System.EventHandler(this.Picsad_Click);
            // 
            // picblank
            // 
            this.picblank.Location = new System.Drawing.Point(563, 12);
            this.picblank.Name = "picblank";
            this.picblank.Size = new System.Drawing.Size(225, 166);
            this.picblank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picblank.TabIndex = 2;
            this.picblank.TabStop = false;
            // 
            // lblmessage
            // 
            this.lblmessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblmessage.Location = new System.Drawing.Point(12, 9);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(389, 75);
            this.lblmessage.TabIndex = 3;
            this.lblmessage.Text = "label1";
            // 
            // btnrandom
            // 
            this.btnrandom.Location = new System.Drawing.Point(107, 167);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(114, 50);
            this.btnrandom.TabIndex = 4;
            this.btnrandom.Text = "generate";
            this.btnrandom.UseVisualStyleBackColor = true;
            this.btnrandom.Click += new System.EventHandler(this.Btnrandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrandom);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.picblank);
            this.Controls.Add(this.picsad);
            this.Controls.Add(this.pichappy);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pichappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picblank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pichappy;
        private System.Windows.Forms.PictureBox picsad;
        private System.Windows.Forms.PictureBox picblank;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btnrandom;
    }
}

