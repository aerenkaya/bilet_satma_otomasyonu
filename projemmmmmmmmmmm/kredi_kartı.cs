using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projemmmmmmmmmmm
{
    public partial class kredi_kartı : Form
    {
        public kredi_kartı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bilet_kes.OdemeDurumu = 1;
            this.Close();
        }
    }
}
