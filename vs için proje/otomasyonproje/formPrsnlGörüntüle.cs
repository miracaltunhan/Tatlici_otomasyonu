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
    public partial class formPrsnlGörüntüle : Form
    {
        public formPrsnlGörüntüle()
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
                        listBox1.Items.Add($"{row["AD"]}--{row["SOYAD"]}--{row["ADRES"]}--{row["TELEFON NUMARASI"]}");
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Form frmPrsnlDuzenleme = new frmPrsnlDuzenleme();
            frmPrsnlDuzenleme.Show();
            this.Hide();
        }
    }
}

