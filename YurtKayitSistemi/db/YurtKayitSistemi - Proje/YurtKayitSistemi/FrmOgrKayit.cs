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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {      
        }

        SqlBaglantim bgl = new SqlBaglantim();
        Ogrenci ogr;

        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            // Bölümleri listeleme komutları
            SqlCommand komut = new SqlCommand("Select BolumAd from Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) // Okuma işlemi gerçekleştiği müddetçe
            {
                CmbOgrBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //Boş odaları listeleme komutları
            SqlCommand komut2 = new SqlCommand("select odaNo from Odalar where OdaAktif != OdaKapasite", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                CmbOgrOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // ogr nesnesi oluşturulması
            ogr = new Ogrenci();
            ogr.adi = TxtOgrAd.Text;
            ogr.soyadi = TxtOgrSoyad.Text;
            ogr.tcKimlikNo = MskOgrTc.Text;
            ogr.CepTelefonu = MskOgrTelefon.Text;
            ogr.dogumTarihi = MskOgrDogumTarihi.Text;
            ogr.Bolumu = CmbOgrBolum.Text;
            ogr.EMailAdres = TxtOgrMail.Text;
            ogr.odaNumarasi = CmbOgrOdaNo.Text;
            ogr.veliAdiSoyadi = TxtVeliAdSoyad.Text;
            ogr.veliTelefonu = MskOgrTelefon.Text;
            ogr.adres = RchVeliAdres.Text;
            ogr.kullaniciAdi = txtKullaniciAdi.Text;
            ogr.sifre = txtSifre.Text;

            if (ogr.boslukKontrol() == true)
            {
                if (YardimciSinif.stringKontrol(ogr.adi, ogr.soyadi, ogr.Bolumu, ogr.veliAdiSoyadi) == false)
                {
                    MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (YardimciSinif.sayiKontrol(ogr.tcKimlikNo, ogr.odaNumarasi) == false)
                {
                    MessageBox.Show("**Sayı girilmesi gereken bilgiler harf içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    SqlCommand komutKaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogumTarihi,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres,OgrKullaniciAdi,OgrSifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)", bgl.baglanti());
                    komutKaydet.Parameters.AddWithValue("@p1", ogr.adi);
                    komutKaydet.Parameters.AddWithValue("@p2", ogr.soyadi);
                    komutKaydet.Parameters.AddWithValue("@p3", ogr.tcKimlikNo);
                    komutKaydet.Parameters.AddWithValue("@p4", ogr.CepTelefonu);
                    komutKaydet.Parameters.AddWithValue("@p5", ogr.dogumTarihi);
                    komutKaydet.Parameters.AddWithValue("@p6", ogr.Bolumu);
                    komutKaydet.Parameters.AddWithValue("@p7", ogr.EMailAdres);
                    komutKaydet.Parameters.AddWithValue("@p8", ogr.odaNumarasi);
                    komutKaydet.Parameters.AddWithValue("@p9", ogr.veliAdiSoyadi);
                    komutKaydet.Parameters.AddWithValue("@p10", ogr.veliTelefonu);
                    komutKaydet.Parameters.AddWithValue("@p11", ogr.adres);
                    komutKaydet.Parameters.AddWithValue("@p12", ogr.kullaniciAdi );
                    komutKaydet.Parameters.AddWithValue("@p13", ogr.sifre);
                    komutKaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayit islemi gerceklestirildi..", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    // ÖğrenciID'yi label12'e çekme
                    SqlCommand komut = new SqlCommand("select OgrID from Ogrenci where OgrTC=@a1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@a1", ogr.tcKimlikNo);
                    komut.ExecuteNonQuery();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read()) { label12.Text = oku[0].ToString();}

                    // Öğrenci Borç Alanı Oluşturma
                    SqlCommand komutKaydet3 = new SqlCommand("insert into Borclar(OgrID, OgrAd, OgrSoyad) values(@b1,@b2,@b3)", bgl.baglanti());
                    komutKaydet3.Parameters.AddWithValue("@b1", label12.Text);
                    komutKaydet3.Parameters.AddWithValue("@b2", ogr.adi);
                    komutKaydet3.Parameters.AddWithValue("@b3", ogr.soyadi);
                    komutKaydet3.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    // Öğrenci Oda Kontenjanı Azaltma
                    SqlCommand komutOda = new SqlCommand("update Odalar set OdaAktif = OdaAktif +1 where OdaNo=@c1", bgl.baglanti());
                    komutOda.Parameters.AddWithValue("@c1", ogr.odaNumarasi);
                    komutOda.ExecuteNonQuery();
                    bgl.baglanti().Close();
                }
            }
            else
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }
    }
}

// Data Source=DESKTOP-O9HL0H1\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True