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
    public partial class frmGider : Form
    {
        public frmGider()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Veritabanına ekleme işlemi için SQL sorgusunu oluştur
                string insertQuery = "INSERT INTO masraflar (DURUM, MASRAF, TARIH) VALUES (@durum, @masraf, @tarih)";

                // Parametre değerlerini belirle
                OleDbParameter paramDurum = new OleDbParameter("@durum", OleDbType.VarChar);
                paramDurum.Value = txtDurum.Text;

                OleDbParameter paramMasraf = new OleDbParameter("@masraf", OleDbType.VarChar);
                paramMasraf.Value = txtMasraf.Text;

                OleDbParameter paramTarih = new OleDbParameter("@tarih", OleDbType.Date);
                paramTarih.Value = DateTime.Now;

                // Sorguyu çalıştır
                OleDbCommand command = new OleDbCommand(insertQuery, baglanti);
                command.Parameters.Add(paramDurum);
                command.Parameters.Add(paramMasraf);
                command.Parameters.Add(paramTarih);
                command.ExecuteNonQuery();

                MessageBox.Show("Veriler başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); // Önceki verileri temizle

            try
            {
                baglanti.Open();

                string selectQuery = "SELECT DURUM, MASRAF, TARIH FROM masraflar";

                OleDbCommand command = new OleDbCommand(selectQuery, baglanti);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["DURUM"].ToString());
                    item.SubItems.Add(reader["MASRAF"].ToString());
                    item.SubItems.Add(reader["TARIH"].ToString());

                    listView1.Items.Add(item);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
