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
    public partial class OgrenciIslemleri : Form
    {
        public OgrenciIslemleri()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void OgrenciIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet11.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet11.Ogrenci);

            txtOgrID.Enabled = false;
            TxtOgrAd.Enabled = false;
            TxtOgrSoyad.Enabled = false;
            txtOda.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Öğrenci Silme 
            SqlCommand komutSil = new SqlCommand("delete from Ogrenci where OgrID =@k1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@k1", txtOgrID.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet11.Ogrenci);


            // Oda Aktifi Azaltma
            SqlCommand komutOda = new SqlCommand("update Odalar set OdaAktif = OdaAktif-1 where OdaNo=@k2", bgl.baglanti());
            komutOda.Parameters.AddWithValue("@k2", txtOda.Text);
            komutOda.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet11.Ogrenci);
            MessageBox.Show("Öğrenci silme işlemi gerçekleştirildi","Silme Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex;
            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;

            txtOgrID.Text=dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            TxtOgrAd.Text = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();
            TxtOgrSoyad.Text = dataGridView1.Rows[secilenIndex].Cells[2].Value.ToString();
            MskOgrTc.Text = dataGridView1.Rows[secilenIndex].Cells[3].Value.ToString();
            txtOda.Text = dataGridView1.Rows[secilenIndex].Cells[4].Value.ToString();
        }
    }
}
