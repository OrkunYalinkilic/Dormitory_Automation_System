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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void frmSatis_Load(object sender, EventArgs e)
        {
            //Personelleri basma
            SqlCommand personelGetir = new SqlCommand("select *from PersonelGetir", bgl.baglanti());
            personelGetir.ExecuteNonQuery();
            SqlDataReader oku6 = personelGetir.ExecuteReader();
            while (oku6.Read())
            {
                cmbPersonel.Items.Add(oku6[0].ToString());
            }
            bgl.baglanti().Close();

            //Müşterileri basma
            SqlCommand musteriGetir = new SqlCommand("select *from MusteriGetir", bgl.baglanti());
            musteriGetir.ExecuteNonQuery();
            SqlDataReader oku = musteriGetir.ExecuteReader();
            while (oku.Read())
            {
                cmbMusteriler.Items.Add(oku[0].ToString() + " " + oku[1].ToString());
            }
            bgl.baglanti().Close();

            //Kategorileri basma
            SqlCommand kategoribas = new SqlCommand("select * from KategoriAdiGetir", bgl.baglanti());
            kategoribas.ExecuteNonQuery();
            SqlDataReader oku4 = kategoribas.ExecuteReader();
            while (oku4.Read())
            {
                CmbKategoriler.Items.Add(oku4[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void CmbKategoriler_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlCommand urungetir = new SqlCommand("execute urunleriGetir @kategoriAd=@p1", bgl.baglanti());
            urungetir.Parameters.AddWithValue("@p1", CmbKategoriler.Text);
            urungetir.ExecuteNonQuery();
            SqlDataReader oku5 = urungetir.ExecuteReader();
            while (oku5.Read())
            {
                CmbUrunler.Items.Add(oku5[0].ToString() + "| " + oku5[1].ToString() + " " + oku5[2].ToString() + "= " + oku5[3].ToString() + "TL");
            }
            bgl.baglanti().Close();

            CmbUrunler.Enabled = true;
        }
        string secilenId;
        private void CmbUrunler_SelectedValueChanged(object sender, EventArgs e)
        {
            char[] secilenText = (CmbUrunler.Text).ToArray();

            for (int i = 0; i < secilenText.Length; i++)
            {
                if (secilenText[i] != '|')
                {
                    secilenId += secilenText[i];
                }
                else
                {
                    break;
                }
            }

            SqlCommand stok = new SqlCommand("execute urunStokGetir @ID=@p1", bgl.baglanti());
            stok.Parameters.AddWithValue("@p1", int.Parse(secilenId));
            stok.ExecuteNonQuery();
            SqlDataReader oku = stok.ExecuteReader();
            int stokAdet = 0;
            while (oku.Read())
            {
                stokAdet = int.Parse(oku[0].ToString());
            }
            bgl.baglanti().Close();

            for (int i = 1; i <= stokAdet; i++)
            {
                cmbStok.Items.Add(i.ToString());
            }
            cmbStok.Enabled = true;

        }

        float fiyat;
        private void cmbStok_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlCommand fiyatCek = new SqlCommand("select urunSatisFiyat from tblUrunler where urunID=@a1 ", bgl.baglanti());
            fiyatCek.Parameters.AddWithValue("@a1", secilenId);
            fiyatCek.ExecuteNonQuery();
            SqlDataReader oku = fiyatCek.ExecuteReader();
            while (oku.Read())
            {
                fiyat = float.Parse(oku[0].ToString());
            }
            bgl.baglanti().Close();

            TxtTutar.Text = " " + (fiyat * float.Parse(cmbStok.Text)).ToString() + " TL";
            TxtTutar.Enabled = true;
        }

        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            // Hareket tablosuna ekleme
            SqlCommand hareketEkle = new SqlCommand("execute HareketEkle @PersonelAdiSoyadi=@s1 ,@MusteriAdiSoyadi=@s2 ," +
                "@urunID=@s3 ,@Adet=@s4 ,@tutar=@s5", bgl.baglanti());
            hareketEkle.Parameters.AddWithValue("@s1",cmbPersonel.Text );
            hareketEkle.Parameters.AddWithValue("@s2", YardimciSinif.boslukKaldir(cmbMusteriler.Text));
            hareketEkle.Parameters.AddWithValue("@s3",secilenId);
            hareketEkle.Parameters.AddWithValue("@s4",int.Parse(cmbStok.Text));
            hareketEkle.Parameters.AddWithValue("@s5", YardimciSinif.tutarCevir(TxtTutar.Text.ToString()));
            hareketEkle.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Stok azaltma
            SqlCommand stokAzalt = new SqlCommand("execute stokAzalt @urunID=@p1,@Adet=@p2", bgl.baglanti());
            stokAzalt.Parameters.AddWithValue("@p1",secilenId);
            stokAzalt.Parameters.AddWithValue("@p2",int.Parse(cmbStok.Text));
            stokAzalt.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Kasa arttırma
            SqlCommand kasa = new SqlCommand("execute kasaArtir @tutar=@z1", bgl.baglanti());
            kasa.Parameters.AddWithValue("@z1", YardimciSinif.tutarCevir(TxtTutar.Text.ToString()));
            kasa.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Müşteri Bakiye Arttırma
            SqlCommand arttır = new SqlCommand("execute musteriBakiyeArtir @tutar=@c1, @MusteriAdSoyad=@c2", bgl.baglanti());
            arttır.Parameters.AddWithValue("@c1", YardimciSinif.tutarCevir(TxtTutar.Text.ToString()));
            arttır.Parameters.AddWithValue("@c2", YardimciSinif.boslukKaldir(cmbMusteriler.Text));
            arttır.ExecuteNonQuery();
            bgl.baglanti().Close();

            //trigger'lar kendi işlemlerini yapıyor..

            MessageBox.Show(cmbMusteriler.Text + "\n" + CmbKategoriler.Text +  "\n" + cmbStok.Text + 
                " adet alındı."+ "\n" + TxtTutar.Text, "Satış Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }
    }
}
