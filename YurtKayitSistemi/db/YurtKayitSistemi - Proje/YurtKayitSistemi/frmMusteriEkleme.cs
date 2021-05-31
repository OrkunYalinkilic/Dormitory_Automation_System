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
    public partial class frmMusteriEkleme : Form
    {
        public frmMusteriEkleme()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("execute MusteriEkle @Adi=@p1,@Soyadi=@p2,@Sehir=@p3,@Bakiye=@p4", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", TxtMusteriAd.Text);
            ekle.Parameters.AddWithValue("@p2", TxtMusteriSoyad.Text);
            ekle.Parameters.AddWithValue("@p3", txtMusteriSehir.Text);
            ekle.Parameters.AddWithValue("@p4", int.Parse(txtBakiye.Text));
            ekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Ekleme İşlemi Gerçekleşti", "Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmMusteriEkleme_Load(object sender, EventArgs e)
        {
           
        }
    }
}
