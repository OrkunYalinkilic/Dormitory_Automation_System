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
    public partial class PersonelISLEM : Form
    {
        string islemTur;
        public PersonelISLEM(string _islemTur)
        {
            islemTur = _islemTur;
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void PersonelISLEM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet32.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter3.Fill(this.yurtOtomasyonuDataSet32.Personel);

            if (islemTur == "silme")
            {
                txtPersonelAdSoyad.Enabled = false;
            }
            else if (islemTur == "guncelleme")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\Edit-Document-icon.png");
                btnPersonelIslem.Text = "PERSONEL GÜNCELLE";
                txtPersonelAdSoyad.Enabled = false;
            }
            else if (islemTur == "idarama")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\Search-icon.png");
                label1.Text = "Aramak istediğiniz personelin ID değerini seçiniz.";
                this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                txtPersonelAdSoyad.Enabled = false;
                TxtPersonelID.Enabled = true;
                btnPersonelIslem.Text = "PERSONEL ARA";
            }
            else if (islemTur == "isimarama")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\Search-icon.png");
                label1.Text = "Aramak istediğiniz personelin ismini seçiniz.";
                this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                TxtPersonelID.Enabled = false;
                txtPersonelAdSoyad.Enabled = true;
                btnPersonelIslem.Text = "PERSONEL ARA";
            }

        }

        private void btnPersonelIslem_Click(object sender, EventArgs e)
        {
            if (islemTur == "silme")
            {
                SqlCommand komutSil = new SqlCommand("delete from Personel where PersonelID = @p1 ", bgl.baglanti());
                komutSil.Parameters.AddWithValue("@p1", TxtPersonelID.Text);
                komutSil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Silme İşlemi Gerçekleşti", "Personel Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (islemTur == "guncelleme")
            {
                frmPersonelAyrintiIslem frm = new frmPersonelAyrintiIslem(TxtPersonelID.Text, "guncelleme");
                frm.ShowDialog();
            }
            else if (islemTur == "idarama")
            {
                frmPersonelAyrintiIslem frm = new frmPersonelAyrintiIslem(TxtPersonelID.Text, "idarama");
                frm.ShowDialog();
            }
            else if (islemTur == "isimarama")
            {
                frmPersonelAyrintiIslem frm = new frmPersonelAyrintiIslem(TxtPersonelID.Text, "isimarama");
                frm.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex;
            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;

            TxtPersonelID.Text = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            txtPersonelAdSoyad.Text = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString() + " " +
            dataGridView1.Rows[secilenIndex].Cells[2].Value.ToString();
        }
    }
}
