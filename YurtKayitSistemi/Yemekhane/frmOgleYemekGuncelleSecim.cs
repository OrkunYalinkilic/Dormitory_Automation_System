using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class frmOgleYemekGuncelleSecim : Form
    {
        public frmOgleYemekGuncelleSecim()
        {
            InitializeComponent();
        }

        private void frmOgleYemekGuncelleSecim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet26.Yemekhane' table. You can move, or remove it, as needed.
            this.yemekhaneTableAdapter.Fill(this.yurtOtomasyonuDataSet26.Yemekhane);

        }
        string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtYil.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAy.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtGun.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            id = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmYemekGuncellemeSayfasi frm = new frmYemekGuncellemeSayfasi(id);
            frm.ShowDialog();
        }
    }
}
