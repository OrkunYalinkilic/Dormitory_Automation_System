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
    public partial class frmMagazaIstatistik : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public frmMagazaIstatistik()
        {
            InitializeComponent();
        }

        private void frmMagazaIstatistik_Load(object sender, EventArgs e)
        {
            SqlCommand al = new SqlCommand("select *from tblIstatistik", bgl.baglanti());
            al.ExecuteNonQuery();
            SqlDataReader oku = al.ExecuteReader();
            while (oku.Read())
            {
                txtPersonelSayi.Text = oku[0].ToString();
                txtMusteriSayi.Text = oku[1].ToString();
                txtUrunSayisi.Text = oku[2].ToString();
                txtIslemSayisi.Text = oku[3].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand al2 = new SqlCommand("select *from tblKasa", bgl.baglanti());
            al2.ExecuteNonQuery();
            SqlDataReader oku2 = al2.ExecuteReader();
            while (oku2.Read())
            {
                txtKasa.Text = oku2[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
