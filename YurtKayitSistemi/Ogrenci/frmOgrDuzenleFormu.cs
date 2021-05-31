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
    public partial class frmOgrDuzenleFormu : Form
    {
        public frmOgrDuzenleFormu()
        {
            InitializeComponent();
        }

        private void frmOgrDuzenleFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet13.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter1.Fill(this.yurtOtomasyonuDataSet13.Ogrenci);
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet12.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet12.Ogrenci);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex;
            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle fr = new FrmOgrDuzenle();
            fr.id = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilenIndex].Cells[2].Value.ToString();
            fr.tc = dataGridView1.Rows[secilenIndex].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilenIndex].Cells[4].Value.ToString();
            fr.bolum = dataGridView1.Rows[secilenIndex].Cells[5].Value.ToString();
            fr.dogum = dataGridView1.Rows[secilenIndex].Cells[6].Value.ToString();
            fr.mail = dataGridView1.Rows[secilenIndex].Cells[8].Value.ToString();
            fr.odano = dataGridView1.Rows[secilenIndex].Cells[7].Value.ToString();
            fr.veliadsoyad = dataGridView1.Rows[secilenIndex].Cells[9].Value.ToString();
            fr.velitelefon = dataGridView1.Rows[secilenIndex].Cells[10].Value.ToString();
            fr.veliadres = dataGridView1.Rows[secilenIndex].Cells[11].Value.ToString();
            fr.Show();
        }
    }
}
