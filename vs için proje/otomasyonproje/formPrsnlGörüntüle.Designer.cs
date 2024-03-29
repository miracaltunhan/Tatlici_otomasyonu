namespace otomasyonproje
{
    partial class formPrsnlGörüntüle
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGörüntüle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.White;
            this.btnCikis.BackgroundImage = global::otomasyonproje.Properties.Resources.geri_gel;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(1185, 130);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 56);
            this.btnCikis.TabIndex = 12;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Items.AddRange(new object[] {
            "AD      SOYAD     ADRES    TELEFON NO       "});
            this.listBox1.Location = new System.Drawing.Point(354, 371);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(799, 468);
            this.listBox1.TabIndex = 11;
            // 
            // btnGörüntüle
            // 
            this.btnGörüntüle.BackColor = System.Drawing.Color.White;
            this.btnGörüntüle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGörüntüle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGörüntüle.Location = new System.Drawing.Point(881, 305);
            this.btnGörüntüle.Name = "btnGörüntüle";
            this.btnGörüntüle.Size = new System.Drawing.Size(257, 60);
            this.btnGörüntüle.TabIndex = 10;
            this.btnGörüntüle.Text = "Görüntüle";
            this.btnGörüntüle.UseVisualStyleBackColor = false;
            this.btnGörüntüle.Click += new System.EventHandler(this.btnGörüntüle_Click);
            // 
            // formPrsnlGörüntüle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::otomasyonproje.Properties.Resources.gazi_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1351, 899);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGörüntüle);
            this.Name = "formPrsnlGörüntüle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPrsnlGörüntüle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGörüntüle;
    }
}