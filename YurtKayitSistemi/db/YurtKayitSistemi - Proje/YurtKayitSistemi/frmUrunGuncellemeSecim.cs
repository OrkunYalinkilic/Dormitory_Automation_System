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
    public partial class frmUrunGuncellemeSecim : Form
    {
        public frmUrunGuncellemeSecim()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int Secilen,id;
            Secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = int.Parse(dataGridView1.Rows[Secilen].Cells[0].Value.ToString());

            frmUrunGuncellemeIslem frm = new frmUrunGuncellemeIslem(id);
            frm.ShowDialog();
        }

        private void frmUrunGuncellemeSecim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet36.tblUrunler' table. You can move, or remove it, as needed.
            this.tblUrunlerTableAdapter1.Fill(this.yurtOtomasyonuDataSet36.tblUrunler);

        }
    }
}
