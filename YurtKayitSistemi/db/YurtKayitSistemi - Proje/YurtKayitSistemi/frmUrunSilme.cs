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
    public partial class frmUrunSilme : Form
    {
        public frmUrunSilme()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void frmUrunSilme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet35.tblUrunler' table. You can move, or remove it, as needed.
            this.tblUrunlerTableAdapter.Fill(this.yurtOtomasyonuDataSet35.tblUrunler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Secilen;
            Secilen =  dataGridView1.SelectedCells[0].RowIndex;
            label2.Text = dataGridView1.Rows[Secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from tblUrunler where urunID=@p1", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", int.Parse(label2.Text));
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.tblUrunlerTableAdapter.Fill(this.yurtOtomasyonuDataSet35.tblUrunler);
            MessageBox.Show("Silme islemi gerçekleşti", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
