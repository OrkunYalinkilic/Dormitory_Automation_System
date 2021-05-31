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
    public partial class frmDuyuruAyrinti : Form
    {
        string baslik;
        public frmDuyuruAyrinti(string _baslik)
        {
            baslik = _baslik;
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void frmDuyuruAyrinti_Load(object sender, EventArgs e)
        {
            txtDuyuruBaslik.Text = baslik.ToUpper();

            SqlCommand duyuruCek = new SqlCommand("select duyuruicerik from Duyurular where duyuruBaslik=@p1", bgl.baglanti());
            duyuruCek.Parameters.AddWithValue("@p1", baslik);
            duyuruCek.ExecuteNonQuery();
            SqlDataReader oku = duyuruCek.ExecuteReader();
            while (oku.Read())
            {
                rchDuyuruIcerik.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
