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
    public partial class frmSifre : Form
    {
        public frmSifre()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\Database9.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // TELEFON NUMARASI ile eşleşen personeli bul
                string telefonNo = txtNo.Text;
                string sorgu = "SELECT * FROM mudur WHERE TCKIMLIK = @TelefonNo";
                using (OleDbCommand command = new OleDbCommand(sorgu, baglanti))
                {
                    command.Parameters.AddWithValue("@TelefonNo", telefonNo);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Personel bulundu, PAROLA bilgisini güncelle
                            string yeniSifre = txtSifre.Text;

                            // PAROLA bilgisini güncelle
                            string updateSorgu = "UPDATE mudur SET PAROLA = @YeniSifre WHERE TCKIMLIK = @TelefonNo";
                            using (OleDbCommand updateCommand = new OleDbCommand(updateSorgu, baglanti))
                            {
                                updateCommand.Parameters.AddWithValue("@YeniSifre", yeniSifre);
                                updateCommand.Parameters.AddWithValue("@TelefonNo", telefonNo);

                                int affectedRows = updateCommand.ExecuteNonQuery();
                                if (affectedRows > 0)
                                {
                                    MessageBox.Show("Parola başarıyla güncellendi.");
                                }
                                else
                                {
                                    MessageBox.Show("Parola güncellenirken bir hata oluştu.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen TC KİMLİK NUMARASI ile eşleşen Müdür bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
    }

