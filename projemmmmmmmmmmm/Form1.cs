using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projemmmmmmmmmmm;

namespace projemmmmmmmmmmm {


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=bilet_ke;Uid=root;Pwd=12345");
        public static class GlobalDatabase
        {
            // Global olarak erişilebilen veritabanı bileşenleri
            public static MySqlConnection Conn { get; set; }
            public static int KullaniciID { get; set; }
            public static string KullaniciAdi { get; set; }
            public static string Isim { get; set; }
            public static string Soyisim { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rd_yonetici.Checked)
                {
                    string kullaniciAdi = textBox1.Text;
                    string sifre = textBox2.Text;
                    GlobalDatabase.Conn = conn;
                    try
                    {
                        GlobalDatabase.Conn.Open();

                        string query = "SELECT * FROM yonetici WHERE kullanıcı_adi = @kadi AND sifre = @sifre";
                        MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                        cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Kullanıcı bulundu, bilgileri static sınıfa kaydet
                            GlobalDatabase.KullaniciID = reader.GetInt32("id");
                            GlobalDatabase.KullaniciAdi = reader.GetString("kullanıcı_adi");
                            GlobalDatabase.Isim = reader.GetString("isim");
                            GlobalDatabase.Soyisim = reader.GetString("soy_isim");

                            reader.Close();

                          yonetici_islemler yonetici=new yonetici_islemler();
                            yonetici.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                        }
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
                else if (rd_user.Checked)
                {

                    string kullaniciAdi = textBox1.Text;
                    string sifre = textBox2.Text;
                    GlobalDatabase.Conn = conn;
                    try
                    {
                        GlobalDatabase.Conn.Open();

                        string query = "SELECT * FROM musteri WHERE kullanıcı_adi = @kadi AND sifre = @sifre";
                        MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                        cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Kullanıcı bulundu, bilgileri static sınıfa kaydet
                            GlobalDatabase.KullaniciID = reader.GetInt32("id");
                            GlobalDatabase.KullaniciAdi = reader.GetString("kullanıcı_adi");
                            GlobalDatabase.Isim = reader.GetString("isim");
                            GlobalDatabase.Soyisim = reader.GetString("soy_isim");

                            reader.Close();

                            islemmenusu anaEkran = new islemmenusu();
                            anaEkran.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                        }
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
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalDatabase.Conn = conn;
            kayıt_ol kayıt_Ol = new kayıt_ol();
            kayıt_Ol.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mesaj = "Telefon: 0 (212) 123 45 67\n" +
                   "E-posta Adresimiz: destek@horozbilet.com\n" +
                   "Çalışma Saatleri: 09:00 - 19:00\n"+
                   "Instagram hesabımız: horozbilet";
           MessageBox.Show(mesaj, "Bize Ulaşın", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

       
    

