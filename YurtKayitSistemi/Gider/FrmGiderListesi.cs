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
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet5.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter.Fill(this.yurtOtomasyonuDataSet5.Giderler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
