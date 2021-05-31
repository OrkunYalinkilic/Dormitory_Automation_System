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
    public partial class frmŞoforEkle : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();

        public frmŞoforEkle()
        {
            InitializeComponent();
        }

        Sofor s;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            s = new Sofor();
            s.adi = TxtSoforAd.Text;
            s.soyadi = TxtSoforSoyad.Text;
            s.yas = TxtSoforYas.Text;
            s.tcKimlikNo = MskSoforTc.Text;
            s.CepTelefonu = MskSoforTelefon.Text;

            if (s.boslukKontrol() == true)
            {
                if (YardimciSinif.stringKontrol(s.adi, s.soyadi) == false)
                {
                    MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (YardimciSinif.sayiKontrol(s.yas) == false)
                {
                    MessageBox.Show("**Sayı girilmesi gereken bilgiler harf içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand komutekle = new SqlCommand("insert into Soforler(SoforAd,SoforSoyad,SoforTCKimlik,SoforYas,SoforTelefon) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                    komutekle.Parameters.AddWithValue("@p1", s.adi);
                    komutekle.Parameters.AddWithValue("@p2", s.soyadi);
                    komutekle.Parameters.AddWithValue("@p3", s.tcKimlikNo);
                    komutekle.Parameters.AddWithValue("@p4", s.yas); 
                    komutekle.Parameters.AddWithValue("@p5", s.CepTelefonu);
                    komutekle.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Sofor Ekleme İslemi gerçekleşti", "Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmŞoforEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
