using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projemmmmmmmmmmm
{
    public partial class yonetici_islemler : Form
    {
        public yonetici_islemler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fiyat_belirleme fiyat=new fiyat_belirleme();
            fiyat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
