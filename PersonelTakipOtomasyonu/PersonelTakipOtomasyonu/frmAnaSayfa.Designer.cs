
namespace PersonelTakipOtomasyonu
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDepartmanlar = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.btnMaasZamlari = new System.Windows.Forms.Button();
            this.btnPrim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDepartmanlar
            // 
            this.btnDepartmanlar.Location = new System.Drawing.Point(27, 32);
            this.btnDepartmanlar.Name = "btnDepartmanlar";
            this.btnDepartmanlar.Size = new System.Drawing.Size(114, 82);
            this.btnDepartmanlar.TabIndex = 0;
            this.btnDepartmanlar.Text = "Departmanlar";
            this.btnDepartmanlar.UseVisualStyleBackColor = true;
            this.btnDepartmanlar.Click += new System.EventHandler(this.btnDepartmanlar_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(158, 32);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(114, 82);
            this.btnPersonelEkle.TabIndex = 0;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.Location = new System.Drawing.Point(292, 32);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(114, 82);
            this.btnPersonelListele.TabIndex = 0;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.UseVisualStyleBackColor = true;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // btnMaasZamlari
            // 
            this.btnMaasZamlari.Location = new System.Drawing.Point(158, 130);
            this.btnMaasZamlari.Name = "btnMaasZamlari";
            this.btnMaasZamlari.Size = new System.Drawing.Size(114, 82);
            this.btnMaasZamlari.TabIndex = 1;
            this.btnMaasZamlari.Text = "Maaş Zamları";
            this.btnMaasZamlari.UseVisualStyleBackColor = true;
            this.btnMaasZamlari.Click += new System.EventHandler(this.btnMaasZamlari_Click);
            // 
            // btnPrim
            // 
            this.btnPrim.Location = new System.Drawing.Point(27, 130);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(114, 82);
            this.btnPrim.TabIndex = 1;
            this.btnPrim.Text = "Primler";
            this.btnPrim.UseVisualStyleBackColor = true;
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 230);
            this.Controls.Add(this.btnPrim);
            this.Controls.Add(this.btnMaasZamlari);
            this.Controls.Add(this.btnPersonelListele);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.btnDepartmanlar);
            this.Name = "frmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepartmanlar;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.Button btnMaasZamlari;
        private System.Windows.Forms.Button btnPrim;
    }
}

