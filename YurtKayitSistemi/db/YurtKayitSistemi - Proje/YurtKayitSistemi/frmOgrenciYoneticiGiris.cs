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
    public partial class frmOgrenciYoneticiGiris : Form
    {
        public frmOgrenciYoneticiGiris()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void btnSecimOgrenci_Click(object sender, EventArgs e)
        {
            grpOgrenci.Enabled = true;
            btnSecimOgrenci.Enabled = false;
            btnSecimYonetici.Enabled = false;
            grpOgrenci.Text.ToString().ToUpper();
           // grpOgrenci.BackColor = Color.LightYellow;
            #region tasarımIslemleri

            label5.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label5.Location = new System.Drawing.Point(22, 66);
            label5.Size = new System.Drawing.Size(140, 21);

            label6.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label6.Location = new System.Drawing.Point(83, 112);
            label6.Size = new System.Drawing.Size(78, 21);

            btnGirisOgrenci.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnGirisOgrenci.Location = new System.Drawing.Point(192, 158);
            btnGirisOgrenci.Size = new System.Drawing.Size(204, 43);

            txtOgrenciKullaniciAd.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            txtOgrenciKullaniciAd.Location = new System.Drawing.Point(168, 61);
            txtOgrenciKullaniciAd.Size = new System.Drawing.Size(249, 29);

            txtOgrenciParola.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            txtOgrenciParola.Location = new System.Drawing.Point(167, 109);
            txtOgrenciParola.Size = new System.Drawing.Size(249, 29);

            #endregion
        }

        private void btnSecimYonetici_Click(object sender, EventArgs e)
        {
            grpYonetici.Enabled = true;
            btnSecimOgrenci.Enabled = false;
            btnSecimYonetici.Enabled = false;
            grpYonetici.Text.ToString().ToUpper();
           // grpYonetici.BackColor = Color.LightYellow;
            #region tasarımIslemleri

            label3.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label3.Location = new System.Drawing.Point(17, 69);
            label3.Size = new System.Drawing.Size(140, 21);

            label4.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label4.Location = new System.Drawing.Point(78, 115);
            label4.Size = new System.Drawing.Size(78, 21);

            txtYoneticiKullaniciAd.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            txtYoneticiKullaniciAd.Location = new System.Drawing.Point(163, 64);
            txtYoneticiKullaniciAd.Size = new System.Drawing.Size(249, 29);

            txtYoneticiParola.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            txtYoneticiParola.Location = new System.Drawing.Point(162, 112);
            txtYoneticiParola.Size = new System.Drawing.Size(249, 29);

            btnGirisYonetici.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnGirisYonetici.Location = new System.Drawing.Point(186, 158);
            btnGirisYonetici.Size = new System.Drawing.Size(207, 43);

            #endregion
        }

        private void frmOgrenciYoneticiGiris_Load(object sender, EventArgs e)
        {
        }

        private void btnGirisYonetici_Click(object sender, EventArgs e)
        {
            Yonetici yonetici1 = new Yonetici();
            yonetici1.kullaniciAdi = txtYoneticiKullaniciAd.Text;
            yonetici1.sifre = txtYoneticiParola.Text;

            if (yonetici1.LogIn() == false)
            {
                MessageBox.Show("Hatalı Giriş Yapıldı.\n\nLütfen Geçerli Kullanıcı Adı ve Parola Giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYoneticiKullaniciAd.Focus();
            }
            else
            {
                yonetici1.LogIn();
            }
            txtYoneticiKullaniciAd.Text = string.Empty;
            txtYoneticiParola.Text = string.Empty;
        }

        private void btnGirisOgrenci_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.kullaniciAdi = txtOgrenciKullaniciAd.Text;
            ogrenci1.sifre = txtOgrenciParola.Text;

            if (ogrenci1.LogIn()==false)
            {
                MessageBox.Show("Hatalı Giriş Yapıldı.\n\nLütfen Geçerli Kullanıcı Adı ve Parola Giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOgrenciKullaniciAd.Focus();
            }
            else
            {
                ogrenci1.LogIn();
            }

            txtOgrenciKullaniciAd.Text = string.Empty;
            txtOgrenciParola.Text = string.Empty;

        }
    }
}
