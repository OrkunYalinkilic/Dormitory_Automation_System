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
    public partial class SoforIslemleri : Form
    {
        string islem;
        public SoforIslemleri(string _islem)
        {
            islem = _islem;
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void SoforIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet33.Soforler' table. You can move, or remove it, as needed.
            this.soforlerTableAdapter1.Fill(this.yurtOtomasyonuDataSet33.Soforler);
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet27.Soforler' table. You can move, or remove it, as needed.
            //this.soforlerTableAdapter.Fill(this.yurtOtomasyonuDataSet27.Soforler);

            if (islem == "idarama")
            {
                label1.Text = "Aramak isteğiniz şoforun ID değerini seçiniz.";
                label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                (label4.Text).ToUpper();
                BtnKaydet.Text = "ARA";
                pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\Search-icon.png");
                txtSoforID.Enabled = true;
                TxtSoforAd.Visible = false;
                TxtSoforSoyad.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                this.BtnKaydet.Location = new System.Drawing.Point(455, 100);
                txtSoforID.Enabled = false;
            }
            else if (islem == "isimarama")
            {
                label1.Text = "Aramak isteğiniz şoforun isimini seçiniz.";
                label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                (label2.Text).ToUpper(); (label3.Text).ToUpper();
                TxtSoforAd.Enabled = true;
                TxtSoforSoyad.Enabled = true;
                BtnKaydet.Text = "ARA";
                pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\Search-icon.png");
                txtSoforID.Visible = false;
                label4.Visible = false;
                TxtSoforAd.Enabled = false;
                TxtSoforSoyad.Enabled = false;
            }
            else if (islem == "silme")
            {

            }
            else if (islem == "guncelleme")
            {
                label1.Text = "Guncellemek istediginiz şoförü seçiniz.";
                BtnKaydet.Text = "GUNCELLE";
                pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\Edit-Document-icon.png");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (islem == "idarama")
            {
                SoforAyrıntı frm = new SoforAyrıntı("idarama", txtSoforID.Text);
                frm.ShowDialog();
            }
            else if (islem == "isimarama")
            {
                SoforAyrıntı frm = new SoforAyrıntı("isimarama", txtSoforID.Text);
                frm.ShowDialog();
            }
            else if (islem == "silme")
            {
                SqlCommand komutsil = new SqlCommand("delete from Soforler where SoforId=@c1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@c1", txtSoforID.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Sofor silme işlemi gerçekleşti", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (islem == "guncelleme")
            {
                SoforAyrıntı frm = new SoforAyrıntı("guncelleme", txtSoforID.Text);
                frm.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex = dataGridView1.SelectedCells[0].RowIndex;
            txtSoforID.Text = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            TxtSoforAd.Text = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();
            TxtSoforSoyad.Text = dataGridView1.Rows[secilenIndex].Cells[2].Value.ToString();
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int secilenIndex = dataGridView1.SelectedCells[0].RowIndex;
        //    txtSoforID.Text = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
        //    TxtSoforAd.Text = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();
        //    TxtSoforSoyad.Text = dataGridView1.Rows[secilenIndex].Cells[2].Value.ToString();
        //}
    }
}
