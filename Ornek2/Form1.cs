using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Mouse alana girdiğinde
        private void txtYazilacakYazi_MouseEnter(object sender, EventArgs e)
        {
            txtYazilacakYazi.BackColor = Color.Coral;
            txtYazilacakYazi.ForeColor = Color.Red;
        }
        //Mouse alandan çıktığında
        private void txtYazilacakYazi_MouseLeave(object sender, EventArgs e)
        {
            txtYazilacakYazi.BackColor = Color.White;
            txtYazilacakYazi.ForeColor = Color.Black;
        }

        //TextBax'ın içinde yazılan yazı değiştiğinde anlık olarak güncel halini alıp Label'a yazdırmak için:
        private void txtYazilacakYazi_TextChanged(object sender, EventArgs e)
        {
            lblGelenYazi.Text=txtYazilacakYazi.Text;
        }
    }
}
