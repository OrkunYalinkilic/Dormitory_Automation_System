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
    public partial class frmBolumAyrıntı : Form
    {
        string ad,id;
        public frmBolumAyrıntı(string ayrintiBolumAd,string ayrintiid)
        {
            ad = ayrintiBolumAd;
            id = ayrintiid;
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void frmBolumAyrıntı_Load(object sender, EventArgs e)
        {
            txtBlmAd.Text = ad;
            txtBlmID.Text = id;
            txtBaslik.Text = ad.ToUpper();
            label3.Text = ad + " bölümündeki öğrencilerin bilgileri";

            SqlCommand cmd = new SqlCommand("select OgrAd,OgrSoyad,OgrTelefon,OgrOdaNo from Ogrenci where OgrBolum =@z1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@z1", ad);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[0].HeaderText = "Adı";
            dataGridView1.Columns[1].HeaderText = "Soyadı";
            dataGridView1.Columns[2].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[3].HeaderText = "Oda No";

        }
    }
}
