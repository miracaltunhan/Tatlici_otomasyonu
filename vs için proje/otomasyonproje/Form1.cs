using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Policy;

namespace otomasyonproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb");


        private void verilerigoruntule()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool kayitlimi = false;
            Form frmMenu = new frmMenu();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From mudur");//tabloyu çekme
            OleDbDataReader oku = komut.ExecuteReader();//tabloyu okuma

            while (oku.Read())
            {
                if (txtKullanici.Text == oku["AD"].ToString() && txtSifre.Text == oku["PAROLA"].ToString())
                {
                    kayitlimi = true;
                    break;  // exit the loop when a match is found
                }
            }

            baglanti.Close();

            if (kayitlimi)
            {
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }

        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifre frmSifre = new frmSifre();
            frmSifre.Show();
            this.Hide();

        }
    }
}