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
    public partial class frmMenuGoruntule : Form
    {
        public frmMenuGoruntule()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb");
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnUrunGoruntule_Click(object sender, EventArgs e)
        {
            try
            {
               
                baglanti.Open();

                string selectQuery = "SELECT URUNADI, FİYAT FROM urunler";
                using (OleDbCommand cmd = new OleDbCommand(selectQuery, baglanti))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        
                        lstbxUrun.Items.Clear();
                        lstbxUrun.Items.Add("URUNADI  --  FİYAT");
                        lstbxUrun.Items.Add("                  ");
                       
                        // Verileri ListBox'a ekle
                        while (reader.Read())
                        {
                            string urunAdi = reader["URUNADI"].ToString();
                            string fiyat = reader["FİYAT"].ToString();

                            lstbxUrun.Items.Add(urunAdi + "   -   " + fiyat + " TL");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürünleri görüntüleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Form frmUrunEkle = new frmUrunEkle();
            frmUrunEkle.Show();
            this.Hide();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstbxUrun.SelectedIndex >= 0)
                {
                    using (OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb"))
                    {
                        baglanti.Open();


                        string[] urunBilgisi = lstbxUrun.SelectedItem.ToString().Split('-');
                        string urunadı = urunBilgisi[0].Trim();
                        string fiyat = urunBilgisi[1].Trim();
                        fiyat = fiyat.Replace(" TL", "");

                        string query = "DELETE FROM urunler WHERE URUNADI=@urunadı AND FİYAT=@fiyat";

                        using (OleDbCommand command = new OleDbCommand(query, baglanti))
                        {
                          
                            command.Parameters.AddWithValue("@urunadı", urunadı);
                            command.Parameters.AddWithValue("@fiyat", fiyat);

                         
                            int affectedRows = command.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Ürün başarıyla silindi.");
                             
                                btnUrunGoruntule_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Silme işlemi başarısız.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz ürünü seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
