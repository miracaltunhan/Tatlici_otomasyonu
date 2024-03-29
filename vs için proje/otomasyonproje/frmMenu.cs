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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            Form frmMasalar = new frmMasalar();
            frmMasalar.Show();
            this.Hide();

        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            Form frmPrsnlDüzenleme = new frmPrsnlDuzenleme();
            frmPrsnlDüzenleme.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form frmMenuGoruntule = new frmMenuGoruntule();
            frmMenuGoruntule.Show();
            this.Hide();
        }

        private void btnPersoneller_Click_1(object sender, EventArgs e)
        {
            Form frmPrsnlDuzenleme = new frmPrsnlDuzenleme();
            frmPrsnlDuzenleme.Show();
            this.Hide();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            Form frmMenuGoruntule = new frmMenuGoruntule();
            frmMenuGoruntule.Show();
            this.Hide();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Form frmRapor = new frmRapor();
            frmRapor.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmGider = new frmGider();
            frmGider.Show();
            this.Hide();
        }
    }
}
