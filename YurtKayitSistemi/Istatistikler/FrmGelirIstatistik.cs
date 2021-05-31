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
    public partial class FrmGelirIstatistik : Form
    {
        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        {
            //Kasadaki toplamtutar
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktar) from Kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasadakiPara.Text = oku[0].ToString() + " TL" ;
            }
            bgl.baglanti().Close();

            //Tekrarsız olarak ayları listeleme
            SqlCommand komut2 = new SqlCommand("select distinct(OdemeAy) from Kasa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbAy.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            //// Aylık Kazanç Manuel  
            //this.chart1.Series["Aylık"].Points.AddXY("Nisan",15);
            //this.chart1.Series["Aylık"].Points.AddXY("Mayıs" , 22);
            //this.chart1.Series["Aylık"].Points.AddY(13);

            // Grafiklere veritabanından veri çekme
            SqlCommand komut3 = new SqlCommand("select * from Kasa", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0].ToString().Substring(0,2),oku3[1]);
            }

        }

        private void CmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen aya göre kazancı listeleme
            SqlCommand komut = new SqlCommand("select * from Kasa where OdemeAy=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbAy.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblSecilenAyPara.Text = oku[1].ToString() + " TL";
            }
            bgl.baglanti().Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
