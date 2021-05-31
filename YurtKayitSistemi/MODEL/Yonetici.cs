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
                string.IsNullOrEmpty(sifre) == true)
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
                FrmAnaForm fr = new FrmAnaForm("yonetici", "", this.kullaniciAdi, this.sifre);
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

        public void yoneticiSil( )
        {
           DialogResult result = MessageBox.Show("Yöneticilik hesabınızı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("delete from Admin where YoneticiKullaniciAdi=@p1", bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", this.kullaniciAdi);
                sil.ExecuteNonQuery();
                bgl.baglanti().Close();
                System.Threading.Thread.Sleep(2000);
                Application.OpenForms[1].Close();
                frmOgrenciYoneticiGiris frm = new frmOgrenciYoneticiGiris();
            }
            else
            {
                Application.OpenForms[1].Close();
            }
        }
    }
}
