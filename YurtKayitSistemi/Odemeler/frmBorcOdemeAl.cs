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
    public partial class frmBorcOdemeAl : Form
    {
        string id, zaman;
        public frmBorcOdemeAl(string _id, string _zaman)
        {
            zaman = _zaman;
            id = _id;
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int kalan;
        private void frmBorcOdemeAl_Load(object sender, EventArgs e)
        {
            SqlCommand komutOde = new SqlCommand("select *from Borclar where OgrID=@p1", bgl.baglanti());
            komutOde.Parameters.AddWithValue("@p1", id);
            komutOde.ExecuteNonQuery();
            SqlDataReader oku = komutOde.ExecuteReader();
            while (oku.Read())
            {
                txtAd.Text = oku[1].ToString();
                txtSoyad.Text = oku[2].ToString();
                txtBorc.Text = oku[3].ToString();
            }
            bgl.baglanti().Close();
        }
        int oncekiKasa;
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOdemeMiktar.Text))
            {
                MessageBox.Show("Değerler boş geçilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (YardimciSinif.sayiKontrol(txtOdemeMiktar.Text.ToString())==false)
                {
                    MessageBox.Show("Sayi girilmesi gereken bölüm HARF İÇEREMEZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //ogrenci kalan borc guncelleme
                    kalan = int.Parse(txtBorc.Text) - int.Parse(txtOdemeMiktar.Text);
                    SqlCommand komutOdemeAl = new SqlCommand("update Borclar set OgrKalanBorc=@a1 where OgrID=@a2", bgl.baglanti());
                    komutOdemeAl.Parameters.AddWithValue("@a1", kalan);
                    komutOdemeAl.Parameters.AddWithValue("@a2", id);
                    komutOdemeAl.ExecuteNonQuery();

                    //kasada anlık aydaki para durumu alma

                    SqlCommand onceKasaDurum = new SqlCommand("select *from Kasa where OdemeAy=@e1", bgl.baglanti());
                    onceKasaDurum.Parameters.AddWithValue("@e1", zaman);
                    onceKasaDurum.ExecuteNonQuery();
                    SqlDataReader oku = onceKasaDurum.ExecuteReader();
                    while (oku.Read())
                    { oncekiKasa = int.Parse(oku[1].ToString()); }
                    bgl.baglanti().Close();

                    //kasadaki anlık para durumu güncelleme
                    SqlCommand komutGelirEkle = new SqlCommand("update Kasa set OdemeMiktar=@s1 where OdemeAy=@s2", bgl.baglanti());
                    komutGelirEkle.Parameters.AddWithValue("@s1", oncekiKasa + int.Parse(txtOdemeMiktar.Text));
                    komutGelirEkle.Parameters.AddWithValue("@s2", zaman);
                    komutGelirEkle.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    MessageBox.Show("Ödeme Alma İşlemi Tamamlandı.\n Kalan Borç: " + kalan.ToString(), "Ödeme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Application.OpenForms[2].Close();
                    Application.OpenForms[1].Close();
                }
            }
        }
    }
}
