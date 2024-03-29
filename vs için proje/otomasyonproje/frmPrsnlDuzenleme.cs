using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyonproje
{
    public partial class frmPrsnlDuzenleme : Form
    {
        public frmPrsnlDuzenleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmPrsnlGörüntüle = new formPrsnlGörüntüle();
            frmPrsnlGörüntüle.Show();
            this.Hide();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmPrsnlAyarları = new frmPrsnlAyarları();
            frmPrsnlAyarları.Show();
            this.Hide();
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void prsnlGörüntüle_Click(object sender, EventArgs e)
        {
            Form formPrsnlGörüntüle = new formPrsnlGörüntüle();
            formPrsnlGörüntüle.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form frmPrsnlAyarları = new frmPrsnlAyarları();
            frmPrsnlAyarları.Show();
            this.Hide();
        }
    }
}

