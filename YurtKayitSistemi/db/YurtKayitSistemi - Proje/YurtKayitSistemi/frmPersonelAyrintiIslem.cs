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
    public partial class frmPersonelAyrintiIslem : Form
    {
        string id, islem;
        public frmPersonelAyrintiIslem(string _id, string _islem)
        {
            id = _id; islem = _islem;
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        Personel p1 = new Personel();

        private void bilgileriGetir(string idNo)
        {
            SqlCommand cmd3 = new SqlCommand("select *from Personel where PersonelID=@z1", bgl.baglanti());
            cmd3.Parameters.AddWithValue("@z1", idNo);
            cmd3.ExecuteNonQuery();
            SqlDataReader oku = cmd3.ExecuteReader();

            while (oku.Read())
            {
                p1.personelID = int.Parse(oku[0].ToString());
                p1.adi = oku[1].ToString();
                p1.soyadi = oku[2].ToString();
                p1.departmani = oku[3].ToString();
                p1.maas = oku[4].ToString();
                p1.CepTelefonu = oku[5].ToString();
                p1.tcKimlikNo = oku[6].ToString();

                txtPersonelID.Text = p1.personelID.ToString();
                txtAd.Text = p1.adi;
                txtSoyad.Text = p1.soyadi;
                txtDepartmant.Text = p1.departmani;
                txtMaas.Text = p1.maas.ToString();
                mskTelefon.Text = p1.CepTelefonu;
                txtTCKimlikNo.Text = p1.tcKimlikNo;
            }

            bgl.baglanti().Close();
        }


        private void frmPersonelAyrintiIslem_Load(object sender, EventArgs e)
        {
            if (islem == "ekleme")
            {
                button1.Text = "PERSONEL EKLE";
            }
            else if (islem == "guncelleme")
            {
                bilgileriGetir(id);
                button1.Text = "GÜNCELLE";
            }

            else if (islem == "idarama" || islem == "isimarama")
            {
                bilgileriGetir(id);

                button1.Visible = false;
                this.Height -= 30;

                txtAd.Enabled = false;
                txtPersonelID.Enabled = false;
                txtMaas.Enabled = false;
                txtDepartmant.Enabled = false;
                mskTelefon.Enabled = false;
                txtSoyad.Enabled = false;
                txtTCKimlikNo.Enabled = false;
            }
        }

        private Personel YeniPersonel(string ad, string soyad, string tel, string maas, string tc, string dep)
        {
            Personel p = new Personel();
            p.adi = ad;
            p.soyadi = soyad;
            p.CepTelefonu = tel;
            p.maas = maas;
            p.tcKimlikNo = tc;
            p.departmani = dep;

            return p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (islem == "ekleme")
            {
                Personel yeni = YeniPersonel(txtAd.Text, txtSoyad.Text, mskTelefon.Text, txtMaas.Text, txtTCKimlikNo.Text,
                    txtDepartmant.Text);

                if (yeni.boslukKontrol() == true)
                {
                    if (YardimciSinif.stringKontrol(yeni.adi, yeni.soyadi, yeni.departmani) == false)
                    {
                        MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (YardimciSinif.sayiKontrol(yeni.tcKimlikNo, yeni.maas.ToString())==false)
                    {
                        MessageBox.Show("**Sayı girilmesi gereken bilgiler harf içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("insert into Personel (PersonelAd,PersonelSoyad,PersonelDepartman," +
                                                        "PersonelMaas,PersonelTelefonNo,PersonelTCKimlikNo) " +
                                                        "values (@a1,@a2,@a3,@a4,@a5,@a6)", bgl.baglanti());
                        cmd.Parameters.AddWithValue("@a1", yeni.adi);
                        cmd.Parameters.AddWithValue("@a2", yeni.soyadi);
                        cmd.Parameters.AddWithValue("@a3", yeni.departmani);
                        cmd.Parameters.AddWithValue("@a4", yeni.maas.ToString());
                        cmd.Parameters.AddWithValue("@a5", yeni.CepTelefonu);
                        cmd.Parameters.AddWithValue("@a6", yeni.tcKimlikNo);
                        cmd.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Personel Ekleme gerçekleşti.", "Personel Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (islem == "guncelleme")
            {
                SqlCommand cmd2 = new SqlCommand("update Personel set PersonelAd=@b1,PersonelSoyad=@b2,PersonelDepartman=@b3,PersonelMaas=@b4,PersonelTelefonNo=@b5,PersonelTCKimlikNo=@b6 where PersonelID=@b7", bgl.baglanti());
                cmd2.Parameters.AddWithValue("@b1", txtAd.Text);
                cmd2.Parameters.AddWithValue("@b2", txtSoyad.Text);
                cmd2.Parameters.AddWithValue("@b3", txtDepartmant.Text);
                cmd2.Parameters.AddWithValue("@b4", txtMaas.Text);
                cmd2.Parameters.AddWithValue("@b5", mskTelefon.Text);
                cmd2.Parameters.AddWithValue("@b6", txtTCKimlikNo.Text);
                cmd2.Parameters.AddWithValue("@b7", p1.personelID);
                cmd2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Güncelleme gerçekleşti.", "Personel Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Application.OpenForms[1].Close();
            }
            else if (islem == "idarama" || islem == "isimarama")
            {
                /**/
            }
            }


        }
    }
