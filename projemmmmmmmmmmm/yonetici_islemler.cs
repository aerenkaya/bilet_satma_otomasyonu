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
    public partial class yonetici_islemler : Form
    {
        int maraton, kapali, kale1, kale2, misafir;

        private int HesaplaGelir()
        {
            int toplamGelir = 0;
            int maraton = 200, kapali = 250, kale1 = 150, kale2 = 150, misafir = 100; 
            Form1.GlobalDatabase.Conn.Open();

            List<(string tabloAdi, int fiyat)> tribuneBilgileri = new List<(string, int)>
        {
        ("koltuklar", maraton),
        ("kapali", kapali),
        ("kale_arkasi1", kale1),
        ("kale_arkasi2", kale2),
        ("misafir", misafir)
        };

            foreach (var (tablo, fiyat) in tribuneBilgileri)
            {
                string sql = $"SELECT COUNT(*) FROM {tablo} WHERE durum = 1";
                MySqlCommand cmd = new MySqlCommand(sql, Form1.GlobalDatabase.Conn);
                int satilan = Convert.ToInt32(cmd.ExecuteScalar());
                toplamGelir += satilan * fiyat;
            }
            Form1.GlobalDatabase.Conn.Close();
            return toplamGelir;
        }

        private void FiyatlariGetir()
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
            SatılanBilet satilanbil = new SatılanBilet();
            satilanbil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gelir = HesaplaGelir();
            Hasilat hasilatForm = new Hasilat(gelir);
            hasilatForm.ShowDialog();
        }
    }
}
