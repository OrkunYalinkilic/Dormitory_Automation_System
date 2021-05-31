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
    public partial class frmUrunEkleme : Form
    {
        public frmUrunEkleme()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            int kategoriID = 0;
            //kategori id bulma
            SqlCommand kategoriIDBul = new SqlCommand("select kategoriID from tblKategori where kategoriAdi=@a1", bgl.baglanti());
            kategoriIDBul.Parameters.AddWithValue("@a1", CmbKategori.Text);
            kategoriIDBul.ExecuteNonQuery();
            SqlDataReader oku = kategoriIDBul.ExecuteReader();
            while (oku.Read())
            {
                kategoriID = int.Parse(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //ürün ekleme
            SqlCommand ekle = new SqlCommand("execute UrunEkle @Adi=@p1,@Marka=@p2,@Kategori=@p3,@AlisFiyat=@p4,@SatisFiyat=@p5,@Stok=@p6", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1",txtUrunAd.Text);
            ekle.Parameters.AddWithValue("@p2",txtUrunMarka.Text);
            ekle.Parameters.AddWithValue("@p3",kategoriID); /*ayarla*/
            ekle.Parameters.AddWithValue("@p4",int.Parse(txtAlisFiyat.Text));
            ekle.Parameters.AddWithValue("@p5",int.Parse(txtSatisFiyat.Text));
            ekle.Parameters.AddWithValue("@p6",int.Parse(TxtStok.Text));
            ekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Ekleme İşlemi Gerçekleşti", "Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmUrunEkleme_Load(object sender, EventArgs e)
        {
            // Kategorileri listeleme komutları
            SqlCommand komut = new SqlCommand("Select kategoriAdi from tblKategori", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) // Okuma işlemi gerçekleştiği müddetçe
            {
                CmbKategori.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

        }
    }
}
