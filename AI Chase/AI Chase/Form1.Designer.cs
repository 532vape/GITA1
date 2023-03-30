namespace AI_Chase
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
            this.label1 = new System.Windows.Forms.Label();
            this.picrussia = new System.Windows.Forms.PictureBox();
            this.picus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picrussia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(306, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose A Side";
            // 
            // picrussia
            // 
            this.picrussia.Image = ((System.Drawing.Image)(resources.GetObject("picrussia.Image")));
            this.picrussia.Location = new System.Drawing.Point(487, 329);
            this.picrussia.Name = "picrussia";
            this.picrussia.Size = new System.Drawing.Size(155, 79);
            this.picrussia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrussia.TabIndex = 1;
            this.picrussia.TabStop = false;
            this.picrussia.Click += new System.EventHandler(this.Picrussia_Click);
            // 
            // picus
            // 
            this.picus.Image = ((System.Drawing.Image)(resources.GetObject("picus.Image")));
            this.picus.Location = new System.Drawing.Point(145, 329);
            this.picus.Name = "picus";
            this.picus.Size = new System.Drawing.Size(155, 79);
            this.picus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picus.TabIndex = 2;
            this.picus.TabStop = false;
            this.picus.Click += new System.EventHandler(this.Picus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picus);
            this.Controls.Add(this.picrussia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Top Gun";
            ((System.ComponentModel.ISupportInitialize)(this.picrussia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picrussia;
        private System.Windows.Forms.PictureBox picus;
    }
}

