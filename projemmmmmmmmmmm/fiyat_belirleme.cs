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
    public partial class fiyat_belirleme : Form
    {
        public fiyat_belirleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.GlobalDatabase.Conn.Open();
            string sql = "SELECT * FROM fiyatlar";
            MySqlCommand komut = new MySqlCommand(sql, Form1.GlobalDatabase.Conn);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txt_maraton.Text = dr["maraton"].ToString();
                txt_kapali.Text = dr["kapali"].ToString();
                txt_kale1.Text = dr["kale1"].ToString();
                txt_kale2.Text = dr["kale2"].ToString();
                txt_misafir.Text = dr["misafir"].ToString();

            }
            Form1.GlobalDatabase.Conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE fiyatlar SET maraton = @maraton, kapali = @kapali, kale1 = @kale1,kale2 = @kale2,misafir = @misafir WHERE id=1";

            Form1.GlobalDatabase.Conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, Form1.GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@maraton", Convert.ToInt32(txt_maraton.Text));
            cmd.Parameters.AddWithValue("@kapali", Convert.ToInt32(txt_kapali.Text));
            cmd.Parameters.AddWithValue("@kale1", Convert.ToInt32(txt_kale1.Text));
            cmd.Parameters.AddWithValue("@kale2", Convert.ToInt32(txt_kale2.Text));
            cmd.Parameters.AddWithValue("@misafir", Convert.ToInt32(txt_misafir.Text));

            int etkilenenSatir = cmd.ExecuteNonQuery();
            Form1.GlobalDatabase.Conn.Close();

            if (etkilenenSatir > 0)
                MessageBox.Show("Fiyatlar başarıyla güncellendi.");
            else
                MessageBox.Show("Güncelleme başarısız oldu.");
        }
    }
}
