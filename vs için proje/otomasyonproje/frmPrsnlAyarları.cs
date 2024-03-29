using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otomasyonproje
{
    public partial class frmPrsnlAyarları : Form
    {
        private OleDbConnection baglanti;

        public frmPrsnlAyarları()
        {
            InitializeComponent();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb");
        }

        private void btnGörüntüle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string query = "SELECT * FROM Personeller";

                using (OleDbCommand command = new OleDbCommand(query, baglanti))
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Personeller");

                    listBox1.Items.Clear();
                    listBox1.Items.Add("AD--SOYAD--ADRES--TELEFON NUMARASI");
                    listBox1.Items.Add("                  ");
                    foreach (DataRow row in dataSet.Tables["Personeller"].Rows)
                    {
                        listBox1.Items.Add($"{row["AD"]}-{row["SOYAD"]}-{row["ADRES"]}-{row["TELEFON NUMARASI"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form frmPrsnlDuzenleme = new frmPrsnlDuzenleme();
            frmPrsnlDuzenleme.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrsnlEkle_Click(object sender, EventArgs e)
        {
            Form frmPrsnlEkle = new frmPrsnlEkle();
            frmPrsnlEkle.Show();
            this.Hide();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnPrsnlEkle_Click_1(object sender, EventArgs e)
        {
            Form frmPrsnlEkle = new frmPrsnlEkle();
            frmPrsnlEkle.Show();
            this.Hide();
        }

        private void btnPrsnlSil_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    using (OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb"))
                    {
                        baglanti.Open();

                        // Seçili personelin bilgilerini al
                        string[] personelBilgisi = listBox1.SelectedItem.ToString().Split('-');
                        string ad = personelBilgisi[0].Trim();
                        string soyad = personelBilgisi[1].Trim();
                        string adres = personelBilgisi[2].Trim(); // Örneğin 3. sıradaysa
                        string telefon = personelBilgisi[3].Trim(); // Örneğin 4. sıradaysa

                        string query = "DELETE FROM Personeller WHERE AD=@ad AND SOYAD=@soyad AND ADRES=@adres AND [TELEFON NUMARASI]=@telefon";

                        using (OleDbCommand command = new OleDbCommand(query, baglanti))
                        {
                            command.Parameters.AddWithValue("@ad", ad);
                            command.Parameters.AddWithValue("@soyad", soyad);
                            command.Parameters.AddWithValue("@adres", adres);
                            command.Parameters.AddWithValue("@telefon", telefon);
                            listBox1.Items.Add("AD--SOYAD--ADRES--TELEFON NUMARASI");
                            listBox1.Items.Add("                  ");
                            int affectedRows = command.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Personel başara s");
                                btnGörüntüle_Click(sender, e);
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
                    MessageBox.Show("Lütfen silmek istediğiniz personeli seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void frmPrsnlAyarları_Load(object sender, EventArgs e)
        {

        }
    }
}
