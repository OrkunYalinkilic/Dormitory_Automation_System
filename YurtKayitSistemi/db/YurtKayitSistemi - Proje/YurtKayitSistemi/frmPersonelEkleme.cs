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
    public partial class frmPersonelEkleme : Form
    {
        public frmPersonelEkleme()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("execute PersonelEkle @ad=@p1, @soyad=@p2", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", TxtPersonelad.Text);
            ekle.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
            ekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Ekleme İşlemi Gerçekleşti", "Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
