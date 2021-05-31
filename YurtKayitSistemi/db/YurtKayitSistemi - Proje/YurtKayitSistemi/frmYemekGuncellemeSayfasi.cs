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
    public partial class frmYemekGuncellemeSayfasi : Form
    {
        string id;
        public frmYemekGuncellemeSayfasi(string _id)
        {
            id = _id;
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        Yemekhane yemekOkunan = new Yemekhane();

        private void frmYemekGuncellemeSayfasi_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from Yemekhane where YemeklerID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                yemekOkunan.Yil = oku[0].ToString();
                yemekOkunan.ay = oku[1].ToString();
                yemekOkunan.gun = oku[2].ToString();
                yemekOkunan.ogun = oku[3].ToString();
                yemekOkunan.birinci_yemek = oku[4].ToString();
                yemekOkunan.ikinci_yemek = oku[5].ToString();
                yemekOkunan.ucuncu_yemek = oku[6].ToString();
                yemekOkunan.dorduncu_yemek = oku[7].ToString();

                txtYil.Text = yemekOkunan.Yil;
                txtAyAdi.Text = yemekOkunan.ay;
                txtGunSirasi.Text = yemekOkunan.gun;
                txtYemekOgun.Text = yemekOkunan.ogun;
                txtBirYemek.Text = yemekOkunan.birinci_yemek;
                txtYemekIki.Text = yemekOkunan.ikinci_yemek;
                txtYemekUc.Text = yemekOkunan.ucuncu_yemek;
                txtYemekDort.Text = yemekOkunan.dorduncu_yemek;
            }

            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (YardimciSinif.stringKontrol(txtAyAdi.Text,txtYemekOgun.Text,txtBirYemek.Text,txtYemekIki.Text,txtYemekUc.Text,txtYemekDort.Text)==false)
            {
                MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (YardimciSinif.sayiKontrol(txtYil.Text,txtGunSirasi.Text)==false)
            {
                MessageBox.Show("**Sayı girilmesi gereken bilgiler harf içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(
                string.IsNullOrEmpty(txtYil.Text) == true||
                string.IsNullOrEmpty( txtAyAdi.Text) == true ||
                string.IsNullOrEmpty(txtGunSirasi.Text) == true ||
                string.IsNullOrEmpty(txtYemekOgun.Text) == true ||
                string.IsNullOrEmpty(txtBirYemek.Text) == true ||
                string.IsNullOrEmpty(txtYemekIki.Text) == true ||
                string.IsNullOrEmpty(txtYemekUc.Text) == true ||
                string.IsNullOrEmpty(txtYemekDort.Text) == true 
                )
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komut2 = new SqlCommand("update Yemekhane set yil=@a1,AyAdi=@a2,GunSirasi=@a3,YemekOgun=@a4,YemekBir=@a5,YemekIki=@a6,YemekUc=@a7,YemekDort=@a8 where YemeklerID=@a9 ", bgl.baglanti());
                komut2.Parameters.AddWithValue("@a1", txtYil.Text);
                komut2.Parameters.AddWithValue("@a2", txtAyAdi.Text);
                komut2.Parameters.AddWithValue("@a3", txtGunSirasi.Text);
                komut2.Parameters.AddWithValue("@a4", txtYemekOgun.Text);
                komut2.Parameters.AddWithValue("@a5", txtBirYemek.Text);
                komut2.Parameters.AddWithValue("@a6", txtYemekIki.Text);
                komut2.Parameters.AddWithValue("@a7", txtYemekUc.Text);
                komut2.Parameters.AddWithValue("@a8", txtYemekDort.Text);
                komut2.Parameters.AddWithValue("@a9", id);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Guncelleme islemi gerçekleştirildi", "Guncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }
    }
}
