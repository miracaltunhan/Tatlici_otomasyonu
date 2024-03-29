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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otomasyonproje
{

    public partial class frmMasalar : Form
    {
        private int redGroupBoxCount = 0;
        
        public frmMasalar()
        {
            InitializeComponent();


            
            progressBar3.Minimum = 0;
            progressBar3.Maximum = 3;
            progressBar3.Value = 0;

          
            CheckSatislarTable("satislar", groupBox1, label6);
            CheckSatislarTable("satislar2", groupBox2, label4);
            CheckSatislarTable("satislar3", groupBox3, label3);

            // progressBar3'ü güncelle
            progressBar3.Value = redGroupBoxCount;

            
            this.Controls.Add(progressBar3);
        }

   

        private void CheckSatislarTable(string tableName, GroupBox groupBox, Label label)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand($"SELECT * FROM {tableName} WHERE durum=false", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();

            StringBuilder urunAdlari = new StringBuilder();

            while (okuyucu.Read())
            {
                string urunAdi = (string)okuyucu["URUNADI"];
                urunAdlari.AppendLine(urunAdi);
            }

            label.Text = urunAdlari.ToString();

            okuyucu.Close();
            baglanti.Close();

            groupBox.BackColor = (urunAdlari.Length > 0) ? Color.Red : Color.Green;

            // Eğer durumu "false" olan kayıt varsa redGroupBoxCount arttır
            if (urunAdlari.Length > 0)
            {
                redGroupBoxCount++;
            }
        



        // satislar tablosu için işlemler
        baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM satislar WHERE durum=false", baglanti);
            OleDbDataReader okuyucu1 = komut1.ExecuteReader();

            StringBuilder urunAdlari1 = new StringBuilder();

            while (okuyucu1.Read())
            {
                string urunAdi = (string)okuyucu1["URUNADI"];
                urunAdlari1.AppendLine(urunAdi);
            }

            label6.Text = urunAdlari1.ToString();

            okuyucu1.Close();
            baglanti.Close();
            groupBox1.BackColor = (urunAdlari1.Length > 0) ? Color.Red : Color.Green;

            // satislar2 tablosu için işlemler
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("SELECT * FROM satislar2 WHERE durum=false", baglanti);
            OleDbDataReader okuyucu2 = komut2.ExecuteReader();

            StringBuilder urunAdlari2 = new StringBuilder();

            while (okuyucu2.Read())
            {
                string urunAdi = (string)okuyucu2["URUNADI"];
                urunAdlari2.AppendLine(urunAdi);
            }

            label4.Text = urunAdlari2.ToString();

            okuyucu2.Close();
            baglanti.Close();
            groupBox2.BackColor = (urunAdlari2.Length > 0) ? Color.Red : Color.Green;

            baglanti.Open();
            OleDbCommand komut3 = new OleDbCommand("SELECT * FROM satislar3 WHERE durum=false", baglanti);
            OleDbDataReader okuyucu3 = komut3.ExecuteReader();

            StringBuilder urunAdlari3 = new StringBuilder();

            while (okuyucu3.Read())
            {
                string urunAdi = (string)okuyucu3["URUNADI"];
                urunAdlari3.AppendLine(urunAdi);
               
            }

            label3.Text = urunAdlari3.ToString();

            okuyucu3.Close();
            baglanti.Close();



            groupBox3.BackColor = (urunAdlari3.Length > 0) ? Color.Red : Color.Green;
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb");


            private void btnMasa1_Click(object sender, EventArgs e)
        {
            AyrıntılıSiparişFormunuAç2("Masa 1");
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            AyrıntılıSiparişFormunuAç2("Masa 2");


        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            AyrıntılıSiparişFormunuAç2("Masa 3");

        }
        private void AyrıntılıSiparişFormunuAç2(string masaAdi)
        {
            frmSiparis siparisFormu = new frmSiparis(masaAdi);
            this.Hide();
            siparisFormu.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }
    }
    }



