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
    public partial class islemmenusu : Form
    {
        public islemmenusu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            profil profil = new profil();
            profil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FiyatListesiForm fiyatForm = new FiyatListesiForm();
            fiyatForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            oturmaplanı otrplan = new oturmaplanı();
            otrplan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BiletSatinAlma biletal = new BiletSatinAlma();
            biletal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BiletSatinAlma kombineal = new BiletSatinAlma();
            bilet_kes.kombine = 1;
            kombineal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 anaekran = new Form1();
            anaekran.Show();
        }
    }
}
