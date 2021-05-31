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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        Giderler YeniGider;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    item.Text = "0";
                }
            }

            if (YardimciSinif.sayiKontrol(txtElektrik.Text,txtSu.Text,txtDogalgaz.Text,txtGida.Text,txtInternet.Text,txtDiger.Text,txtPersonel.Text) == false)
            {
                MessageBox.Show("**Sayı girilmesi gereken bilgiler HARF İÇERMEMELİ.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                YeniGider = new Giderler();
                YeniGider.elektrik = int.Parse(txtElektrik.Text);
                YeniGider.su = int.Parse(txtSu.Text);
                YeniGider.dogalgaz = int.Parse(txtDogalgaz.Text);
                YeniGider.internet = int.Parse(txtInternet.Text);
                YeniGider.gida = int.Parse(txtGida.Text);
                YeniGider.personel = int.Parse(txtPersonel.Text);
                YeniGider.diger = int.Parse(txtDiger.Text);

                SqlCommand komut = new SqlCommand("insert into Giderler (Elektrik,Su,Dogalgaz,Internet,Gida,Personel,Diger) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", YeniGider.elektrik);
                komut.Parameters.AddWithValue("@p2", YeniGider.su);
                komut.Parameters.AddWithValue("@p3", YeniGider.dogalgaz);
                komut.Parameters.AddWithValue("@p4", YeniGider.internet);
                komut.Parameters.AddWithValue("@p5", YeniGider.gida);
                komut.Parameters.AddWithValue("@p6", YeniGider.personel);
                komut.Parameters.AddWithValue("@p7", YeniGider.diger);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayitlar ekleme işlemi gerçekleştirildi.", "Kayıt ekleme başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void FrmGider_Load(object sender, EventArgs e)
        {

        }
    }
}
