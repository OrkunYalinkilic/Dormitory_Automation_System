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
    public partial class frmDuyuruEkle : Form
    {
        public frmDuyuruEkle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void btnDuyuruEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("insert into Duyurular(duyuruBaslik,duyuruicerik) values(@p1,@p2)", bgl.baglanti());
            komutEkle.Parameters.AddWithValue("@p1", txtDuyuruBaslik.Text);
            komutEkle.Parameters.AddWithValue("@p2", rchDuyuruIcerik.Text);
            komutEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Ekleme İşlemi Gerçekleşti", "Duyuru Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmDuyuruEkle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
