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
    public partial class frmBorcGoruntuleme : Form
    {
        string islem, id, zaman;
        public frmBorcGoruntuleme(string _islem, string _id, string _zaman)
        {
            zaman = _zaman;
            islem = _islem; id = _id;
            InitializeComponent();
        }

        private void mskTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Close();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            frmBorcOdemeAl frm = new frmBorcOdemeAl(id, zaman);
            frm.Show();
        }

        private void frmBorcGoruntuleme_Load(object sender, EventArgs e)
        {
            if (islem == "goruntuleme" || islem == "ogrGoruntuleme")
            {
                btnOdemeYap.Visible = false;
                this.Height -= 30;
            }

            if (islem == "ogrGoruntuleme")
            {
                string okunanID="";
                SqlCommand idCek = new SqlCommand("select OgrID from Ogrenci where OgrKullaniciAdi = @a1", bgl.baglanti());
                idCek.Parameters.AddWithValue("@a1", id);
                idCek.ExecuteNonQuery();
                SqlDataReader idOku = idCek.ExecuteReader();
                while (idOku.Read())
                {
                    okunanID = idOku[0].ToString();
                }
                bgl.baglanti();

                SqlCommand komutOde = new SqlCommand("select *from Borclar where OgrID=@p1", bgl.baglanti());
                komutOde.Parameters.AddWithValue("@p1", okunanID);
                komutOde.ExecuteNonQuery();
                SqlDataReader oku = komutOde.ExecuteReader();
                while (oku.Read())
                {
                    txtOgrID.Text = oku[0].ToString();
                    txtAd.Text = oku[1].ToString();
                    txtSoyad.Text = oku[2].ToString();
                    txtBorc.Text = oku[3].ToString();
                }
                bgl.baglanti().Close();

            }
            else
            {
                SqlCommand komutOde = new SqlCommand("select *from Borclar where OgrID=@p1", bgl.baglanti());
                komutOde.Parameters.AddWithValue("@p1", id);
                komutOde.ExecuteNonQuery();
                SqlDataReader oku = komutOde.ExecuteReader();
                while (oku.Read())
                {
                    txtOgrID.Text = oku[0].ToString();
                    txtAd.Text = oku[1].ToString();
                    txtSoyad.Text = oku[2].ToString();
                    txtBorc.Text = oku[3].ToString();
                }
                bgl.baglanti().Close();
            }
        }
    }
}
