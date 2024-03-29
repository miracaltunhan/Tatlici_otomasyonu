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
    public partial class frmSiparis2 : Form
    {
        private string masaAdi;

        public frmSiparis2(string masaAdi)
        {
            InitializeComponent();
            this.masaAdi = masaAdi;

        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb");
       
        private void btnGörMenü_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string query = "SELECT * FROM urunler";
            OleDbCommand command = new OleDbCommand(query, baglanti);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["URUNADI"].ToString());
                item.SubItems.Add(reader["FİYAT"].ToString());
                listView1.Items.Add(item);
            }
            baglanti.Close();
        }

      

     
        private void AyrıntılıSiparişFormunuAç2(string masaAdi)
        {
            frmÖdeme frmÖdeme = new frmÖdeme(masaAdi);

            frmÖdeme.Show();
        }

        private void btnMasaKapat_Click_1(object sender, EventArgs e)
        {

            if (masaAdi == "Masa 1")
            {
                AyrıntılıSiparişFormunuAç2("Masa 1");
            }
            if (masaAdi == "Masa 2")
            {
                AyrıntılıSiparişFormunuAç2("Masa 2");
            }
            if (masaAdi == "Masa 3")
            {
                AyrıntılıSiparişFormunuAç2("Masa 3");
            }
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Masa Siparişi Tamamlamdı");
            if (masaAdi == "Masa 1")
            {

                baglanti.Open();

                foreach (ListViewItem item in listView2.Items)
                {
                    string urunAdi = item.SubItems[0].Text;
                    string fiyat = item.SubItems[1].Text;

                    // Tarihi al
                    DateTime tarih = DateTime.Now;

                    OleDbCommand command = new OleDbCommand("INSERT INTO satislar (URUNADI, FİYAT, TARIH) VALUES (@UrunAdi, @Fiyat, @Tarih)", baglanti);

                    command.Parameters.AddWithValue("@UrunAdi", urunAdi);
                    command.Parameters.AddWithValue("@Fiyat", fiyat);

                    // Tarih parametresini ekleyin ve uygun veri tipini belirtin
                    command.Parameters.Add("@Tarih", OleDbType.Date).Value = tarih;

                    command.ExecuteNonQuery();
                }

                baglanti.Close();

            }


            else if (masaAdi == "Masa 2")
            {

                baglanti.Open();

                foreach (ListViewItem item in listView2.Items)
                {
                    string urunAdi = item.SubItems[0].Text;
                    string fiyat = item.SubItems[1].Text;

                    // Tarihi al
                    DateTime tarih = DateTime.Now;

                    OleDbCommand command = new OleDbCommand("INSERT INTO satislar2 (URUNADI, FİYAT, TARIH) VALUES (@UrunAdi, @Fiyat, @Tarih)", baglanti);

                    command.Parameters.AddWithValue("@UrunAdi", urunAdi);
                    command.Parameters.AddWithValue("@Fiyat", fiyat);

                    // Tarih parametresini ekleyin ve uygun veri tipini belirtin
                    command.Parameters.Add("@Tarih", OleDbType.Date).Value = tarih;

                    command.ExecuteNonQuery();
                }

                baglanti.Close();

            }




            else if (masaAdi == "Masa 3")
            {

                baglanti.Open();

                foreach (ListViewItem item in listView2.Items)
                {
                    string urunAdi = item.SubItems[0].Text;
                    string fiyat = item.SubItems[1].Text;

                    // Tarihi al
                    DateTime tarih = DateTime.Now;

                    OleDbCommand command = new OleDbCommand("INSERT INTO satislar3 (URUNADI, FİYAT, TARIH) VALUES (@UrunAdi, @Fiyat, @Tarih)", baglanti);

                    command.Parameters.AddWithValue("@UrunAdi", urunAdi);
                    command.Parameters.AddWithValue("@Fiyat", fiyat);

                    // Tarih parametresini ekleyin ve uygun veri tipini belirtin
                    command.Parameters.Add("@Tarih", OleDbType.Date).Value = tarih;

                    command.ExecuteNonQuery();
                }

                baglanti.Close();
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selected = listView1.SelectedItems[0];


                string urunAdi = selected.SubItems[0].Text;
                string fiyat = selected.SubItems[1].Text;


                ListViewItem newItem = new ListViewItem(urunAdi);
                newItem.SubItems.Add(fiyat);

                listView2.Items.Add(newItem);
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form frmMenu2 = new frmMenu2();
            frmMenu2.Show();
            this.Hide();
        }

        /* 
         */
    }
}

