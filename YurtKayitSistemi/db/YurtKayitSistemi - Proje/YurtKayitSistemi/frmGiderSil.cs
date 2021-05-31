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
    public partial class frmGiderSil : Form
    {
        public frmGiderSil()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void frmGiderSil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet16.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter.Fill(this.yurtOtomasyonuDataSet16.Giderler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex;

            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;
            txtGiderID.Text = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
        }

        private void btnGiderSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("delete from Giderler where OdemeID=@p1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@p1", txtGiderID.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.giderlerTableAdapter.Fill(this.yurtOtomasyonuDataSet16.Giderler);
            MessageBox.Show("Ödeme silme işlemi gerçekleştirildi", "Ödeme Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
