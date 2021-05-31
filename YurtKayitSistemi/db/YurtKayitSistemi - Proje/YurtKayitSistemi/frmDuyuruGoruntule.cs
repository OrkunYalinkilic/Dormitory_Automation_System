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
    public partial class frmDuyuruGoruntule : Form
    {
        public frmDuyuruGoruntule()
        {
            InitializeComponent();
        }

        private void frmDuyuruGoruntule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet34.Duyurular' table. You can move, or remove it, as needed.
            this.duyurularTableAdapter.Fill(this.yurtOtomasyonuDataSet34.Duyurular);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string baslik = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frmDuyuruAyrinti frm = new frmDuyuruAyrinti(baslik);
            frm.ShowDialog();
        }
    }
}
