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
    public partial class Hasilat : Form
    {
        public Hasilat(int toplamGelir)
        {
            InitializeComponent();
            labelGelir.Text = "Toplam Gelir: " + toplamGelir.ToString() + " TL";
        }

        private void labelGelir_Click(object sender, EventArgs e)
        {

        }

        private void Hasilat_Load(object sender, EventArgs e)
        {

        }
    }
}
