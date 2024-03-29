using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace otomasyonproje
{
    public partial class frmRapor : Form
    {
        private OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb");

        public frmRapor()
        {
            InitializeComponent();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                DateTime startDate = DateTime.Now.AddDays(-30);

                string satisQuery = "SELECT Fiyat FROM Satislar WHERE TARIH >= @StartDate UNION ALL " +
                                    "SELECT Fiyat FROM Satislar2 WHERE TARIH >= @StartDate UNION ALL " +
                                    "SELECT Fiyat FROM Satislar3 WHERE TARIH >= @StartDate";

                using (OleDbCommand satisCommand = new OleDbCommand(satisQuery, baglanti))
                {
                    satisCommand.Parameters.Add("@StartDate", OleDbType.Date).Value = startDate;

                    decimal toplamSatis = 0;

                    using (OleDbDataReader satisReader = satisCommand.ExecuteReader())
                    {
                        while (satisReader.Read())
                        {
                            if (decimal.TryParse(satisReader["Fiyat"].ToString(), out decimal fiyat))
                            {
                                toplamSatis += fiyat;
                            }
                        }
                    }

                    string personelQuery = "SELECT COUNT(*) AS PersonelSayisi FROM Personeller";
                    string masrafQuery = "SELECT SUM(MASRAF) AS ToplamMasraf FROM Masraflar";

                    using (OleDbCommand personelCommand = new OleDbCommand(personelQuery, baglanti))
                    using (OleDbCommand masrafCommand = new OleDbCommand(masrafQuery, baglanti))
                    {
                        int personelSayisi = Convert.ToInt32(personelCommand.ExecuteScalar());
                        decimal topMasraf = Convert.ToDecimal(masrafCommand.ExecuteScalar());

                        decimal toplamGider = personelSayisi * 20000 + topMasraf;
                        decimal toplamKar = toplamSatis - toplamGider;

                        listView1.Items.Clear();
                        listView1.Items.Add(new ListViewItem(new string[] { "Toplam Satış Miktarı", toplamSatis.ToString("C") }));
                        listView1.Items.Add(new ListViewItem(new string[] { "Toplam Gider", toplamGider.ToString("C") }));
                        listView1.Items.Add(new ListViewItem(new string[] { "Toplam Kar", toplamKar.ToString("C") }));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnGör_Click(object sender, EventArgs e)
        {

            double toplamNakitEvet = HesaplaToplam("satislar", "evet");
            double toplamNakitHayir = HesaplaToplam("satislar", "hayır");

            toplamNakitEvet += HesaplaToplam("satislar2", "evet");
            toplamNakitHayir += HesaplaToplam("satislar2", "hayır");

            toplamNakitEvet += HesaplaToplam("satislar3", "evet");
            toplamNakitHayir += HesaplaToplam("satislar3", "hayır");

            // Listbox'a sonuçları ekle
            listBox1.Items.Clear();
            listBox1.Items.Add($"Toplam Nakit : {toplamNakitEvet}");
            listBox1.Items.Add($"Toplam Kredi Kartı: {toplamNakitHayir}");
        }

        private double HesaplaToplam(string tableName, string durum)
        {
            double toplamFiyat = 0;

            try
            {
                baglanti.Open();

                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = baglanti;
                    command.CommandText = $"SELECT SUM(FİYAT) FROM {tableName} WHERE nakit = @Durum";
                    command.Parameters.AddWithValue("@Durum", durum);

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        toplamFiyat = Convert.ToDouble(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            finally
            {
                baglanti.Close();
            }

            return toplamFiyat;


        }
    }
}
