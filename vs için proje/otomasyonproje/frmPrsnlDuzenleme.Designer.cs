using System;

namespace otomasyonproje
{
    partial class frmPrsnlDuzenleme
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
            this.button2 = new System.Windows.Forms.Button();
            this.prsnlGörüntüle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::otomasyonproje.Properties.Resources.geri_gel;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(1097, 139);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 56);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::otomasyonproje.Properties.Resources.personel_setting;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(625, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(403, 375);
            this.button2.TabIndex = 12;
            this.button2.Text = "Personel Düzenleme";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // prsnlGörüntüle
            // 
            this.prsnlGörüntüle.BackgroundImage = global::otomasyonproje.Properties.Resources.çalışanlar;
            this.prsnlGörüntüle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prsnlGörüntüle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.prsnlGörüntüle.Location = new System.Drawing.Point(232, 190);
            this.prsnlGörüntüle.Name = "prsnlGörüntüle";
            this.prsnlGörüntüle.Size = new System.Drawing.Size(375, 375);
            this.prsnlGörüntüle.TabIndex = 11;
            this.prsnlGörüntüle.Text = "Personel Görüntüle";
            this.prsnlGörüntüle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.prsnlGörüntüle.UseVisualStyleBackColor = true;
            this.prsnlGörüntüle.Click += new System.EventHandler(this.prsnlGörüntüle_Click);
            // 
            // frmPrsnlDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::otomasyonproje.Properties.Resources.gazi_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1328, 704);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prsnlGörüntüle);
            this.Name = "frmPrsnlDuzenleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrsnlDuzenleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button prsnlGörüntüle;
        
    }
}