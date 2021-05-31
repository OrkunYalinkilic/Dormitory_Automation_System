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
    public partial class BorcIslemleri : Form
    {
        string islem,zaman;
        public BorcIslemleri(string _islem,string _zaman)
        {
            zaman = _zaman;
            islem = _islem;
            InitializeComponent();
        }

        private void BorcIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet31.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet31.Borclar);
        }
        string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            id = txtID.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (islem == "odeme")
            {
                frmBorcGoruntuleme frm = new frmBorcGoruntuleme("odeme", id,zaman);
                frm.ShowDialog();
            }
            else if (islem == "goruntuleme")
            {
                frmBorcGoruntuleme frm = new frmBorcGoruntuleme("goruntuleme", id,zaman);
                frm.ShowDialog();
            }
           
        }
    }
}
