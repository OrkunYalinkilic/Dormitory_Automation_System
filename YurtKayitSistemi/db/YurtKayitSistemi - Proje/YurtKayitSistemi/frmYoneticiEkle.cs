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
    public partial class frmYoneticiEkle : Form
    {
        public frmYoneticiEkle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        Yonetici yeniYonetici = new Yonetici();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            yeniYonetici.yoneticiAdi = txtAdi.Text;
            yeniYonetici.yoneticiSoyadi = TxtSoyad.Text;
            yeniYonetici.tcKimlikNo = MskYoneticiTc.Text;
            yeniYonetici.cepTelefonu = MskYoneticiTelefon.Text;
            yeniYonetici.kullaniciAdi = txtKullaniciAdi.Text;
            yeniYonetici.sifre = txtSifre.Text;


            if (yeniYonetici.boslukKontrol() == true)
            {
                if (YardimciSinif.stringKontrol(yeniYonetici.yoneticiAdi, yeniYonetici.yoneticiSoyadi) == false)
                {
                    MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    SqlCommand yoneticiEkle = new SqlCommand("insert into Admin(YoneticiAdi,YoneticiSoyadi,TcKimlikNo,CepTelefonNo,YoneticiKullaniciAdi,YoneticiSifre) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                    yoneticiEkle.Parameters.AddWithValue("@p1",yeniYonetici.yoneticiAdi);
                    yoneticiEkle.Parameters.AddWithValue("@p2",yeniYonetici.yoneticiSoyadi);
                    yoneticiEkle.Parameters.AddWithValue("@p3",yeniYonetici.tcKimlikNo);
                    yoneticiEkle.Parameters.AddWithValue("@p4",yeniYonetici.cepTelefonu);
                    yoneticiEkle.Parameters.AddWithValue("@p5",yeniYonetici.kullaniciAdi);
                    yoneticiEkle.Parameters.AddWithValue("@p6",yeniYonetici.sifre);
                    yoneticiEkle.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Yönetici ekleme işlemi gerçekleşti.", "Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmYoneticiEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
