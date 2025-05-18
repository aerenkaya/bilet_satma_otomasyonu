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
    public partial class FiyatListesiForm : Form
    {
        public FiyatListesiForm()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FiyatListesiForm_Load(object sender, EventArgs e)
        {
            Form1.GlobalDatabase.Conn.Open();
            string sql = "SELECT * FROM fiyatlar";
            MySqlCommand komut = new MySqlCommand(sql, Form1.GlobalDatabase.Conn);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label2.Text += dr["maraton"].ToString();
                label3.Text += dr["kapali"].ToString();
                label4.Text += dr["kale1"].ToString();
                label5.Text += dr["kale2"].ToString();
                label6.Text += dr["misafir"].ToString();

            }
            Form1.GlobalDatabase.Conn.Close();
            for (int i = 2; i < 7; i++)
            {
                Label lbl = this.Controls["label" + i] as Label;
                if (lbl != null)
                {
                    lbl.Text += " TL";
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
