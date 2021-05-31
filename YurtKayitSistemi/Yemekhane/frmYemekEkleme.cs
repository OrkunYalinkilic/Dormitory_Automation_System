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
    public partial class frmYemekEkleme : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();

        public frmYemekEkleme()
        {
            InitializeComponent();
        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {

            if (YardimciSinif.sayiKontrol(txtYil.Text,txtGunSirasi.Text) == false)
            {
                MessageBox.Show("**Sayı girilmesi gereken bilgiler harf içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (YardimciSinif.stringKontrol(txtAyAdi.Text,txtYemekOgun.Text,txtYemekBir.Text,txtYemekIki.Text,txtYemekUc.Text,txtYemekDort.Text) == false)
            {
                MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Yemek nesnesinin oluşturulması
                Yemekhane yemek = new Yemekhane();
                yemek.Yil = txtYil.Text;
                yemek.ay = txtAyAdi.Text;
                yemek.gun = txtGunSirasi.Text;
                yemek.ogun = txtYemekOgun.Text;
                yemek.birinci_yemek = txtBirYemek.Text;
                yemek.ikinci_yemek = txtYemekIki.Text;
                yemek.ucuncu_yemek = txtYemekUc.Text;
                yemek.dorduncu_yemek = txtYemekDort.Text;

                if (yemek.boslukKontrol() == false)
                {
                    MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    SqlCommand komutekle = new SqlCommand("insert into Yemekhane(Yil,AyAdi,GunSirasi,YemekOgun,YemekBir,YemekIki,YemekUc,YemekDort) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                    komutekle.Parameters.AddWithValue("@p1", yemek.Yil);
                    komutekle.Parameters.AddWithValue("@p2", yemek.ay);
                    komutekle.Parameters.AddWithValue("@p3", yemek.gun);
                    komutekle.Parameters.AddWithValue("@p4", yemek.ogun);
                    komutekle.Parameters.AddWithValue("@p5", yemek.birinci_yemek);
                    komutekle.Parameters.AddWithValue("@p6", yemek.ikinci_yemek);
                    komutekle.Parameters.AddWithValue("@p7", yemek.ucuncu_yemek);
                    komutekle.Parameters.AddWithValue("@p8", yemek.dorduncu_yemek);
                    komutekle.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Yemek Ekleme İşlemi Gerçekleşti", "Yemek Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void frmYemekEkleme_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
