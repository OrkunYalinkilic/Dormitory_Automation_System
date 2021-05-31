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
    public partial class frmGiderIstatistikleri : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public frmGiderIstatistikleri()
        {
            InitializeComponent();
        }

        private void frmGiderIstatistikleri_Load(object sender, EventArgs e)
        {
            SqlCommand giderCek = new SqlCommand("select SUM(Elektrik),SUM(Su),SUM(Dogalgaz),SUM(Internet), SUM(Gida), SUM(Personel), SUM(Diger) from Giderler", bgl.baglanti());
            giderCek.ExecuteNonQuery();
            SqlDataReader oku = giderCek.ExecuteReader();
            while (oku.Read())
            {
                lblElektrik.Text = oku[0].ToString() + " TL";
                lblSu.Text = oku[1].ToString() + " TL";
                lblDogalgaz.Text = oku[2].ToString() + " TL";
                lblInternet.Text = oku[3].ToString() + " TL";
                lblGida.Text = oku[4].ToString() + " TL";
                lblPersonel.Text = oku[5].ToString() + " TL";
                lblDiger.Text = oku[6].ToString() + " TL";
            }
            bgl.baglanti().Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
