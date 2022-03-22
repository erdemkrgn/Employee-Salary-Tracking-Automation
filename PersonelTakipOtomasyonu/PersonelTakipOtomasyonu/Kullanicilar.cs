using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipOtomasyonu
{
    class Kullanicilar
    {
        private int _KullaniciID;
        private string _KullaniciAdi;
        private string _Sifre;

        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string KullaniciAdi { get => _KullaniciAdi; set => _KullaniciAdi = value; }
        public string Sifre { get => _Sifre; set => _Sifre = value; }

        public static bool durum = false;
        public static int kid = 0;

        public static SqlDataReader KullaniciGirisi(string kullaniciadi, string sifre)
        {
            Kullanicilar k = new Kullanicilar();
            k._KullaniciAdi = kullaniciadi;
            k._Sifre = sifre;
            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kullanicilar where kullaniciadi='"+k._KullaniciAdi+"' and sifre= '"+k._Sifre+"'",Veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
                kid = int.Parse(dr[0].ToString());
            }
            else
            {
                durum = false;
            }
            dr.Close();
            Veritabani.baglanti.Close();
            return dr;
        }
    }
}
