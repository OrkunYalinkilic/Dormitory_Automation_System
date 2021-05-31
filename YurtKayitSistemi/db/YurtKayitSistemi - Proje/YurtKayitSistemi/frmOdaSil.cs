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
    public partial class frmOdaSil : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();

        public frmOdaSil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmOdaSil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet23.Odalar' table. You can move, or remove it, as needed.
            this.odalarTableAdapter.Fill(this.yurtOtomasyonuDataSet23.Odalar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex;
            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;
            txtOdaID.Text = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            txtOdaNo.Text = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("delete from Odalar where OdaID=@p1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@p1", txtOdaID.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.odalarTableAdapter.Fill(this.yurtOtomasyonuDataSet23.Odalar);
            MessageBox.Show("Oda Silme İşlemi Gerçekleştirildi", "Oda Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
