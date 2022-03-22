
namespace PersonelTakipOtomasyonu
{
    partial class frmPrimleriGoster
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrimID = new System.Windows.Forms.TextBox();
            this.btnPrimGuncelle = new System.Windows.Forms.Button();
            this.btnPrimSil = new System.Windows.Forms.Button();
            this.btnTumPrimleriOde = new System.Windows.Forms.Button();
            this.btnPrimOde = new System.Windows.Forms.Button();
            this.btnDonemDegistir = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "PersonelID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Personel Ad Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Prim Tutarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Dönem:";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(461, 292);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(76, 21);
            this.comboYil.TabIndex = 17;
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
            this.comboAy.Location = new System.Drawing.Point(362, 292);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(76, 21);
            this.comboAy.TabIndex = 18;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(362, 349);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(261, 66);
            this.txtAciklama.TabIndex = 13;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Location = new System.Drawing.Point(362, 323);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(175, 20);
            this.txtPrimTutari.TabIndex = 14;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(116, 352);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(175, 20);
            this.txtPersonelAdSoyad.TabIndex = 15;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(116, 323);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(175, 20);
            this.txtPersonelID.TabIndex = 16;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "PrimID:";
            // 
            // txtPrimID
            // 
            this.txtPrimID.Location = new System.Drawing.Point(116, 292);
            this.txtPrimID.Name = "txtPrimID";
            this.txtPrimID.Size = new System.Drawing.Size(175, 20);
            this.txtPrimID.TabIndex = 25;
            // 
            // btnPrimGuncelle
            // 
            this.btnPrimGuncelle.Location = new System.Drawing.Point(236, 425);
            this.btnPrimGuncelle.Name = "btnPrimGuncelle";
            this.btnPrimGuncelle.Size = new System.Drawing.Size(85, 41);
            this.btnPrimGuncelle.TabIndex = 27;
            this.btnPrimGuncelle.Text = "Prim Güncelle";
            this.btnPrimGuncelle.UseVisualStyleBackColor = true;
            this.btnPrimGuncelle.Click += new System.EventHandler(this.btnPrimGuncelle_Click);
            // 
            // btnPrimSil
            // 
            this.btnPrimSil.Location = new System.Drawing.Point(338, 425);
            this.btnPrimSil.Name = "btnPrimSil";
            this.btnPrimSil.Size = new System.Drawing.Size(85, 41);
            this.btnPrimSil.TabIndex = 28;
            this.btnPrimSil.Text = "Prim Sil";
            this.btnPrimSil.UseVisualStyleBackColor = true;
            this.btnPrimSil.Click += new System.EventHandler(this.btnPrimSil_Click);
            // 
            // btnTumPrimleriOde
            // 
            this.btnTumPrimleriOde.Location = new System.Drawing.Point(19, 425);
            this.btnTumPrimleriOde.Name = "btnTumPrimleriOde";
            this.btnTumPrimleriOde.Size = new System.Drawing.Size(98, 41);
            this.btnTumPrimleriOde.TabIndex = 27;
            this.btnTumPrimleriOde.Text = "Tüm Primleri Öde";
            this.btnTumPrimleriOde.UseVisualStyleBackColor = true;
            this.btnTumPrimleriOde.Click += new System.EventHandler(this.btnTumPrimleriOde_Click);
            // 
            // btnPrimOde
            // 
            this.btnPrimOde.Location = new System.Drawing.Point(134, 425);
            this.btnPrimOde.Name = "btnPrimOde";
            this.btnPrimOde.Size = new System.Drawing.Size(85, 41);
            this.btnPrimOde.TabIndex = 28;
            this.btnPrimOde.Text = "Prim Öde";
            this.btnPrimOde.UseVisualStyleBackColor = true;
            this.btnPrimOde.Click += new System.EventHandler(this.btnPrimOde_Click);
            // 
            // btnDonemDegistir
            // 
            this.btnDonemDegistir.Location = new System.Drawing.Point(543, 287);
            this.btnDonemDegistir.Name = "btnDonemDegistir";
            this.btnDonemDegistir.Size = new System.Drawing.Size(80, 56);
            this.btnDonemDegistir.TabIndex = 28;
            this.btnDonemDegistir.Text = "Dönem Değiştir";
            this.btnDonemDegistir.UseVisualStyleBackColor = true;
            this.btnDonemDegistir.Click += new System.EventHandler(this.btnDonemDegistir_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(542, 428);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(85, 41);
            this.btnCikis.TabIndex = 30;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(440, 428);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 41);
            this.btnTemizle.TabIndex = 29;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmPrimleriGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 484);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnPrimOde);
            this.Controls.Add(this.btnDonemDegistir);
            this.Controls.Add(this.btnPrimSil);
            this.Controls.Add(this.btnTumPrimleriOde);
            this.Controls.Add(this.btnPrimGuncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrimID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPrimleriGoster";
            this.Text = "Tüm Personel Primleri";
            this.Load += new System.EventHandler(this.frmPrimleriGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrimID;
        private System.Windows.Forms.Button btnPrimGuncelle;
        private System.Windows.Forms.Button btnPrimSil;
        private System.Windows.Forms.Button btnTumPrimleriOde;
        private System.Windows.Forms.Button btnPrimOde;
        private System.Windows.Forms.Button btnDonemDegistir;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
    }
}