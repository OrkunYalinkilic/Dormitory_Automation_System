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
    public partial class SoforAyrıntı : Form
    {
        string id, islem;
        public SoforAyrıntı(string _islem, string _id)
        {
            id = _id; islem = _islem;
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();


        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSoforAd.Text)|| string.IsNullOrEmpty(TxtSoforSoyad.Text) || string.IsNullOrEmpty(MskSoforTc.Text) || string.IsNullOrEmpty(TxtSoforYas.Text) || string.IsNullOrEmpty(MskSoforTelefon.Text) )
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(YardimciSinif.stringKontrol(TxtSoforAd.Text)==false||YardimciSinif.stringKontrol(TxtSoforSoyad.Text)==false)
            {
                MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (YardimciSinif.sayiKontrol(TxtSoforYas.Text)==false)
            {
                MessageBox.Show("**Sayı girilmesi gereken bilgiler harf içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komutGuncelle = new SqlCommand("update Soforler set SoforAd=@z1,SoforSoyad=@z2,SoforTCKimlik=@z3,SoforYas=@z4,SoforTelefon=@z5 where SoforId=@z6", bgl.baglanti());
                komutGuncelle.Parameters.AddWithValue("@z1", TxtSoforAd.Text);
                komutGuncelle.Parameters.AddWithValue("@z2", TxtSoforSoyad.Text);
                komutGuncelle.Parameters.AddWithValue("@z3", MskSoforTc.Text);
                komutGuncelle.Parameters.AddWithValue("@z4", TxtSoforYas.Text);
                komutGuncelle.Parameters.AddWithValue("@z5", MskSoforTelefon.Text);
                komutGuncelle.Parameters.AddWithValue("@z6", id);
                komutGuncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme işlemi gerçekleştirildi", "Guncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Application.OpenForms[1].Close();
            }
            
        }

        private void SoforAyrıntı_Load(object sender, EventArgs e)
        {
            Sofor sofor1 = new Sofor();
            SqlCommand komutAl = new SqlCommand("select *from Soforler where SoforId=@p1", bgl.baglanti());
            komutAl.Parameters.AddWithValue("@p1", id);
            komutAl.ExecuteNonQuery();
            SqlDataReader oku = komutAl.ExecuteReader();
            while (oku.Read())
            {
                sofor1.adi = oku[1].ToString();
                sofor1.soyadi = oku[2].ToString();
                sofor1.yas = oku[4].ToString();
                sofor1.tcKimlikNo = oku[3].ToString();
                sofor1.CepTelefonu = oku[5].ToString();
            }
            bgl.baglanti().Close();

            TxtSoforAd.Text = sofor1.adi;
            TxtSoforSoyad.Text = sofor1.soyadi;
            TxtSoforYas.Text = sofor1.yas;
            MskSoforTc.Text = sofor1.tcKimlikNo;
            MskSoforTelefon.Text = sofor1.CepTelefonu;

            if (islem == "idarama")
            {
                TxtSoforAd.Enabled = false;
                TxtSoforSoyad.Enabled = false;
                TxtSoforYas.Enabled = false;
                MskSoforTc.Enabled = false;
                MskSoforTelefon.Enabled = false;
                this.Height -= 70;
            }
            else if (islem == "isimarama")
            {
                TxtSoforAd.Enabled = false;
                TxtSoforSoyad.Enabled = false;
                TxtSoforYas.Enabled = false;
                MskSoforTc.Enabled = false;
                MskSoforTelefon.Enabled = false;
                this.Height -= 70;
            }
            else if (islem == "guncelleme")
            {

            }
        }
    }
}
