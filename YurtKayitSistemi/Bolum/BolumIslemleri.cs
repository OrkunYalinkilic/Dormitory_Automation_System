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
    public partial class BolumIslemleri : Form
    {
        string islem;
        public BolumIslemleri(string islemAdi)
        {
            islem = islemAdi;
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void BolumIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet9.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Bolumler);
            if (islem == "silme")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\Button-Close-icon.png");
                label1.Text = "Lütfen silmek istediğiniz bölümü seçiniz";
                btnBolumIslem.Text = "BÖLÜM SİL";
                TxtBolumAd.Enabled = false;
            }

            else if (islem == "guncelleme")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\Edit-Document-icon.png");
                label1.Text = "Güncellemek istediğiniz bölümü listeden secip,\n düzenlemenizi ad kutusuna giriniz.";
                this.label1.Location = new System.Drawing.Point(261, 34);
                btnBolumIslem.Text = "BÖLÜM GÜNCELLE";
                TxtBolumAd.Enabled = false;
            }

            else if (islem == "ekleme")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\add2.png");
                label1.Text = "Eklemek istediğiniz bölümün adını giriniz.";
                btnBolumIslem.Text = "BÖLÜM EKLE";
                dataGridView1.Visible = false;
                this.Height -= 260;
            }
            else if (islem == "ıdArama")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\Search-icon.png");
                label1.Text = "Aramak istediğiniz bolumun ID değerini seçiniz.";
                btnBolumIslem.Text = "BÖLÜMÜ ARA";
                TxtBolumId.Enabled = false;
                TxtBolumAd.Enabled = false;
                this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

            }
            else if (islem == "isimleArama")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\Search-icon.png");
                label1.Text = "Aramak istediğiniz bölümün ismini seçiniz.";
                btnBolumIslem.Text = "BÖLÜMÜ ARA";
                this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                TxtBolumId.Enabled = false;
                TxtBolumAd.Enabled = false;
            }
        }

        private void btnBolumIslem_Click(object sender, EventArgs e)
        {
            if (islem == "silme")
            {
                try
                {
                    SqlCommand komut2 = new SqlCommand("delete from Bolumler where BolumID = @p1", bgl.baglanti());
                    komut2.Parameters.AddWithValue("@p1", TxtBolumId.Text);
                    komut2.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Bolumler);
                    MessageBox.Show("Silme islemi gerceklestirildi", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Silme islemi gerceklestirilemedi", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (islem == "guncelleme")
            {

                if (string.IsNullOrEmpty(TxtBolumAd.Text))
                {
                    MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (YardimciSinif.stringKontrol(TxtBolumAd.Text) == false)
                    {
                        MessageBox.Show("**Yazi girilmesi gereken bilgiler RAKAM İÇERMEMELİ.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand komut2 = new SqlCommand("update Bolumler set BolumAd=@p1 where BolumID=@p2", bgl.baglanti());
                        komut2.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                        komut2.Parameters.AddWithValue("@p2", TxtBolumId.Text);
                        komut2.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Bolumler);
                        MessageBox.Show("Guncelleme islemi gerceklestirildi.", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }

            else if (islem == "ekleme")
            {
             /*  Bolum yeniBolum = new Bolum();
               yeniBolum.bolumAdi = TxtBolumAd.Text;
//
                if (yeniBolum.boslukKontrol() == true)
                {
                    if (YardimciSinif.stringKontrol(yeniBolum.bolumAdi) == false)
                    {
                        MessageBox.Show("**Yazi girilmesi gereken bilgiler RAKAM İÇERMEMELİ.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand komut1 = new SqlCommand(" insert into Bolumler(BolumAd) values(@p1)", bgl.baglanti());
                        komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                        komut1.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Bölüm ekleme işlemi gerçekleştirildi..", "Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }

            else if (islem == "ıdArama")
            {
                frmBolumAyrıntı frm = new frmBolumAyrıntı(TxtBolumAd.Text, TxtBolumId.Text);
                frm.ShowDialog();
            }
            else if (islem == "isimleArama")
            {
                frmBolumAyrıntı frm = new frmBolumAyrıntı(TxtBolumAd.Text, TxtBolumId.Text);
                frm.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex;
            string id;
            string bolumAdi;

            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;

            id = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            bolumAdi = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();

            TxtBolumId.Text = id;
            TxtBolumAd.Text = bolumAdi;

            if (islem == "guncelleme") TxtBolumAd.Enabled = true;
        }
    }
}
