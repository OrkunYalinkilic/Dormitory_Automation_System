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
    public partial class frmSatisHareketGoruntuleme : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();

        public frmSatisHareketGoruntuleme()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSatisHareketGoruntuleme_Load(object sender, EventArgs e)
        {
            SqlCommand cek = new SqlCommand("execute SatisHareketleri", bgl.baglanti());
            cek.ExecuteNonQuery();

            DataTable satisHareket = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cek);

            adapter.Fill(satisHareket);

            dataGridView1.DataSource = satisHareket;
        }
    }
}
