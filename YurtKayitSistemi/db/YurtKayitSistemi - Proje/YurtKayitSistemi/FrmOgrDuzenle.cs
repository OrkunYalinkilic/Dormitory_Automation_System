using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmOgrDuzenle : Form
    {


        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        public string id, ad, soyad, tc, telefon, dogum, bolum;

        private void button1_Click(object sender, EventArgs e)
        {
            // Öğrenci Silme 
            SqlCommand komutSil = new SqlCommand("delete from Ogrenci where OgrID =@k1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@k1", txtOgrID.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();

            // Oda Aktifi Azaltma
            SqlCommand komutOda = new SqlCommand("update Odalar set OdaAktif = OdaAktif-1 where OdaNo=@k2", bgl.baglanti());
            komutOda.Parameters.AddWithValue("@k2", CmbOgrOdaNo.Text);
            komutOda.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayit silme gerceklesitirildi.");

        }


        public string mail, odano, veliadsoyad, velitelefon, veliadres;

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
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
            SqlCommand komut2 = new SqlCommand("select *from bosOdalar", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                CmbOgrOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            // box lara değerleri atama komutları

            txtOgrID.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskOgrTc.Text = tc;
            MskOgrTelefon.Text = telefon;
            MskOgrDogumTarihi.Text = dogum;
            CmbOgrBolum.Text = bolum;
            TxtOgrMail.Text = mail;
            CmbOgrOdaNo.Text = odano;
            TxtVeliAdSoyad.Text = veliadsoyad;
            MskVeliTelefon.Text = velitelefon;
            RchVeliAdres.Text = veliadres;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2, OgrSoyad=@p3 , OgrTC=@p4, OgrTelefon=@p5 , OgrDogumTarihi=@p6, OgrBolum=@p7, OgrMail=@p8, OgrOdaNo=@p9, OgrVeliAdSoyad=@p10, OgrVeliTelefon=@p11, OgrVeliAdres=@p12 where OgrID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtOgrID.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
            komut.Parameters.AddWithValue("@p4", MskOgrTc.Text);
            komut.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
            komut.Parameters.AddWithValue("@p6", MskOgrDogumTarihi.Text);
            komut.Parameters.AddWithValue("@p7", CmbOgrBolum.Text);
            komut.Parameters.AddWithValue("@p8", TxtOgrMail.Text);
            komut.Parameters.AddWithValue("@p9", CmbOgrOdaNo.Text);
            komut.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
            komut.Parameters.AddWithValue("@p11", MskVeliTelefon.Text);
            komut.Parameters.AddWithValue("@p12", RchVeliAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi.", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            Application.OpenForms["frmOgrDuzenleFormu"].Close();
        }

    }
}
