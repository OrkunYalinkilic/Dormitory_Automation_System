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
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void frmKasa_Load(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("select *from KasaToplam", bgl.baglanti());
            getir.ExecuteNonQuery();
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                textBox1.Text = oku[0].ToString() + " TL";
            }
            bgl.baglanti().Close();
        }
    }
}
