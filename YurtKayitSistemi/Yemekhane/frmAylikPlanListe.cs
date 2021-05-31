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
    public partial class frmAylikPlanListe : Form
    {
        string ogun, ay;
        public frmAylikPlanListe(string _ogun, string _ay)
        {
            ogun = _ogun; ay = _ay;
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void frmAylikPlanListe_Load(object sender, EventArgs e)
        {
            txtAy.Text = ay;
            txtOgun.Text = ogun;

            if (YardimciSinif.stringKontrol(ay) == false)
            {
                MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.OpenForms[3].Close();
            }

            else if (string.IsNullOrEmpty(ay) == true)
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.OpenForms[3].Close();
            }

            else
            {
                SqlCommand komut = new SqlCommand("select GunSirasi,YemekBir,YemekIki,YemekUc,YemekDort from Yemekhane where YemekOgun=@p1 AND AyAdi=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", ogun);
                komut.Parameters.AddWithValue("@p2", ay);
                komut.ExecuteNonQuery();

                SqlDataAdapter adp = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
    }
}
