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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet3.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Borclar);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex;
            string id, ad, soyad, borc;

            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilenIndex].Cells[2].Value.ToString();
            borc = dataGridView1.Rows[secilenIndex].Cells[3].Value.ToString();

            txtOgrID.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            txtKalan.Text = borc;
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            //Ödenen Tutarı Kalan Tutardan Düşme
            int odenen, kalan,yeniborc;
            odenen = int.Parse(txtOdenen.Text);
            kalan = Convert.ToInt32(txtKalan.Text);
            yeniborc = kalan - odenen;
            txtKalan.Text = yeniborc.ToString();
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Borclar);
            MessageBox.Show("Ödeme Yapildi");
            
            //Yeni Tutarı Veritabanında güncelleme
            SqlCommand komut = new SqlCommand("update Borclar set @p1 = OgrKalanBorc where OgrID = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKalan.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Kasa tablosuna ekleme yapma
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) values (@p1,@p2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",txtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@p2",txtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }   
}
