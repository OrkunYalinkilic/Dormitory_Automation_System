using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class frmYoneticiDuzenleme : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        Yonetici gelen;
        public frmYoneticiDuzenleme(Yonetici _gelen)
        {
            gelen = _gelen;
            InitializeComponent();
        }

        private void frmYoneticiDuzenleme_Load(object sender, EventArgs e)
        {
            SqlCommand cek = new SqlCommand("select *from Admin where YoneticiKullaniciAdi=@p1", bgl.baglanti());
            cek.Parameters.AddWithValue("@p1", gelen.kullaniciAdi);
            cek.ExecuteNonQuery();
            SqlDataReader oku = cek.ExecuteReader();
            while (oku.Read())
            {
                txtAdi.Text = oku[1].ToString();
                TxtSoyad.Text = oku[2].ToString();
                MskYoneticiTc.Text = oku[3].ToString();
                MskYoneticiTelefon.Text = oku[4].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdi.Text) == true || string.IsNullOrEmpty(TxtSoyad.Text) == true)
            {
                MessageBox.Show("Değerler boş geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (YardimciSinif.stringKontrol(txtAdi.Text, TxtSoyad.Text) == false)
                {
                    MessageBox.Show("Yazi olması gereken kısımlar rakam içeremez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand guncelle = new SqlCommand("update Admin set YoneticiAdi=@p1,YoneticiSoyadi=@p2,TcKimlikNo = @p3,CepTelefonNo=@p4 where YoneticiKullaniciAdi=@p5", bgl.baglanti());
                    guncelle.Parameters.AddWithValue("@p1", txtAdi.Text);
                    guncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                    guncelle.Parameters.AddWithValue("@p3", MskYoneticiTc.Text);
                    guncelle.Parameters.AddWithValue("@p4", MskYoneticiTelefon.Text);
                    guncelle.Parameters.AddWithValue("@p5", gelen.kullaniciAdi);
                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme işlemi tamamlandı", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
