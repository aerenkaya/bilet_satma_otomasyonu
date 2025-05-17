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
    public partial class BiletSatinAlma : Form
    {
        public BiletSatinAlma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Koltuklar";
            showdialog("Maraton",sql);
        }
        static void showdialog(string name,string sql)
        {
            bilet_kes bilet = new bilet_kes();
            bilet.Label1Text = name;
            
            bilet_kes.isim_table = sql;
            bilet.Show();
        }
    }
}
