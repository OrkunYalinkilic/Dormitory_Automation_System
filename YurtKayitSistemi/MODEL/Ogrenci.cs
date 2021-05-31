using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public class Ogrenci : Person
    {
        public int ogrenciID { get; set; }
        public string dogumTarihi { get; set; }
        public string Bolumu { get; set; }
        public string EMailAdres { get; set; }
        public string odaNumarasi { get; set; }
        public string veliAdiSoyadi { get; set; }
        public string veliTelefonu { get; set; }
        public string adres { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        public bool boslukKontrol()
        {
            if (string.IsNullOrEmpty(dogumTarihi) == true ||
                string.IsNullOrEmpty(Bolumu) == true ||
                string.IsNullOrEmpty(EMailAdres) == true ||
                string.IsNullOrEmpty(odaNumarasi) == true ||
                string.IsNullOrEmpty(veliAdiSoyadi) == true ||
                string.IsNullOrEmpty(adi) == true ||
                string.IsNullOrEmpty(soyadi) == true ||
                string.IsNullOrEmpty(CepTelefonu) == true ||
                string.IsNullOrEmpty(veliTelefonu) == true ||
                string.IsNullOrEmpty(adres) == true||
                string.IsNullOrEmpty(tcKimlikNo) == true)
            {
                return false;
            }

            return true;
        }

        SqlBaglantim bgl = new SqlBaglantim();

        public bool LogIn()
        {
            SqlCommand komut = new SqlCommand("select *from Ogrenci where OgrKullaniciAdi = @p1 and OgrSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", this.kullaniciAdi);
            komut.Parameters.AddWithValue("@p2", this.sifre);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm("ogrenci",this.kullaniciAdi,"","");
                fr.ShowDialog();
                return true;
            }
            bgl.baglanti().Close();
            return false;
        }

        public void LogOut()
        {
            Application.Exit();
        }
    }
}
