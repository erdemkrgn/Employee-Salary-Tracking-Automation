
namespace PersonelTakipOtomasyonu
{
    partial class frmPrimEkle
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
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.radioKisiyeOzel = new System.Windows.Forms.RadioButton();
            this.radioTumPersoneller = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrimEkle = new System.Windows.Forms.Button();
            this.btnPrimleriGoster = new System.Windows.Forms.Button();
            this.btnPersoneleGorePrim = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(103, 35);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(175, 20);
            this.txtPersonelID.TabIndex = 0;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(103, 61);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(175, 20);
            this.txtPersonelAdSoyad.TabIndex = 0;
            // 
            // radioKisiyeOzel
            // 
            this.radioKisiyeOzel.AutoSize = true;
            this.radioKisiyeOzel.Location = new System.Drawing.Point(104, 11);
            this.radioKisiyeOzel.Name = "radioKisiyeOzel";
            this.radioKisiyeOzel.Size = new System.Drawing.Size(99, 17);
            this.radioKisiyeOzel.TabIndex = 1;
            this.radioKisiyeOzel.TabStop = true;
            this.radioKisiyeOzel.Text = "Kişiye Özel Prim";
            this.radioKisiyeOzel.UseVisualStyleBackColor = true;
            // 
            // radioTumPersoneller
            // 
            this.radioTumPersoneller.AutoSize = true;
            this.radioTumPersoneller.Location = new System.Drawing.Point(361, 10);
            this.radioTumPersoneller.Name = "radioTumPersoneller";
            this.radioTumPersoneller.Size = new System.Drawing.Size(144, 17);
            this.radioTumPersoneller.TabIndex = 1;
            this.radioTumPersoneller.TabStop = true;
            this.radioTumPersoneller.Text = "Tüm Personeller İçin Prim";
            this.radioTumPersoneller.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dönem:";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(202, 90);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(76, 21);
            this.comboYil.TabIndex = 5;
            // 
            // comboAy
            // 
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboAy.Location = new System.Drawing.Point(103, 90);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(76, 21);
            this.comboAy.TabIndex = 6;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Location = new System.Drawing.Point(391, 35);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(175, 20);
            this.txtPrimTutari.TabIndex = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(391, 61);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(175, 59);
            this.txtAciklama.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 179);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Personel Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PersonelID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prim Tutarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Açıklama:";
            // 
            // btnPrimEkle
            // 
            this.btnPrimEkle.Location = new System.Drawing.Point(25, 123);
            this.btnPrimEkle.Name = "btnPrimEkle";
            this.btnPrimEkle.Size = new System.Drawing.Size(86, 41);
            this.btnPrimEkle.TabIndex = 10;
            this.btnPrimEkle.Text = "Prim Ekle";
            this.btnPrimEkle.UseVisualStyleBackColor = true;
            this.btnPrimEkle.Click += new System.EventHandler(this.btnPrimEkle_Click);
            // 
            // btnPrimleriGoster
            // 
            this.btnPrimleriGoster.Location = new System.Drawing.Point(130, 123);
            this.btnPrimleriGoster.Name = "btnPrimleriGoster";
            this.btnPrimleriGoster.Size = new System.Drawing.Size(86, 41);
            this.btnPrimleriGoster.TabIndex = 11;
            this.btnPrimleriGoster.Text = "Primleri Göster";
            this.btnPrimleriGoster.UseVisualStyleBackColor = true;
            this.btnPrimleriGoster.Click += new System.EventHandler(this.btnPrimleriGoster_Click);
            // 
            // btnPersoneleGorePrim
            // 
            this.btnPersoneleGorePrim.Location = new System.Drawing.Point(235, 123);
            this.btnPersoneleGorePrim.Name = "btnPersoneleGorePrim";
            this.btnPersoneleGorePrim.Size = new System.Drawing.Size(111, 41);
            this.btnPersoneleGorePrim.TabIndex = 12;
            this.btnPersoneleGorePrim.Text = "Personel Primleri";
            this.btnPersoneleGorePrim.UseVisualStyleBackColor = true;
            this.btnPersoneleGorePrim.Click += new System.EventHandler(this.btnPersoneleGorePrim_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(365, 123);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(81, 41);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(465, 123);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(85, 41);
            this.btnCikis.TabIndex = 12;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmPrimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 349);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnPersoneleGorePrim);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnPrimleriGoster);
            this.Controls.Add(this.btnPrimEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.radioTumPersoneller);
            this.Controls.Add(this.radioKisiyeOzel);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Name = "frmPrimEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prim Sayfası";
            this.Load += new System.EventHandler(this.frmPrimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.RadioButton radioKisiyeOzel;
        private System.Windows.Forms.RadioButton radioTumPersoneller;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrimEkle;
        private System.Windows.Forms.Button btnPrimleriGoster;
        private System.Windows.Forms.Button btnPersoneleGorePrim;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
    }
}