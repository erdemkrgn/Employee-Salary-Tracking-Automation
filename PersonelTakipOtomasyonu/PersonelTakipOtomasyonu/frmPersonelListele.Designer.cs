
namespace PersonelTakipOtomasyonu
{
    partial class frmPersonelListele
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
            this.txtPersonelIDAra = new System.Windows.Forms.TextBox();
            this.txtPersonelAdAra = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyadAra = new System.Windows.Forms.TextBox();
            this.txtPersonelTelefonAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboDepartman = new System.Windows.Forms.ComboBox();
            this.txtMaasi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblToplamMaas = new System.Windows.Forms.Label();
            this.lblToplamKayit = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerG_Tarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelIDAra
            // 
            this.txtPersonelIDAra.Location = new System.Drawing.Point(8, 31);
            this.txtPersonelIDAra.Name = "txtPersonelIDAra";
            this.txtPersonelIDAra.Size = new System.Drawing.Size(112, 20);
            this.txtPersonelIDAra.TabIndex = 0;
            this.txtPersonelIDAra.TextChanged += new System.EventHandler(this.txtPersonelIDAra_TextChanged);
            // 
            // txtPersonelAdAra
            // 
            this.txtPersonelAdAra.Location = new System.Drawing.Point(140, 31);
            this.txtPersonelAdAra.Name = "txtPersonelAdAra";
            this.txtPersonelAdAra.Size = new System.Drawing.Size(148, 20);
            this.txtPersonelAdAra.TabIndex = 0;
            this.txtPersonelAdAra.TextChanged += new System.EventHandler(this.txtPersonelAdAra_TextChanged);
            // 
            // txtPersonelSoyadAra
            // 
            this.txtPersonelSoyadAra.Location = new System.Drawing.Point(312, 31);
            this.txtPersonelSoyadAra.Name = "txtPersonelSoyadAra";
            this.txtPersonelSoyadAra.Size = new System.Drawing.Size(148, 20);
            this.txtPersonelSoyadAra.TabIndex = 0;
            this.txtPersonelSoyadAra.TextChanged += new System.EventHandler(this.txtPersonelSoyadAra_TextChanged);
            // 
            // txtPersonelTelefonAra
            // 
            this.txtPersonelTelefonAra.Location = new System.Drawing.Point(485, 31);
            this.txtPersonelTelefonAra.Name = "txtPersonelTelefonAra";
            this.txtPersonelTelefonAra.Size = new System.Drawing.Size(148, 20);
            this.txtPersonelTelefonAra.TabIndex = 0;
            this.txtPersonelTelefonAra.TextChanged += new System.EventHandler(this.txtPersonelTelefonAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel ID Ara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Adı Ara:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Personel Soyadı Ara:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Personel Telefon Ara:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1011, 278);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefonu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Personel Soyadı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Personel Adı:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(129, 458);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(159, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(129, 431);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(159, 20);
            this.txtSoyadi.TabIndex = 5;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(129, 399);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(159, 20);
            this.txtAdi.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "E mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Adres:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(377, 368);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(129, 484);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(159, 55);
            this.txtAdres.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Giriş Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Maaşı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Departman:";
            // 
            // dateTimePickerGirisTarihi
            // 
            this.dateTimePickerGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerGirisTarihi.Location = new System.Drawing.Point(377, 455);
            this.dateTimePickerGirisTarihi.Name = "dateTimePickerGirisTarihi";
            this.dateTimePickerGirisTarihi.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerGirisTarihi.TabIndex = 16;
            // 
            // comboDepartman
            // 
            this.comboDepartman.FormattingEnabled = true;
            this.comboDepartman.Location = new System.Drawing.Point(377, 394);
            this.comboDepartman.Name = "comboDepartman";
            this.comboDepartman.Size = new System.Drawing.Size(159, 21);
            this.comboDepartman.TabIndex = 15;
            // 
            // txtMaasi
            // 
            this.txtMaasi.Location = new System.Drawing.Point(377, 424);
            this.txtMaasi.Name = "txtMaasi";
            this.txtMaasi.Size = new System.Drawing.Size(159, 20);
            this.txtMaasi.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(318, 486);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(377, 483);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(159, 67);
            this.txtAciklama.TabIndex = 20;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(943, 477);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(77, 67);
            this.btnCikis.TabIndex = 23;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblToplamMaas
            // 
            this.lblToplamMaas.AutoSize = true;
            this.lblToplamMaas.Location = new System.Drawing.Point(583, 414);
            this.lblToplamMaas.Name = "lblToplamMaas";
            this.lblToplamMaas.Size = new System.Drawing.Size(221, 13);
            this.lblToplamMaas.TabIndex = 24;
            this.lblToplamMaas.Text = "Listede toplam 66000,65TL maaş hesaplandı.";
            // 
            // lblToplamKayit
            // 
            this.lblToplamKayit.AutoSize = true;
            this.lblToplamKayit.Location = new System.Drawing.Point(583, 385);
            this.lblToplamKayit.Name = "lblToplamKayit";
            this.lblToplamKayit.Size = new System.Drawing.Size(161, 13);
            this.lblToplamKayit.TabIndex = 24;
            this.lblToplamKayit.Text = "Listede toplam 85 kayıt listelendi.";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(859, 477);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 67);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(775, 477);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(77, 67);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(129, 368);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(159, 20);
            this.txtPersonelID.TabIndex = 6;
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.Location = new System.Drawing.Point(55, 371);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(65, 13);
            this.lblPersonelID.TabIndex = 9;
            this.lblPersonelID.Text = "Personel ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(667, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Tarihe Göre Ara:";
            // 
            // dateTimePickerG_Tarihi
            // 
            this.dateTimePickerG_Tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerG_Tarihi.Location = new System.Drawing.Point(670, 30);
            this.dateTimePickerG_Tarihi.Name = "dateTimePickerG_Tarihi";
            this.dateTimePickerG_Tarihi.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerG_Tarihi.TabIndex = 29;
            this.dateTimePickerG_Tarihi.ValueChanged += new System.EventHandler(this.dateTimePickerG_Tarihi_ValueChanged);
            // 
            // frmPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 553);
            this.Controls.Add(this.dateTimePickerG_Tarihi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblToplamKayit);
            this.Controls.Add(this.lblToplamMaas);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePickerGirisTarihi);
            this.Controls.Add(this.comboDepartman);
            this.Controls.Add(this.txtMaasi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPersonelID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonelTelefonAra);
            this.Controls.Add(this.txtPersonelSoyadAra);
            this.Controls.Add(this.txtPersonelAdAra);
            this.Controls.Add(this.txtPersonelIDAra);
            this.Name = "frmPersonelListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listeleme,Arama,Silme ve Güncelleme Sayfası";
            this.Load += new System.EventHandler(this.frmPersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelIDAra;
        private System.Windows.Forms.TextBox txtPersonelAdAra;
        private System.Windows.Forms.TextBox txtPersonelSoyadAra;
        private System.Windows.Forms.TextBox txtPersonelTelefonAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerGirisTarihi;
        private System.Windows.Forms.ComboBox comboDepartman;
        private System.Windows.Forms.TextBox txtMaasi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblToplamMaas;
        private System.Windows.Forms.Label lblToplamKayit;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerG_Tarihi;
    }
}