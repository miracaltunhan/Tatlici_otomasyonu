namespace otomasyonproje
{
    partial class frmPrsnlAyarları
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrsnlEkle = new System.Windows.Forms.Button();
            this.btnPrsnlSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGörüntüle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrsnlEkle
            // 
            this.btnPrsnlEkle.BackColor = System.Drawing.Color.White;
            this.btnPrsnlEkle.Location = new System.Drawing.Point(1080, 349);
            this.btnPrsnlEkle.Name = "btnPrsnlEkle";
            this.btnPrsnlEkle.Size = new System.Drawing.Size(296, 66);
            this.btnPrsnlEkle.TabIndex = 19;
            this.btnPrsnlEkle.Text = "Personel Ekle";
            this.btnPrsnlEkle.UseVisualStyleBackColor = false;
            this.btnPrsnlEkle.Click += new System.EventHandler(this.btnPrsnlEkle_Click_1);
            // 
            // btnPrsnlSil
            // 
            this.btnPrsnlSil.BackColor = System.Drawing.Color.White;
            this.btnPrsnlSil.Location = new System.Drawing.Point(1080, 269);
            this.btnPrsnlSil.Name = "btnPrsnlSil";
            this.btnPrsnlSil.Size = new System.Drawing.Size(296, 66);
            this.btnPrsnlSil.TabIndex = 18;
            this.btnPrsnlSil.Text = "Personeli Sil";
            this.btnPrsnlSil.UseVisualStyleBackColor = false;
            this.btnPrsnlSil.Click += new System.EventHandler(this.btnPrsnlSil_Click_1);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::otomasyonproje.Properties.Resources.geri_gel;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(1173, 89);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 56);
            this.btnCikis.TabIndex = 17;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Items.AddRange(new object[] {
            "AD      SOYAD     ADRES    TELEFON NO       "});
            this.listBox1.Location = new System.Drawing.Point(247, 271);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(785, 381);
            this.listBox1.TabIndex = 16;
            // 
            // btnGörüntüle
            // 
            this.btnGörüntüle.BackColor = System.Drawing.Color.Azure;
            this.btnGörüntüle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGörüntüle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGörüntüle.Location = new System.Drawing.Point(569, 201);
            this.btnGörüntüle.Name = "btnGörüntüle";
            this.btnGörüntüle.Size = new System.Drawing.Size(363, 53);
            this.btnGörüntüle.TabIndex = 15;
            this.btnGörüntüle.Text = "Görüntüle";
            this.btnGörüntüle.UseVisualStyleBackColor = false;
            this.btnGörüntüle.Click += new System.EventHandler(this.btnGörüntüle_Click);
            // 
            // frmPrsnlAyarları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::otomasyonproje.Properties.Resources.gazi_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1388, 698);
            this.Controls.Add(this.btnPrsnlEkle);
            this.Controls.Add(this.btnPrsnlSil);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGörüntüle);
            this.Name = "frmPrsnlAyarları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrsnlAyarları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrsnlAyarları_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrsnlEkle;
        private System.Windows.Forms.Button btnPrsnlSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGörüntüle;
    }
}