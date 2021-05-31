using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlBaglantim bgl = new SqlBaglantim();


        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);

        }

        private void pcbEkleme_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut1 = new SqlCommand(" insert into Bolumler(BolumAd) values(@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ekleme islemi gerceklestirildi.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme islemi gerceklestirilemedi.");
            }
        }

        private void pcbSilme_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where BolumID = @p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
                MessageBox.Show("Silme islemi gerceklestirildi");
            }
            catch (Exception)
            {
                MessageBox.Show("Silme islemi gerceklestirilemedi");
            }
        }

        int secilenIndex;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            string bolumAdi;

            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;

            id = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            bolumAdi = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();

            TxtBolumId.Text = id;
            TxtBolumAd.Text = bolumAdi;
        }

        private void pcbGuncelleme_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("update Bolumler set BolumAd=@p1 where BolumID=@p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut2.Parameters.AddWithValue("@p2", TxtBolumId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
                MessageBox.Show("Guncelleme islemi gerceklestirildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Guncelleme islemi gerceklestirilemedi.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
