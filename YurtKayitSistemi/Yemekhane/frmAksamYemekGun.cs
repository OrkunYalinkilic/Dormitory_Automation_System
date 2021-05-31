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
    public partial class frmAksamYemekGun : Form
    {
        public frmAksamYemekGun()
        {
            InitializeComponent();
        }

        private void frmAksamYemekGun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet25.Yemekhane' table. You can move, or remove it, as needed.
            this.yemekhaneTableAdapter.Fill(this.yurtOtomasyonuDataSet25.Yemekhane);

        }

        string secilenId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex = dataGridView1.SelectedCells[0].RowIndex;
            txtSecilenAy.Text = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();
            txtSecilenGun.Text = dataGridView1.Rows[secilenIndex].Cells[2].Value.ToString();
            secilenId = dataGridView1.Rows[secilenIndex].Cells[8].Value.ToString();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmSecilenYemekAyrinti frm = new frmSecilenYemekAyrinti(secilenId);
            frm.ShowDialog();
        }
    }
}
