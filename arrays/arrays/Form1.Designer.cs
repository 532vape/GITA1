namespace arrays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picbox0 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.picbox2 = new System.Windows.Forms.PictureBox();
            this.picfish = new System.Windows.Forms.PictureBox();
            this.picbox3 = new System.Windows.Forms.PictureBox();
            this.btnmove = new System.Windows.Forms.Button();
            this.btnauto = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox0
            // 
            this.picbox0.Location = new System.Drawing.Point(190, 120);
            this.picbox0.Name = "picbox0";
            this.picbox0.Size = new System.Drawing.Size(100, 50);
            this.picbox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox0.TabIndex = 0;
            this.picbox0.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(190, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picbox1
            // 
            this.picbox1.Location = new System.Drawing.Point(366, 109);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(100, 50);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox1.TabIndex = 1;
            this.picbox1.TabStop = false;
            // 
            // picbox2
            // 
            this.picbox2.Location = new System.Drawing.Point(506, 109);
            this.picbox2.Name = "picbox2";
            this.picbox2.Size = new System.Drawing.Size(100, 50);
            this.picbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox2.TabIndex = 2;
            this.picbox2.TabStop = false;
            // 
            // picfish
            // 
            this.picfish.Image = ((System.Drawing.Image)(resources.GetObject("picfish.Image")));
            this.picfish.Location = new System.Drawing.Point(80, 215);
            this.picfish.Name = "picfish";
            this.picfish.Size = new System.Drawing.Size(273, 191);
            this.picfish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfish.TabIndex = 3;
            this.picfish.TabStop = false;
            // 
            // picbox3
            // 
            this.picbox3.Location = new System.Drawing.Point(646, 120);
            this.picbox3.Name = "picbox3";
            this.picbox3.Size = new System.Drawing.Size(100, 50);
            this.picbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox3.TabIndex = 4;
            this.picbox3.TabStop = false;
            // 
            // btnmove
            // 
            this.btnmove.Location = new System.Drawing.Point(506, 278);
            this.btnmove.Name = "btnmove";
            this.btnmove.Size = new System.Drawing.Size(75, 23);
            this.btnmove.TabIndex = 5;
            this.btnmove.Text = "Move";
            this.btnmove.UseVisualStyleBackColor = true;
            this.btnmove.Click += new System.EventHandler(this.Btnmove_Click);
            // 
            // btnauto
            // 
            this.btnauto.Location = new System.Drawing.Point(546, 341);
            this.btnauto.Name = "btnauto";
            this.btnauto.Size = new System.Drawing.Size(75, 23);
            this.btnauto.TabIndex = 6;
            this.btnauto.Text = "Auto";
            this.btnauto.UseVisualStyleBackColor = true;
            this.btnauto.Click += new System.EventHandler(this.Btnauto_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnauto);
            this.Controls.Add(this.btnmove);
            this.Controls.Add(this.picbox3);
            this.Controls.Add(this.picfish);
            this.Controls.Add(this.picbox2);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.picbox0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.PictureBox picbox2;
        private System.Windows.Forms.PictureBox picfish;
        private System.Windows.Forms.PictureBox picbox3;
        private System.Windows.Forms.Button btnmove;
        private System.Windows.Forms.Button btnauto;
        private System.Windows.Forms.Timer timer1;
    }
}

