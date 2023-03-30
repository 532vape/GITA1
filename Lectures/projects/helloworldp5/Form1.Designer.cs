namespace helloworldp5
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btnpush = new System.Windows.Forms.Button();
            this.btnpush2 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.Color.Red;
            this.lblmessage.Location = new System.Drawing.Point(235, 29);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(346, 151);
            this.lblmessage.TabIndex = 1;
            this.lblmessage.Text = "За Родину";
            this.lblmessage.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnpush
            // 
            this.btnpush.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpush.Location = new System.Drawing.Point(425, 296);
            this.btnpush.Name = "btnpush";
            this.btnpush.Size = new System.Drawing.Size(236, 105);
            this.btnpush.TabIndex = 2;
            this.btnpush.Text = "for you capitalist pigs";
            this.btnpush.UseVisualStyleBackColor = true;
            this.btnpush.Click += new System.EventHandler(this.Btnpush_Click);
            // 
            // btnpush2
            // 
            this.btnpush2.Location = new System.Drawing.Point(425, 144);
            this.btnpush2.Name = "btnpush2";
            this.btnpush2.Size = new System.Drawing.Size(197, 120);
            this.btnpush2.TabIndex = 3;
            this.btnpush2.Text = "Stalin\'s opinion on the Third Reich";
            this.btnpush2.UseVisualStyleBackColor = true;
            this.btnpush2.Click += new System.EventHandler(this.Btnpush2_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(90, 205);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(210, 148);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Don\'t like Stalin?";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.Btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnpush2);
            this.Controls.Add(this.btnpush);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "my 2nd project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btnpush;
        private System.Windows.Forms.Button btnpush2;
        private System.Windows.Forms.Button btnclear;
    }
}

