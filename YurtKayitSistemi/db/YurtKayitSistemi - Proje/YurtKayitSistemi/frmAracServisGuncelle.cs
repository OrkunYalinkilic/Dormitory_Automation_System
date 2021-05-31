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
    public partial class frmAracServisGuncelle : Form
    {
        public frmAracServisGuncelle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void frmAracServisGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet30.ServisSaat' table. You can move, or remove it, as needed.
            this.servisSaatTableAdapter.Fill(this.yurtOtomasyonuDataSet30.ServisSaat);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex = dataGridView1.SelectedCells[0].RowIndex;
            Txtgun.Text = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            MskSaat.Text = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgnc = new SqlCommand("update ServisSaat set Saati=@p1 where GunAdi=@p2", bgl.baglanti());
            komutgnc.Parameters.AddWithValue("@p1",MskSaat.Text);
            komutgnc.Parameters.AddWithValue("@p2",Txtgun.Text);
            komutgnc.ExecuteNonQuery();
            MessageBox.Show("Servis saati güncelleme işlemi tamamlandı.", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
