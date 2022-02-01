using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtxtTweet.MaxLength = 450;
        }

        private void rtxtTweet_TextChanged(object sender, EventArgs e)
        {
            int kackarakterVar = rtxtTweet.Text.Length;
            int kalanKarakterSayisi = 450 - kackarakterVar;
            lblKalanKarakter.Text = kalanKarakterSayisi.ToString();

            if (kalanKarakterSayisi<=20)
            {
                lblKalanKarakter.ForeColor = Color.Red;
                lblKalanKarakter.Font = new Font(lblKalanKarakter.Font, FontStyle.Bold);
            }
            else
            {
                lblKalanKarakter.ForeColor = Color.Black;
                lblKalanKarakter.Font = new Font(lblKalanKarakter.Font, FontStyle.Regular);
               
            }
        }

        private void lblTweet_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
