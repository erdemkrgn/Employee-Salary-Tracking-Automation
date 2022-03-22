using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class frmPrimleriGoster : Form
    {
        public frmPrimleriGoster()
        {
            InitializeComponent();
        }

        private void frmPrimleriGoster_Load(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1,"select *from Primler");
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["OdenmeDurumu"].Value.ToString()=="Ödenmedi")
            {   
                txtPrimID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPersonelID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPrimTutari.Text = dataGridView1.CurrentRow.Cells["PrimTutari"].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
            }

        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID,txtPersonelAdSoyad);
        }

        private void btnDonemDegistir_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.Donem = comboAy.Text + "/" + comboYil.Text;
            p.PrimID = int.Parse(txtPrimID.Text);
            string sql = "update Primler set donem='" + p.Donem + "' where PrimID='"+p.PrimID+"'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut,sql);
            Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
            MessageBox.Show("Dönem değişimi yapıldı.","Dönem Değişimi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnTemizle.PerformClick();
        }

        private void btnTumPrimleriOde_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.OdenmeDurumu = "Ödendi";
            p.PrimID = int.Parse(txtPrimID.Text);
            string sql = "update Primler set OdenmeDurumu='" + p.OdenmeDurumu + "' where OdenmeDurumu='Ödenmedi'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
            MessageBox.Show("Ödenmeyen tüm primler ödendi.", "Prim Ödemeleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
        }

        private void btnPrimOde_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.OdenmeDurumu = "Ödendi";
            p.PrimID = int.Parse(txtPrimID.Text);
            string sql = "update Primler set OdenmeDurumu='" + p.OdenmeDurumu + "' where PrimID='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
            MessageBox.Show("Seçili kayda göre prim ödendi.", "Prim Ödemeleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnPrimGuncelle_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.PrimID = int.Parse(txtPrimID.Text);
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.PrimTutari = decimal.Parse(txtPrimTutari.Text);
            p.Aciklama = txtAciklama.Text;
            string sql = "update Primler set PersonelID='"+p.PersonelID+"',PrimTutari=@PrimTutari,Aciklama='"+p.Aciklama+"' where PrimID='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@PrimTutari",SqlDbType.Decimal).Value = p.PrimTutari;
            Veritabani.ESG(komut, sql);
            Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
            MessageBox.Show("Seçili kaydın prim bilgileri güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
        }

        private void btnPrimSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {

                Primler p = new Primler();
                p.PrimID = int.Parse(dataGridView1.CurrentRow.Cells["PrimID"].Value.ToString()); 
                
                string sql = "delete from where PrimID='" + p.PrimID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
                MessageBox.Show("Prim kaydı silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnTemizle.PerformClick();
            }

        }
    }
}
