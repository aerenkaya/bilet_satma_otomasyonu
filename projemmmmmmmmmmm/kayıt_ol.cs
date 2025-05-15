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
using static projemmmmmmmmmmm.Form1;
namespace projemmmmmmmmmmm
{
    public partial class kayıt_ol : Form
    {
        public kayıt_ol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Lütfen tüm boşlukları doldurunuz.");
                return;
            }

            if (textBox3.Text != textBox5.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                label8.Text = "şifreler uyuşmuyor";
                return;
            }

            

            try
            {
                GlobalDatabase.Conn.Open();
                string sql = "INSERT INTO musteri (isim, soy_isim, telefon, sifre, kullanıcı_adi) VALUES (@isim, @soyad, @telefon, @sifre, @user)";
                MySqlCommand cmd = new MySqlCommand(sql, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@isim", textBox1.Text);
                cmd.Parameters.AddWithValue("@soyad", textBox2.Text);
                cmd.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);
                cmd.Parameters.AddWithValue("@sifre", textBox3.Text);
                cmd.Parameters.AddWithValue("@user", textBox5.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                GlobalDatabase.Conn.Close();
            }
        }

    }
}
