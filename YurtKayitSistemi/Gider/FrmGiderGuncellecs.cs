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
    public partial class FrmGiderGuncellecs : Form
    {
        public FrmGiderGuncellecs()
        {
            InitializeComponent();
        }

        private void FrmGiderGuncellecs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet15.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter.Fill(this.yurtOtomasyonuDataSet15.Giderler);

        }
        Giderler GuncelGider;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex;
            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;
            Giderler GuncelGider = new Giderler();

            GuncelGider.odemeID = (int)dataGridView1.Rows[secilenIndex].Cells[0].Value;
            GuncelGider.elektrik = (int)dataGridView1.Rows[secilenIndex].Cells[1].Value;
            GuncelGider.su = (int)dataGridView1.Rows[secilenIndex].Cells[2].Value;
            GuncelGider.dogalgaz = (int)dataGridView1.Rows[secilenIndex].Cells[3].Value;
            GuncelGider.internet = (int)dataGridView1.Rows[secilenIndex].Cells[4].Value;
            GuncelGider.gida = (int)dataGridView1.Rows[secilenIndex].Cells[5].Value;
            GuncelGider.personel = (int)dataGridView1.Rows[secilenIndex].Cells[6].Value;
            GuncelGider.diger = (int)dataGridView1.Rows[secilenIndex].Cells[7].Value;

            FrmGiderDuzenle frg = new FrmGiderDuzenle(GuncelGider);
            frg.ShowDialog();

        }
    }
}
