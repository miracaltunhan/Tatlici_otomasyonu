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
    public partial class frmPrsnlEkle : Form
    {
        public frmPrsnlEkle()
        {
            InitializeComponent();

        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb");

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form frmPrsnlDuzenleme = new frmPrsnlDuzenleme();
            frmPrsnlDuzenleme.Show();
            this.Hide();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Form frmPrsnlAyarları = new frmPrsnlAyarları();
            frmPrsnlAyarları.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text)) 
            {
                MessageBox.Show("Lütfen ad ve soyad bilgilerini giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
               
                baglanti.Open();

                
                string insertQuery = "INSERT INTO Personeller (AD, SOYAD,ADRES,[TELEFON NUMARASI]) VALUES (@ad, @soyad,@adres,@telefonno)";
                using (OleDbCommand cmd = new OleDbCommand(insertQuery, baglanti))
                {
                  
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@adres", txtadres.Text);
                    cmd.Parameters.AddWithValue("@telefonno", txttelefon.Text);
                  
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
                txtAd.Clear();
                txtSoyad.Clear();
                txtadres.Clear();
                txttelefon.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                baglanti.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmPrsnlEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
