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
    public partial class FrmGiderDuzenle : Form
    {
        Giderler gelenGider;
        public FrmGiderDuzenle(Giderler _gelenGider)
        {
            gelenGider = _gelenGider;
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    item.Text = "0";
                }
            }

            if (YardimciSinif.sayiKontrol(txtElektrik.Text, txtSu.Text, txtDogalgaz.Text, txtGida.Text, txtInternet.Text, txtDiger.Text, txtPersonel.Text) == false)
            {
                MessageBox.Show("**Sayı girilmesi gereken bilgiler HARF İÇERMEMELİ.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Giderler guncel = new Giderler();
                guncel.odemeID = int.Parse(txtGiderID.Text);
                guncel.elektrik = int.Parse(txtElektrik.Text);
                guncel.su = int.Parse(txtSu.Text);
                guncel.dogalgaz = int.Parse(txtDogalgaz.Text);
                guncel.internet = int.Parse(txtInternet.Text);
                guncel.gida = int.Parse(txtGida.Text);
                guncel.personel = int.Parse(txtPersonel.Text);
                guncel.diger = int.Parse(txtDiger.Text);

                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p2, su=@p3, Dogalgaz=@p4, Internet=@p5, Gida=@p6, Personel=@p7, Diger=@p8 where OdemeID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", guncel.odemeID);
                komut.Parameters.AddWithValue("@p2", guncel.elektrik);
                komut.Parameters.AddWithValue("@p3", guncel.su);
                komut.Parameters.AddWithValue("@p4", guncel.dogalgaz);
                komut.Parameters.AddWithValue("@p5", guncel.internet);
                komut.Parameters.AddWithValue("@p6", guncel.gida);
                komut.Parameters.AddWithValue("@p7", guncel.personel);
                komut.Parameters.AddWithValue("@p8", guncel.diger);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Guncelleme işlemi gerceklesti.", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Application.OpenForms["FrmGiderGuncellecs"].Close();
            }
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmGiderDuzenle_Load(object sender, EventArgs e)
        {
            txtGiderID.Text = gelenGider.odemeID.ToString();
            txtElektrik.Text = gelenGider.elektrik.ToString();
            txtGida.Text = gelenGider.gida.ToString();
            txtSu.Text = gelenGider.su.ToString();
            txtPersonel.Text = gelenGider.personel.ToString();
            txtInternet.Text = gelenGider.internet.ToString();
            txtDiger.Text = gelenGider.diger.ToString();
            txtDogalgaz.Text = gelenGider.dogalgaz.ToString();
        }
    }
}
