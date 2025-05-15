using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static projemmmmmmmmmmm.Form1;
using MySql.Data.MySqlClient;
namespace projemmmmmmmmmmm
{
    public partial class kullanıcı : Form
    {
        public kullanıcı()
        {
            InitializeComponent();
            KoltuklariOlustur();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> secilenKoltuklar = new List<string>();

            foreach (CheckBox koltuk in panel1.Controls.OfType<CheckBox>())
            {
                if (koltuk.Checked)
                {
                    secilenKoltuklar.Add(koltuk.Name); // örn: "Koltuk_2_4"
                }
            }

            if (secilenKoltuklar.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir koltuk seçiniz.");
                return;
            }

            // Veritabanına kaydetme işlemi
            try
            {
                GlobalDatabase.Conn.Open();

                foreach (string koltuk in secilenKoltuklar)
                {
                    string sql = "INSERT INTO bilet (kullanici_id, koltuk_no, tarih) VALUES (@kID, @koltuk, NOW())";
                    MySqlCommand cmd = new MySqlCommand(sql, GlobalDatabase.Conn);
                    cmd.Parameters.AddWithValue("@kID", GlobalDatabase.KullaniciID); // bunu giriş formundan aktarırsın
                    cmd.Parameters.AddWithValue("@koltuk", koltuk);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Bilet(ler) başarıyla satın alındı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                GlobalDatabase.Conn.Close();
            }
        }
        private void SatilanKoltuklariYukle()
        {
            try
            {
                GlobalDatabase.Conn.Open();
                string sql = "SELECT koltuk_no FROM bilet";
                MySqlCommand cmd = new MySqlCommand(sql, GlobalDatabase.Conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string koltukNo = reader.GetString("koltuk_no");
                    var koltuk = panel1.Controls.Find(koltukNo, true).FirstOrDefault() as CheckBox;
                    if (koltuk != null)
                    {
                        koltuk.Enabled = false;
                        koltuk.BackColor = Color.Red;
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                GlobalDatabase.Conn.Close();
            }
        }


        private void KoltuklariOlustur()
        {
            int satir = 5;
            int sutun = 10;
            int baslangicX = 20;
            int baslangicY = 20;
            int aralik = 30;

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    CheckBox koltuk = new CheckBox();
                    koltuk.Width = 20;
                    koltuk.Height = 20;
                    koltuk.Left = baslangicX + j * aralik;
                    koltuk.Top = baslangicY + i * aralik;
                    koltuk.Name = $"Koltuk_{i}_{j}";
                    koltuk.Text = ""; // istersen numara yazabilirsin

                    panel1.Controls.Add(koltuk); // Koltukların bulunduğu panel
                }
            }
        }

    }
}
