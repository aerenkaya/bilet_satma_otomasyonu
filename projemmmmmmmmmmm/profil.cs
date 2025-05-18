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
    public partial class profil : Form
    {
        public profil()
        {
            InitializeComponent();
        }

        private void profil_Load(object sender, EventArgs e)
        {
            txt_telefon.Text = "";
            Form1.GlobalDatabase.Conn.Open();
            string sql = "SELECT * FROM musteri WHERE id=@id";
            MySqlCommand komut = new MySqlCommand(sql, Form1.GlobalDatabase.Conn);
            komut.Parameters.AddWithValue("@id", Form1.GlobalDatabase.KullaniciID);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txt_kullanici_adi.Text += dr["kullanıcı_adi"].ToString();

                string telefonVerisi = dr["telefon"].ToString();
                string sadeceRakamlar = new string(telefonVerisi.Where(char.IsDigit).ToArray());
                txt_telefon.Text = sadeceRakamlar;

                txt_sifre.Text+= dr["sifre"].ToString();
                lbl_soy_isim.Text += dr["soy_isim"].ToString();
                lbl_isim.Text += dr["isim"].ToString();

            }
            Form1.GlobalDatabase.Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE musteri SET sifre = @sifre, telefon = @telefon, kullanıcı_adi = @kadi WHERE id=@id";

            Form1.GlobalDatabase.Conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, Form1.GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@kadi", txt_kullanici_adi.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            cmd.Parameters.AddWithValue("@telefon", txt_telefon.Text);
            cmd.Parameters.AddWithValue("@id", Form1.GlobalDatabase.KullaniciID);



            int etkilenenSatir = cmd.ExecuteNonQuery();
            Form1.GlobalDatabase.Conn.Close();

            if (etkilenenSatir > 0)
                MessageBox.Show("Profil  başarıyla güncellendi.");
            else
                MessageBox.Show("Güncelleme başarısız oldu.");
        }
    }
}
