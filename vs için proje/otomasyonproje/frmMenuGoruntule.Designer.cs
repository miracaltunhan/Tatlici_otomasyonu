namespace otomasyonproje
{
    partial class frmMenuGoruntule
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUrunGoruntule = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.lstbxUrun = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::otomasyonproje.Properties.Resources.geri_gel;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(1390, 95);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 56);
            this.btnCikis.TabIndex = 18;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnUrunGoruntule
            // 
            this.btnUrunGoruntule.BackColor = System.Drawing.Color.White;
            this.btnUrunGoruntule.Location = new System.Drawing.Point(1265, 189);
            this.btnUrunGoruntule.Name = "btnUrunGoruntule";
            this.btnUrunGoruntule.Size = new System.Drawing.Size(168, 62);
            this.btnUrunGoruntule.TabIndex = 17;
            this.btnUrunGoruntule.Text = "Görüntüle";
            this.btnUrunGoruntule.UseVisualStyleBackColor = false;
            this.btnUrunGoruntule.Click += new System.EventHandler(this.btnUrunGoruntule_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.White;
            this.btnUrunSil.Location = new System.Drawing.Point(1265, 367);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(168, 73);
            this.btnUrunSil.TabIndex = 16;
            this.btnUrunSil.Text = "Ürünü Sil";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.White;
            this.btnUrunEkle.Location = new System.Drawing.Point(1265, 276);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(168, 67);
            this.btnUrunEkle.TabIndex = 15;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // lstbxUrun
            // 
            this.lstbxUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbxUrun.FormattingEnabled = true;
            this.lstbxUrun.ItemHeight = 36;
            this.lstbxUrun.Items.AddRange(new object[] {
            "Ürün Adı     Fiyat"});
            this.lstbxUrun.Location = new System.Drawing.Point(204, 125);
            this.lstbxUrun.Name = "lstbxUrun";
            this.lstbxUrun.Size = new System.Drawing.Size(988, 616);
            this.lstbxUrun.TabIndex = 14;
            // 
            // frmMenuGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::otomasyonproje.Properties.Resources.gazi_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1393, 816);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnUrunGoruntule);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.lstbxUrun);
            this.Name = "frmMenuGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuGoruntule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnUrunGoruntule;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ListBox lstbxUrun;
    }
}