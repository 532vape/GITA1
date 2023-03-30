namespace Textbox
{
    partial class Textboxes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtphrase = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblphrase = new System.Windows.Forms.Label();
            this.btnpush = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmessage
            // 
            this.lblmessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmessage.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Location = new System.Drawing.Point(52, 9);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(683, 81);
            this.lblmessage.TabIndex = 0;
            this.lblmessage.Text = "How to do textboxes";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 2);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(116, 126);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(240, 22);
            this.txtname.TabIndex = 2;
            // 
            // txtphrase
            // 
            this.txtphrase.Location = new System.Drawing.Point(116, 172);
            this.txtphrase.Name = "txtphrase";
            this.txtphrase.Size = new System.Drawing.Size(314, 22);
            this.txtphrase.TabIndex = 3;
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblname.Location = new System.Drawing.Point(12, 119);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(89, 27);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Name";
            // 
            // lblphrase
            // 
            this.lblphrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblphrase.Location = new System.Drawing.Point(12, 164);
            this.lblphrase.Name = "lblphrase";
            this.lblphrase.Size = new System.Drawing.Size(98, 30);
            this.lblphrase.TabIndex = 5;
            this.lblphrase.Text = "Phrase";
            // 
            // btnpush
            // 
            this.btnpush.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnpush.Location = new System.Drawing.Point(98, 231);
            this.btnpush.Name = "btnpush";
            this.btnpush.Size = new System.Drawing.Size(226, 58);
            this.btnpush.TabIndex = 6;
            this.btnpush.Text = "Push";
            this.btnpush.UseVisualStyleBackColor = true;
            this.btnpush.Click += new System.EventHandler(this.Btnpush_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "David Lim";
            // 
            // Textboxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnpush);
            this.Controls.Add(this.lblphrase);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtphrase);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmessage);
            this.Name = "Textboxes";
            this.Text = "Textboxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtphrase;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblphrase;
        private System.Windows.Forms.Button btnpush;
        private System.Windows.Forms.Label label2;
    }
}

