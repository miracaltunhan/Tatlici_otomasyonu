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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace otomasyonproje
{
    public partial class frmÖdeme : Form
    {
        private string masaAdi;
        public frmÖdeme(string masaAdi)
        {
            InitializeComponent();
            this.masaAdi = masaAdi;
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb");
        private void btnÖdeme_Click(object sender, EventArgs e)
        {

            if (masaAdi == "Masa 1")
            {

                listView1.Items.Clear();

                // SQL sorgusu ile "durum" alanı "hayır" olan kayıtları getir
                string Query = "SELECT URUNADI, FİYAT FROM satislar WHERE durum = false";
                OleDbCommand command = new OleDbCommand(Query, baglanti);

                // Bağlantıyı aç
                baglanti.Open();

                OleDbDataReader reader = command.ExecuteReader();

                double toplamFiyat = 0.0;

                // Her bir kayıt için ListView'e eklenir
                while (reader.Read())
                {
                    string urunAdi = reader["URUNADI"].ToString();
                    string fiyat = reader["FİYAT"].ToString();

                    double fiyatDouble;
                    if (double.TryParse(fiyat, out fiyatDouble))
                    {
                        toplamFiyat += fiyatDouble;
                    }

                    ListViewItem item = new ListViewItem(urunAdi);
                    item.SubItems.Add(fiyat);

                    listView1.Items.Add(item);
                }

                // Toplam fiyatı gösteren bir ekstra satır ekleyin
                ListViewItem toplamItem = new ListViewItem("Toplam Fiyat");
                toplamItem.SubItems.Add(toplamFiyat.ToString());
                listView1.Items.Add(toplamItem);

                // Okuma ve bağlantı kapatılır
                reader.Close();
                baglanti.Close();
            }
            if (masaAdi == "Masa 2")
            {
                listView1.Items.Clear();

                // SQL sorgusu ile "durum" alanı "hayır" olan kayıtları getir
                string Query = "SELECT URUNADI, FİYAT FROM satislar2 WHERE durum = false";
                OleDbCommand command = new OleDbCommand(Query, baglanti);

                // Bağlantıyı aç
                baglanti.Open();

                OleDbDataReader reader = command.ExecuteReader();

                double toplamFiyat = 0.0;

                // Her bir kayıt için ListView'e eklenir
                while (reader.Read())
                {
                    string urunAdi = reader["URUNADI"].ToString();
                    string fiyat = reader["FİYAT"].ToString();

                    double fiyatDouble;
                    if (double.TryParse(fiyat, out fiyatDouble))
                    {
                        toplamFiyat += fiyatDouble;
                    }

                    ListViewItem item = new ListViewItem(urunAdi);
                    item.SubItems.Add(fiyat);

                    listView1.Items.Add(item);
                }

                // Toplam fiyatı gösteren bir ekstra satır ekleyin
                ListViewItem toplamItem = new ListViewItem("Toplam Fiyat");
                toplamItem.SubItems.Add(toplamFiyat.ToString());
                listView1.Items.Add(toplamItem);

                // Okuma ve bağlantı kapatılır
                reader.Close();
                baglanti.Close();

            }
            if (masaAdi == "Masa 3")
            {
                listView1.Items.Clear();

                // SQL sorgusu ile "durum" alanı "hayır" olan kayıtları getir
                string Query = "SELECT URUNADI, FİYAT FROM satislar3 WHERE durum = false";
                OleDbCommand command = new OleDbCommand(Query, baglanti);

                // Bağlantıyı aç
                baglanti.Open();

                OleDbDataReader reader = command.ExecuteReader();

                double toplamFiyat = 0.0;

                // Her bir kayıt için ListView'e eklenir
                while (reader.Read())
                {
                    string urunAdi = reader["URUNADI"].ToString();
                    string fiyat = reader["FİYAT"].ToString();

                    double fiyatDouble;
                    if (double.TryParse(fiyat, out fiyatDouble))
                    {
                        toplamFiyat += fiyatDouble;
                    }

                    ListViewItem item = new ListViewItem(urunAdi);
                    item.SubItems.Add(fiyat);

                    listView1.Items.Add(item);
                }

                // Toplam fiyatı gösteren bir ekstra satır ekleyin
                ListViewItem toplamItem = new ListViewItem("Toplam Fiyat");
                toplamItem.SubItems.Add(toplamFiyat.ToString());
                listView1.Items.Add(toplamItem);

                // Okuma ve bağlantı kapatılır
                reader.Close();
                baglanti.Close();

            }
        }

        private void btnÖdemeAlındı_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ÜCRET ÖDENDİ");
            if (masaAdi == "Masa 1")
            {
                try
                {

                    baglanti.Open();


                    string tableName = "satislar";
                    string durumKolonu = "durum";


                    string sqlQuery = "UPDATE " + tableName + " SET " + durumKolonu + "=? WHERE " + durumKolonu + "=No";


                    using (OleDbCommand command = new OleDbCommand(sqlQuery, baglanti))
                    {

                        command.Parameters.AddWithValue("@YeniDurum", true);


                        int affectedRows = command.ExecuteNonQuery();


                        Console.WriteLine(affectedRows + " satır güncellendi.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
            if (masaAdi == "Masa 2")
            {
                try
                {

                    baglanti.Open();

                    string tableName = "satislar2";
                    string durumKolonu = "durum";

                    string sqlQuery = "UPDATE " + tableName + " SET " + durumKolonu + "=? WHERE " + durumKolonu + "=No";


                    using (OleDbCommand command = new OleDbCommand(sqlQuery, baglanti))
                    {
                        command.Parameters.AddWithValue("@YeniDurum", true);


                        int affectedRows = command.ExecuteNonQuery();


                        Console.WriteLine(affectedRows + " satır güncellendi.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
            if (masaAdi == "Masa 3")
            {
                try
                {

                    baglanti.Open();

                    string tableName = "satislar3";
                    string durumKolonu = "durum";


                    string sqlQuery = "UPDATE " + tableName + " SET " + durumKolonu + "=? WHERE " + durumKolonu + "=No";


                    using (OleDbCommand command = new OleDbCommand(sqlQuery, baglanti))
                    {

                        command.Parameters.AddWithValue("@YeniDurum", true);


                        int affectedRows = command.ExecuteNonQuery();



                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
            this.Hide();
        }

        private void checkBoxNKT_CheckedChanged(object sender, EventArgs e)
        {
            if (masaAdi == "Masa 1")
            {
                if (checkBoxNKT.Checked)
                {
                    try
                    {

                        {
                            baglanti.Open();

                            string updateQuery = "UPDATE satislar SET nakit = 'evet' WHERE durum = false AND nakit IS NULL";


                            using (OleDbCommand command = new OleDbCommand(updateQuery, baglanti))
                            {
                                int rowsAffected = command.ExecuteNonQuery();


                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                baglanti.Close();
            }

            else if (masaAdi == "Masa 2")
            {
                if (checkBoxNKT.Checked)
                {
                    try
                    {

                        {
                            baglanti.Open();

                            string updateQuery = "UPDATE satislar2 SET nakit = 'evet' WHERE durum = false AND nakit IS NULL";


                            using (OleDbCommand command = new OleDbCommand(updateQuery, baglanti))
                            {
                                int rowsAffected = command.ExecuteNonQuery();


                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                baglanti.Close();
            }
               else if (masaAdi == "Masa 3")
                {
                    if (checkBoxNKT.Checked)
                    {
                        try
                        {

                            {
                                baglanti.Open();

                                string updateQuery = "UPDATE satislar3 SET nakit = 'evet' WHERE durum = false AND nakit IS NULL";


                                using (OleDbCommand command = new OleDbCommand(updateQuery, baglanti))
                                {
                                    int rowsAffected = command.ExecuteNonQuery();


                                }
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    baglanti.Close();

                }
            }

        private void checkBoxPOS_CheckedChanged(object sender, EventArgs e)
        {
            if (masaAdi == "Masa 1")
            {
                if (checkBoxPOS.Checked)
                {
                    try
                    {

                        {
                            baglanti.Open();

                            string updateQuery = "UPDATE satislar SET nakit = 'hayır' WHERE durum = false AND nakit IS NULL";


                            using (OleDbCommand command = new OleDbCommand(updateQuery, baglanti))
                            {
                                int rowsAffected = command.ExecuteNonQuery();


                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                baglanti.Close();
            }

            else if (masaAdi == "Masa 2")
            {
                if (checkBoxPOS.Checked)
                {
                    try
                    {

                        {
                            baglanti.Open();

                            string updateQuery = "UPDATE satislar2 SET nakit = 'hayır' WHERE durum = false AND nakit IS NULL";


                            using (OleDbCommand command = new OleDbCommand(updateQuery, baglanti))
                            {
                                int rowsAffected = command.ExecuteNonQuery();


                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                baglanti.Close();
            }
            else if (masaAdi == "Masa 3")
            {
                if (checkBoxPOS.Checked)
                {
                    try
                    {

                        {
                            baglanti.Open();

                            string updateQuery = "UPDATE satislar3 SET nakit = 'hayır' WHERE durum = false AND nakit IS NULL";


                            using (OleDbCommand command = new OleDbCommand(updateQuery, baglanti))
                            {
                                int rowsAffected = command.ExecuteNonQuery();


                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                baglanti.Close();

            }
        }
    }
        }
    
    

