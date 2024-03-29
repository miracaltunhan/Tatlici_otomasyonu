namespace otomasyonproje
{
    partial class frmÖdeme2
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
            this.checkBoxPOS = new System.Windows.Forms.CheckBox();
            this.checkBoxNKT = new System.Windows.Forms.CheckBox();
            this.btnÖdemeAlındı = new System.Windows.Forms.Button();
            this.btnÖdeme = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ÜRÜNLER = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // checkBoxPOS
            // 
            this.checkBoxPOS.AutoSize = true;
            this.checkBoxPOS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxPOS.Location = new System.Drawing.Point(981, 217);
            this.checkBoxPOS.Name = "checkBoxPOS";
            this.checkBoxPOS.Size = new System.Drawing.Size(155, 26);
            this.checkBoxPOS.TabIndex = 9;
            this.checkBoxPOS.Text = "KREDİ KARTI";
            this.checkBoxPOS.UseVisualStyleBackColor = false;
            // 
            // checkBoxNKT
            // 
            this.checkBoxNKT.AutoSize = true;
            this.checkBoxNKT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxNKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxNKT.Location = new System.Drawing.Point(821, 217);
            this.checkBoxNKT.Name = "checkBoxNKT";
            this.checkBoxNKT.Size = new System.Drawing.Size(90, 26);
            this.checkBoxNKT.TabIndex = 8;
            this.checkBoxNKT.Text = "NAKİT";
            this.checkBoxNKT.UseVisualStyleBackColor = false;
            // 
            // btnÖdemeAlındı
            // 
            this.btnÖdemeAlındı.BackColor = System.Drawing.Color.White;
            this.btnÖdemeAlındı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÖdemeAlındı.Location = new System.Drawing.Point(885, 281);
            this.btnÖdemeAlındı.Name = "btnÖdemeAlındı";
            this.btnÖdemeAlındı.Size = new System.Drawing.Size(251, 102);
            this.btnÖdemeAlındı.TabIndex = 7;
            this.btnÖdemeAlındı.Text = "Ödeme Alındı";
            this.btnÖdemeAlındı.UseVisualStyleBackColor = false;
            // 
            // btnÖdeme
            // 
            this.btnÖdeme.BackColor = System.Drawing.Color.White;
            this.btnÖdeme.Location = new System.Drawing.Point(390, 60);
            this.btnÖdeme.Name = "btnÖdeme";
            this.btnÖdeme.Size = new System.Drawing.Size(130, 41);
            this.btnÖdeme.TabIndex = 6;
            this.btnÖdeme.Text = "GÖRÜNTÜLE";
            this.btnÖdeme.UseVisualStyleBackColor = false;
            this.btnÖdeme.Click += new System.EventHandler(this.btnÖdeme_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ÜRÜNLER,
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(121, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(625, 531);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ÜRÜNLER
            // 
            this.ÜRÜNLER.Text = "ÜRÜNLER";
            this.ÜRÜNLER.Width = 276;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FİYAT";
            this.columnHeader1.Width = 332;
            // 
            // frmÖdeme2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::otomasyonproje.Properties.Resources.gazi_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1256, 716);
            this.Controls.Add(this.checkBoxPOS);
            this.Controls.Add(this.checkBoxNKT);
            this.Controls.Add(this.btnÖdemeAlındı);
            this.Controls.Add(this.btnÖdeme);
            this.Controls.Add(this.listView1);
            this.Name = "frmÖdeme2";
            this.Text = "frmÖdeme2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPOS;
        private System.Windows.Forms.CheckBox checkBoxNKT;
        private System.Windows.Forms.Button btnÖdemeAlındı;
        private System.Windows.Forms.Button btnÖdeme;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ÜRÜNLER;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}