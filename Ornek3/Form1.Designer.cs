
namespace Ornek3
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
            this.lblTweet = new System.Windows.Forms.Label();
            this.rtxtTweet = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKalanKarakter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTweet
            // 
            this.lblTweet.AutoSize = true;
            this.lblTweet.Location = new System.Drawing.Point(30, 181);
            this.lblTweet.Name = "lblTweet";
            this.lblTweet.Size = new System.Drawing.Size(0, 13);
            this.lblTweet.TabIndex = 0;
            this.lblTweet.Click += new System.EventHandler(this.lblTweet_Click);
            // 
            // rtxtTweet
            // 
            this.rtxtTweet.Location = new System.Drawing.Point(33, 49);
            this.rtxtTweet.Name = "rtxtTweet";
            this.rtxtTweet.Size = new System.Drawing.Size(310, 96);
            this.rtxtTweet.TabIndex = 2;
            this.rtxtTweet.Text = "";
            this.rtxtTweet.TextChanged += new System.EventHandler(this.rtxtTweet_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 191);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 92);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kalan Karaker Sayısı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKalanKarakter
            // 
            this.lblKalanKarakter.AutoSize = true;
            this.lblKalanKarakter.Location = new System.Drawing.Point(143, 162);
            this.lblKalanKarakter.Name = "lblKalanKarakter";
            this.lblKalanKarakter.Size = new System.Drawing.Size(25, 13);
            this.lblKalanKarakter.TabIndex = 5;
            this.lblKalanKarakter.Text = "450";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 326);
            this.Controls.Add(this.lblKalanKarakter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtxtTweet);
            this.Controls.Add(this.lblTweet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTweet;
        private System.Windows.Forms.RichTextBox rtxtTweet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKalanKarakter;
    }
}

