
namespace Ornek2
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
            this.txtYazilacakYazi = new System.Windows.Forms.TextBox();
            this.lblGelenYazi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYazilacakYazi
            // 
            this.txtYazilacakYazi.Location = new System.Drawing.Point(12, 38);
            this.txtYazilacakYazi.Name = "txtYazilacakYazi";
            this.txtYazilacakYazi.Size = new System.Drawing.Size(324, 20);
            this.txtYazilacakYazi.TabIndex = 0;
            this.txtYazilacakYazi.TextChanged += new System.EventHandler(this.txtYazilacakYazi_TextChanged);
            this.txtYazilacakYazi.MouseEnter += new System.EventHandler(this.txtYazilacakYazi_MouseEnter);
            this.txtYazilacakYazi.MouseLeave += new System.EventHandler(this.txtYazilacakYazi_MouseLeave);
            // 
            // lblGelenYazi
            // 
            this.lblGelenYazi.AutoSize = true;
            this.lblGelenYazi.Location = new System.Drawing.Point(12, 73);
            this.lblGelenYazi.Name = "lblGelenYazi";
            this.lblGelenYazi.Size = new System.Drawing.Size(0, 13);
            this.lblGelenYazi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 185);
            this.Controls.Add(this.lblGelenYazi);
            this.Controls.Add(this.txtYazilacakYazi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYazilacakYazi;
        private System.Windows.Forms.Label lblGelenYazi;
    }
}

