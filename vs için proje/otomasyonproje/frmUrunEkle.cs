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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb");
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form frmMenuGoruntule = new frmMenuGoruntule();
            frmMenuGoruntule.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen ürün adı ve fiyatı bilgilerini giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                baglanti.Open();

                string insertQuery = "INSERT INTO urunler (URUNADI, FİYAT) VALUES (@urunadı, @fiyat)";
                using (OleDbCommand cmd = new OleDbCommand(insertQuery, baglanti))
                {
                   
                    cmd.Parameters.AddWithValue("@urunadı", txtAd.Text);
                    cmd.Parameters.AddWithValue("@fiyat", txtSoyad.Text);

                    
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
                txtAd.Clear();
                txtSoyad.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
           
                baglanti.Close();
            }
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
