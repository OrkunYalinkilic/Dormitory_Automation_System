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
    public partial class frmMusteriSil : Form
    {
        public frmMusteriSil()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        int silenecekID;
        private void frmMusteriSil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet38.tblMusteri' table. You can move, or remove it, as needed.
            this.tblMusteriTableAdapter1.Fill(this.yurtOtomasyonuDataSet38.tblMusteri);
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet37.tblMusteri' table. You can move, or remove it, as needed.
            this.tblMusteriTableAdapter.Fill(this.yurtOtomasyonuDataSet37.tblMusteri);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("execute MusteriSil @ID=@p1", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", silenecekID);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.tblMusteriTableAdapter1.Fill(this.yurtOtomasyonuDataSet38.tblMusteri);
            MessageBox.Show("Müşteri silme işlemi gerçekleşti", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            silenecekID = int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
        }
    }
}
