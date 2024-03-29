using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyonproje
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool kayitlimi = false;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From personeller");//tabloyu çekme
            OleDbDataReader oku = komut.ExecuteReader();//tabloyu okuma

            while (oku.Read())
            {
                if (txtKullanici.Text == oku["AD"].ToString())
                {
                    kayitlimi = true;
                    break;  
                }
            }

            baglanti.Close();

            if (kayitlimi)
            {
                frmMenu2 frmMenu2 = new frmMenu2();
                frmMenu2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı yanlış");
            }
        }
    }
}
