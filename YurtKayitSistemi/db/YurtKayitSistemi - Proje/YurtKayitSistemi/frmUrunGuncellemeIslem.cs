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
    public partial class frmUrunGuncellemeIslem : Form
    {
        int id;
        public frmUrunGuncellemeIslem(int _id)
        {
            id = _id;
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        
        private void frmUrunGuncellemeIslem_Load(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("execute UrunBilgiGetir @urunID=@a1", bgl.baglanti());
            getir.Parameters.AddWithValue("@a1",id);
            getir.ExecuteNonQuery();

            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                txtUrunAd.Text = oku[0].ToString();
                txtUrunMarka.Text = oku[1].ToString();
                txtAlisFiyat.Text = oku[2].ToString();
                txtSatisFiyat.Text = oku[3].ToString();
            }
            bgl.baglanti().Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("execute UrunGuncelle @Adi=@p1, @Marka=@p2,  @AlisFiyat=@p3, @SatisFiyat=@p4, @urunID = @p5 ", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1",txtUrunAd.Text);
            guncelle.Parameters.AddWithValue("@p2",txtUrunMarka.Text);
            guncelle.Parameters.AddWithValue("@p3",float.Parse(txtAlisFiyat.Text));
            guncelle.Parameters.AddWithValue("@p4",float.Parse(txtSatisFiyat.Text));
            guncelle.Parameters.AddWithValue("@p5",id);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün güncelleme işlemi gerçekleşti", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
