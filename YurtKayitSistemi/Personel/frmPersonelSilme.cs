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
    public partial class frmPersonelSilme : Form
    {
        public frmPersonelSilme()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        int silinecekID;
        private void frmPersonelSilme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet39.tblPersonel' table. You can move, or remove it, as needed.
            this.tblPersonelTableAdapter.Fill(this.yurtOtomasyonuDataSet39.tblPersonel);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            silinecekID = int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("execute PersonelSil @ID=@p1", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", silinecekID);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.tblPersonelTableAdapter.Fill(this.yurtOtomasyonuDataSet39.tblPersonel);
            MessageBox.Show("Silme islemi gerçekleşti", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
