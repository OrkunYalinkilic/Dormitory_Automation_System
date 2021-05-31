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
    public partial class frmGiderIstatistik : Form
    {
        public frmGiderIstatistik()
        {
            InitializeComponent();
        }

        //SqlBaglantim bgl = new SqlBaglantim();

        private void frmGiderIstatistik_Load(object sender, EventArgs e)
        {
            ////Giderleri listeleme
            //CmbGiderSecim.Items.Add("Elektrik"); CmbGiderSecim.Items.Add("Su");
            //CmbGiderSecim.Items.Add("Dogalgaz"); CmbGiderSecim.Items.Add("Internet");
            //CmbGiderSecim.Items.Add("Gida"); CmbGiderSecim.Items.Add("Personel");
            //CmbGiderSecim.Items.Add("Diger");

            //// Grafiklere veritabanından veri çekme
            //SqlCommand komut3 = new SqlCommand("select SUM(Elektrik),SUM(Su),SUM(Dogalgaz),SUM(Internet), SUM(Gida), SUM(Personel), SUM(Diger) from Giderler", bgl.baglanti());
            //SqlDataReader oku3 = komut3.ExecuteReader();
            //while (oku3.Read())
            //{
            //    this.chart1.Series["Gider"].Points.AddXY(oku3[0].ToString(), "Elektrik");
            //    this.chart1.Series["Gider"].Points.AddXY(oku3[0].ToString(), "Su");
            //    this.chart1.Series["Gider"].Points.AddXY(oku3[0].ToString(), "Doğalgaz");
            //    this.chart1.Series["Gider"].Points.AddXY(oku3[0].ToString(), "İnternet");
            //    this.chart1.Series["Gider"].Points.AddXY(oku3[0].ToString(), "Gida");
            //    this.chart1.Series["Gider"].Points.AddXY(oku3[0].ToString(), "Personel");
            //    this.chart1.Series["Gider"].Points.AddXY(oku3[0].ToString(), "Diğer");
            //}
            //bgl.baglanti().Close();
        }
        private void CmbGiderSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Seçilen aya göre gideri listeleme
            //SqlCommand komut = new SqlCommand("select SUM(@p1) from Giderler", bgl.baglanti());
            //komut.Parameters.AddWithValue("@p1", CmbGiderSecim.Text);
            //SqlDataReader oku = komut.ExecuteReader();
            //while (oku.Read())
            //{
            //    lblGiderMiktarı.Text = oku[0].ToString() ;
            //}
            //bgl.baglanti().Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
