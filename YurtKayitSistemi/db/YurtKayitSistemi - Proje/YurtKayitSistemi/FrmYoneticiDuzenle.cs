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
    public partial class FrmYoneticiDuzenle : Form
    {
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmYoneticiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet7.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter1.Fill(this.yurtOtomasyonuDataSet7.Admin);


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" insert into Admin ( YoneticiAd,YoneticiSifre) values(@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yonetici Eklendi.");
            this.adminTableAdapter1.Fill(this.yurtOtomasyonuDataSet7.Admin);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete from Admin where YoneticiID=@b1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@b1", txtYoneticiID.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme islemi gerceklestirildi..");
            this.adminTableAdapter1.Fill(this.yurtOtomasyonuDataSet7.Admin);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, KullaciAd, sifre;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            KullaciAd = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtYoneticiID.Text = id;
            txtKullaniciAd.Text = KullaciAd;
            txtSifre.Text = sifre;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update Admin set YoneticiAd=@p1 , YoneticiSifre=@p2 where YoneticiID=@p3", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut3.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut3.Parameters.AddWithValue("@p3", txtYoneticiID.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Guncelleme islemi gerceklestirildi..");
        }

        private void adminBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
