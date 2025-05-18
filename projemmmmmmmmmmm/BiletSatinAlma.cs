using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace projemmmmmmmmmmm
{
    public partial class BiletSatinAlma : Form
    {
        public BiletSatinAlma()
        {
            InitializeComponent();
            fiyatlar();
        }
       static int maraton, kapali, kale1, kale2, misafir;

        static void fiyatlar()
        {
            Form1.GlobalDatabase.Conn.Open();
            string sql = "SELECT * FROM fiyatlar";
            MySqlCommand komut = new MySqlCommand(sql, Form1.GlobalDatabase.Conn);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                maraton = Convert.ToInt32(dr["maraton"]);
                 kapali = Convert.ToInt32(dr["kapali"]);
                 kale1 = Convert.ToInt32(dr["kale1"]);
                 kale2 = Convert.ToInt32(dr["kale2"]);
                misafir = Convert.ToInt32(dr["misafir"]);

            }
            Form1.GlobalDatabase.Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Koltuklar";
            showdialog("Maraton",sql);
            bilet_kes.bilet_fiyat = maraton;
        }
        static void showdialog(string name,string sql)
        {
            bilet_kes bilet = new bilet_kes();
            bilet.Label1Text = name;
            
            bilet_kes.isim_table = sql;
            bilet.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "kapali";
            showdialog("KAPALI", sql);
            bilet_kes.bilet_fiyat = kapali;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "kale_arkasi1";
            showdialog("KALE ARKASI 1", sql);
            bilet_kes.bilet_fiyat = kale1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "kale_arkasi2";
            showdialog("KALE ARKASI 2", sql);
            bilet_kes.bilet_fiyat = kale2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "misafir";
            showdialog("Misafir", sql);
            bilet_kes.bilet_fiyat = misafir;
        }
    }
}
