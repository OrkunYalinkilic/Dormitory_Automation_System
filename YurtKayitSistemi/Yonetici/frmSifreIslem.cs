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
    public partial class frmSifreIslem : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        Yonetici yoneticiGelen;
        public frmSifreIslem(Yonetici _yoneticiGelen)
        {
            yoneticiGelen = _yoneticiGelen;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSifreEski.Text != yoneticiGelen.sifre)
            {
                MessageBox.Show("Girdiğiniz eski şifre YANLIŞ", "Hatalı Şifre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifreEski.Text = string.Empty;
                txtSifreYeni.Text = string.Empty;
            }
            else
            {
                if (string.IsNullOrEmpty(txtSifreYeni.Text) == true || string.IsNullOrEmpty(txtSifreEski.Text))
                {
                    MessageBox.Show("Değerler boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrEmpty(txtSifreYeni.Text) == true)
                {
                    MessageBox.Show("Yeni Şifre boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtSifreYeni.Text.Length <= 5)
                {
                    MessageBox.Show("Yeni Şifre 5 karakterden fazla olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmdDegistir = new SqlCommand("update Admin set YoneticiSifre=@p1 where YoneticiAdi=@p2", bgl.baglanti());
                    cmdDegistir.Parameters.AddWithValue("@p1", txtSifreYeni.Text);
                    cmdDegistir.Parameters.AddWithValue("@p2", yoneticiGelen.kullaniciAdi);
                    cmdDegistir.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Şifre değiştirildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void frmSifreIslem_Load(object sender, EventArgs e)
        {

        }

        private void txtSifreYeni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSifreEski_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
