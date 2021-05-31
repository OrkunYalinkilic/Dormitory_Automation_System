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
    public partial class YemekAlinanFirma : Form
    {
        public YemekAlinanFirma()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void YemekAlinanFirma_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from YemekFirma", bgl.baglanti());

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtFirmaAd.Text = (oku[0].ToString()).ToUpper();
                txtSahibi.Text = oku[1].ToString();
                txtSehir.Text = oku[2].ToString();
                txtIlce.Text = oku[3].ToString();
                txtKurulusYili.Text = oku[4].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
