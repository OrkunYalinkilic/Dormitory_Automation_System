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
    public class Yonetici
    {
        public string yoneticiAdi { get; set; }
        public string yoneticiSoyadi { get; set; }
        public string tcKimlikNo { get; set; }
        public string cepTelefonu { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        SqlBaglantim bgl = new SqlBaglantim();

        public bool boslukKontrol()
        {
            if (string.IsNullOrEmpty(yoneticiAdi) == true ||
                string.IsNullOrEmpty(yoneticiSoyadi) == true ||
                string.IsNullOrEmpty(tcKimlikNo) == true ||
                string.IsNullOrEmpty(cepTelefonu) == true ||
                string.IsNullOrEmpty(kullaniciAdi) == true ||
                string.IsNullOrEmpty(sifre) == true )
            {
                return false;
            }

            return true;
        }

        public bool LogIn()
        {
            SqlCommand komut = new SqlCommand("select *from Admin where YoneticiKullaniciAdi = @p1 and YoneticiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", this.kullaniciAdi);
            komut.Parameters.AddWithValue("@p2", this.sifre);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm("yonetici","",this.kullaniciAdi);
                fr.ShowDialog();
                return true;
            }
            bgl.baglanti().Close();
            return false;
        }

        public bool LogOut()
        {
           DialogResult result =  MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                return true;
            }
            else if(result ==DialogResult.No)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
