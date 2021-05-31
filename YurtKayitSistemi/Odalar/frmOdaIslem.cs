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
    public partial class frmOdaIslem : Form
    {
        string islem, odano;
        public frmOdaIslem(string _islem, string _odano)
        {
            islem = _islem; odano = _odano;
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();


        private void frmOdaIslem_Load(object sender, EventArgs e)
        {
            if (islem == "ekleme")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\add2.png");

            }
            else if (islem == "arama")
            {
                List<string> odalar = new List<string>();
                SqlCommand odalarDB = new SqlCommand("select OdaNo from Odalar", bgl.baglanti());
                SqlDataReader odalarOku = odalarDB.ExecuteReader();
                while (odalarOku.Read())
                {
                    for (int i = 0; i < odalarOku.FieldCount; i++)
                    {
                        odalar.Add(odalarOku[i].ToString());
                    }
                }

                if (string.IsNullOrEmpty(odano))
                {
                    MessageBox.Show("Bir oda numarasi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.OpenForms[3].Close();
                }

                else if (YardimciSinif.sayiKontrol(odano) == false)
                {
                    MessageBox.Show("Oda Numarasi HARF İÇEREMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.OpenForms[3].Close();
                    //Application.OpenForms[2].Close();
                    Application.OpenForms[1].Close();
                }

                else if (!odalar.Contains(odano))
                {
                    MessageBox.Show(odano + " odası MEVCUT DEĞİL", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOdaNo.Text = string.Empty;
                    Application.OpenForms[3].Close();
                    //Application.OpenForms[2].Close();
                    Application.OpenForms[1].Close();
                    
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Orkun YALINKILIÇ\Desktop\YurtKayitSistemi\image\Search-icon.png");
                    button1.Visible = false;
                    this.Height -= 50;
                    txtOdaAktif.Enabled = false;
                    txtOdaKapasite.Enabled = false;
                    txtOdaNo.Enabled = false;

                    Oda arananOda = new Oda();
                    SqlCommand cmd2 = new SqlCommand("select *from Odalar where OdaNo=@z1", bgl.baglanti());
                    cmd2.Parameters.AddWithValue("@z1", odano);
                    cmd2.ExecuteNonQuery();

                    SqlDataReader oku = cmd2.ExecuteReader();

                    while (oku.Read())
                    {
                        arananOda.odaID = int.Parse(oku[0].ToString());
                        arananOda.OdaNo = oku[1].ToString();
                        arananOda.odaKapasite = oku[2].ToString();
                        arananOda.kalanKisi = int.Parse(oku[3].ToString());
                        arananOda.odaDurumu = bool.Parse(oku[4].ToString());
                    }
                    bgl.baglanti().Close();
                    txtOdaID.Text = arananOda.odaID.ToString();
                    txtOdaNo.Text = arananOda.OdaNo;
                    txtOdaKapasite.Text = arananOda.odaKapasite;
                    txtOdaAktif.Text = arananOda.kalanKisi.ToString();
                    txtOdaDurum.Text = arananOda.odaDurumu.ToString();
                    Application.OpenForms[2].Close();
                    Application.OpenForms[1].Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (islem == "ekleme")
            {
                if (string.IsNullOrEmpty(txtOdaNo.Text) || string.IsNullOrEmpty(txtOdaKapasite.Text) || string.IsNullOrEmpty(txtOdaAktif.Text))
                {
                    MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (YardimciSinif.sayiKontrol(txtOdaNo.Text, txtOdaKapasite.Text, txtOdaAktif.Text) == false)
                    {
                        MessageBox.Show("Değerler HARF İÇEREMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Oda yeniOda = new Oda();
                        yeniOda.OdaNo = txtOdaNo.Text;
                        yeniOda.odaKapasite = txtOdaKapasite.Text;
                        yeniOda.kalanKisi = int.Parse(txtOdaAktif.Text);
                        SqlCommand cmd = new SqlCommand("insert into Odalar(OdaNo,OdaKapasite,OdaAktif) values (@p1,@p2,@p3)", bgl.baglanti());
                        cmd.Parameters.AddWithValue("@p1", yeniOda.OdaNo.ToString());
                        cmd.Parameters.AddWithValue("@p2", yeniOda.odaKapasite.ToString());
                        cmd.Parameters.AddWithValue("@p3", yeniOda.kalanKisi.ToString());
                        cmd.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Oda Ekleme İşlemi gerçekleşti.", "Oda Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}

