using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projemmmmmmmmmmm
{
    public partial class bilet_kes : Form
    {
        public bilet_kes()
        {
            InitializeComponent();
            comboBox1.Text = "1";
            if (kombine == 1)
            {
                comboBox1.Visible = true;
                lbl_kombine.Visible = true;
            }
        }
        public static int OdemeDurumu = 0;
        public static int kombine = 0;
        public static string isim_table = "";
        public static int bilet_fiyat = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            kredi_kartı kart=new kredi_kartı();
            kart.Show();
            
        }
      
        public string Label1Text
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        private void odeme()
        {
            if (OdemeDurumu == 1)
            {
               Form1.GlobalDatabase.Conn.Open();

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        var cell = dataGridView1.Rows[i].Cells[j];
                        if (cell.Style.BackColor == Color.Blue) // Seçilenler
                        {
                            // Arayüzde sarı yap
                            cell.Style.BackColor = Color.Yellow;

                            // SQL'e kaydet
                            string satir = ((char)('A' + i)).ToString();
                            int sutun = j + 1;

                            string query = "UPDATE "+isim_table+" SET Durum = 1 WHERE Satir = @satir AND Sutun = @sutun";
                            MySqlCommand cmd = new MySqlCommand(query,Form1.GlobalDatabase.Conn);
                            cmd.Parameters.AddWithValue("@satir", satir);
                            cmd.Parameters.AddWithValue("@sutun", sutun);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                Form1.GlobalDatabase.Conn.Close();
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            int cost = bilet_fiyat; 
            int mac_sayisi = Convert.ToInt32(comboBox1.Text);

            var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Style.BackColor == Color.Green)
            {
                // Koltuk seçildi
                cell.Style.BackColor = Color.Blue;
            }
            else if (cell.Style.BackColor == Color.Blue)
            {
                // Koltuk tekrar seçildiyse vazgeçildi
                cell.Style.BackColor = Color.Green;
            }

            // Tüm seçilen koltukları say
            int secili_koltuk_sayisi = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell c in row.Cells)
                {
                    if (c.Style.BackColor == Color.Blue)
                    {
                        secili_koltuk_sayisi++;
                    }
                }
            }

            // Toplam ücret hesapla
            double toplam = secili_koltuk_sayisi * cost * mac_sayisi;

            if (mac_sayisi > 3)
            {
                toplam = toplam - (toplam * 0.10); // %10 indirim
            }

            label2.Text = toplam.ToString("0.00") + " -TL";
        }


        private void bilet_kes_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 10;  
            dataGridView1.ColumnCount = 10;  

            // Satır isimleri
            string[] satirlar = { "A", "B", "C", "D" ,"E","F","G","H","I","J"};
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = satirlar[i];
            }

            // Sütun isimleri
            for (int j = 0; j < 10; j++)
            {
                dataGridView1.Columns[j].HeaderText = (j + 1).ToString();
            }

            KoltuklariYukle();
        }
        private void KoltuklariYukle()
        {
            
            Form1.GlobalDatabase.Conn.Open();

            string query = "SELECT * FROM "+isim_table;
            MySqlCommand cmd = new MySqlCommand(query, Form1.GlobalDatabase.Conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string satir = reader["Satir"].ToString();  
                int sutun = Convert.ToInt32(reader["Sutun"]) - 1;
                int durum = Convert.ToInt32(reader["Durum"]);

                int rowIndex = satir[0] - 'A';

                if (durum == 1)
                {
                    dataGridView1.Rows[rowIndex].Cells[sutun].Style.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[rowIndex].Cells[sutun].Style.BackColor = Color.Green;
                }
            }

            reader.Close();
            Form1.GlobalDatabase.Conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odeme();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
