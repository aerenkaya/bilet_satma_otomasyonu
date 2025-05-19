using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projemmmmmmmmmmm
{
    public partial class SatılanBilet : Form
    {
        DataGridView dataGridView1;

        public SatılanBilet()
        {
            InitializeComponent();
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView1);
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Tribün";
            dataGridView1.Columns[1].Name = "Satılan Bilet";
            dataGridView1.Columns[2].Name = "Doluluk (%)";
            this.Load += SatılanBilet_Load;
        }

        private void SatılanBilet_Load(object sender, EventArgs e)
        {
            VerileriGetirVeGoster();
        }

        private void VerileriGetirVeGoster()
        {
            Dictionary<string, int> kapasiteler = new Dictionary<string, int>()
            {
                { "koltuklar", 100 },
                { "kale_arkasi1", 100 },
                { "kale_arkasi2", 100 },
                { "kapali", 100 },
                { "misafir", 50 }
            };

            Dictionary<string, string> isimler = new Dictionary<string, string>()
            {
                { "koltuklar", "Maraton" },
                { "kale_arkasi1", "Kale Arkası 1" },
                { "kale_arkasi2", "Kale Arkası 2" },
                { "kapali", "Kapalı" },
                { "misafir", "Misafir" }
            };

            dataGridView1.Rows.Clear();

            try
            {
                Form1.GlobalDatabase.Conn.Open();

                foreach (var tribun in kapasiteler.Keys)
                {
                    string sql = $"SELECT COUNT(*) FROM {tribun} WHERE durum = 1";
                    MySqlCommand cmd = new MySqlCommand(sql, Form1.GlobalDatabase.Conn);
                    int satilan = Convert.ToInt32(cmd.ExecuteScalar());

                    int kapasite = kapasiteler[tribun];
                    double doluluk = (double)satilan / kapasite * 100;

                    dataGridView1.Rows.Add(isimler[tribun], satilan, doluluk.ToString("F2") + "%");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                Form1.GlobalDatabase.Conn.Close();
            }
        }
    }
}
