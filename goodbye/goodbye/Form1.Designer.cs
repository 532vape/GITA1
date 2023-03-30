namespace goodbye
{
    partial class Title
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
            this.lblmessage = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnkorean = new System.Windows.Forms.Button();
            this.btngerman = new System.Windows.Forms.Button();
            this.btngreek = new System.Windows.Forms.Button();
            this.btnrussian = new System.Windows.Forms.Button();
            this.picboxamerica = new System.Windows.Forms.PictureBox();
            this.picboxgreece = new System.Windows.Forms.PictureBox();
            this.picboxrussian = new System.Windows.Forms.PictureBox();
            this.picboxkorean = new System.Windows.Forms.PictureBox();
            this.picboxgerman = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblby = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxamerica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxgreece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrussian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxkorean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxgerman)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmessage
            // 
            this.lblmessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmessage.Font = new System.Drawing.Font("Tahoma", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblmessage.Location = new System.Drawing.Point(265, 9);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(270, 81);
            this.lblmessage.TabIndex = 0;
            this.lblmessage.Text = "Goodbye";
            this.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblmessage.Click += new System.EventHandler(this.Lblmessage_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(285, 281);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(92, 29);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "RESET";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.Btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(423, 281);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(92, 29);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // btnkorean
            // 
            this.btnkorean.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkorean.Location = new System.Drawing.Point(96, 122);
            this.btnkorean.Name = "btnkorean";
            this.btnkorean.Size = new System.Drawing.Size(163, 58);
            this.btnkorean.TabIndex = 3;
            this.btnkorean.Text = "Korean";
            this.btnkorean.UseVisualStyleBackColor = true;
            this.btnkorean.Click += new System.EventHandler(this.Btnkorean_Click);
            // 
            // btngerman
            // 
            this.btngerman.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngerman.Location = new System.Drawing.Point(96, 212);
            this.btngerman.Name = "btngerman";
            this.btngerman.Size = new System.Drawing.Size(163, 58);
            this.btngerman.TabIndex = 4;
            this.btngerman.Text = "German";
            this.btngerman.UseVisualStyleBackColor = true;
            this.btngerman.Click += new System.EventHandler(this.Btngerman_Click);
            // 
            // btngreek
            // 
            this.btngreek.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngreek.Location = new System.Drawing.Point(541, 122);
            this.btngreek.Name = "btngreek";
            this.btngreek.Size = new System.Drawing.Size(163, 58);
            this.btngreek.TabIndex = 5;
            this.btngreek.Text = "Greek";
            this.btngreek.UseVisualStyleBackColor = true;
            this.btngreek.Click += new System.EventHandler(this.Btngreek_Click);
            // 
            // btnrussian
            // 
            this.btnrussian.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrussian.Location = new System.Drawing.Point(541, 212);
            this.btnrussian.Name = "btnrussian";
            this.btnrussian.Size = new System.Drawing.Size(163, 58);
            this.btnrussian.TabIndex = 6;
            this.btnrussian.Text = "Russian";
            this.btnrussian.UseVisualStyleBackColor = true;
            this.btnrussian.Click += new System.EventHandler(this.Btnrussian_Click);
            // 
            // picboxamerica
            // 
            this.picboxamerica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxamerica.Image = global::goodbye.Properties.Resources._330px_Flag_of_the_United_States_svg;
            this.picboxamerica.Location = new System.Drawing.Point(265, 122);
            this.picboxamerica.Name = "picboxamerica";
            this.picboxamerica.Size = new System.Drawing.Size(270, 148);
            this.picboxamerica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxamerica.TabIndex = 11;
            this.picboxamerica.TabStop = false;
            this.picboxamerica.Click += new System.EventHandler(this.Picboxamerica_Click);
            // 
            // picboxgreece
            // 
            this.picboxgreece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxgreece.Image = global::goodbye.Properties.Resources._2000px_Flag_of_Greece_svg;
            this.picboxgreece.Location = new System.Drawing.Point(265, 122);
            this.picboxgreece.Name = "picboxgreece";
            this.picboxgreece.Size = new System.Drawing.Size(270, 148);
            this.picboxgreece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxgreece.TabIndex = 10;
            this.picboxgreece.TabStop = false;
            this.picboxgreece.Click += new System.EventHandler(this.Picboxgreece_Click);
            // 
            // picboxrussian
            // 
            this.picboxrussian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxrussian.Image = global::goodbye.Properties.Resources._383px_Flag_of_Russia_svg;
            this.picboxrussian.Location = new System.Drawing.Point(265, 122);
            this.picboxrussian.Name = "picboxrussian";
            this.picboxrussian.Size = new System.Drawing.Size(270, 148);
            this.picboxrussian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxrussian.TabIndex = 9;
            this.picboxrussian.TabStop = false;
            // 
            // picboxkorean
            // 
            this.picboxkorean.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxkorean.Image = global::goodbye.Properties.Resources._383px_Flag_of_South_Korea_svg;
            this.picboxkorean.Location = new System.Drawing.Point(265, 122);
            this.picboxkorean.Name = "picboxkorean";
            this.picboxkorean.Size = new System.Drawing.Size(270, 148);
            this.picboxkorean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxkorean.TabIndex = 8;
            this.picboxkorean.TabStop = false;
            this.picboxkorean.Click += new System.EventHandler(this.Picboxkorean_Click);
            // 
            // picboxgerman
            // 
            this.picboxgerman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxgerman.Image = global::goodbye.Properties.Resources._1280px_Flag_of_Germany_svg;
            this.picboxgerman.Location = new System.Drawing.Point(265, 128);
            this.picboxgerman.Name = "picboxgerman";
            this.picboxgerman.Size = new System.Drawing.Size(270, 142);
            this.picboxgerman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxgerman.TabIndex = 7;
            this.picboxgerman.TabStop = false;
            this.picboxgerman.Click += new System.EventHandler(this.Picboxgerman_Click);
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(12, 9);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(199, 35);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Goodbye Program";
            // 
            // lblby
            // 
            this.lblby.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblby.Location = new System.Drawing.Point(13, 32);
            this.lblby.Name = "lblby";
            this.lblby.Size = new System.Drawing.Size(100, 23);
            this.lblby.TabIndex = 13;
            this.lblby.Text = "By David Lim";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(16, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 2);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(772, 2);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblby);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.picboxamerica);
            this.Controls.Add(this.picboxgreece);
            this.Controls.Add(this.picboxrussian);
            this.Controls.Add(this.picboxkorean);
            this.Controls.Add(this.picboxgerman);
            this.Controls.Add(this.btnrussian);
            this.Controls.Add(this.btngreek);
            this.Controls.Add(this.btngerman);
            this.Controls.Add(this.btnkorean);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lblmessage);
            this.Name = "Title";
            this.Text = "Goodbye";
            this.Load += new System.EventHandler(this.Title_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxamerica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxgreece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrussian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxkorean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxgerman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnkorean;
        private System.Windows.Forms.Button btngerman;
        private System.Windows.Forms.Button btngreek;
        private System.Windows.Forms.Button btnrussian;
        private System.Windows.Forms.PictureBox picboxgerman;
        private System.Windows.Forms.PictureBox picboxkorean;
        private System.Windows.Forms.PictureBox picboxrussian;
        private System.Windows.Forms.PictureBox picboxgreece;
        private System.Windows.Forms.PictureBox picboxamerica;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

