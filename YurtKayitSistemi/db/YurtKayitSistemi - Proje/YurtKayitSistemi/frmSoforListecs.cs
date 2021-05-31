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
    public partial class frmSoforListecs : Form
    {
        public frmSoforListecs()
        {
            InitializeComponent();
        }

        private void frmSoforListecs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet28.Soforler' table. You can move, or remove it, as needed.
            this.soforlerTableAdapter.Fill(this.yurtOtomasyonuDataSet28.Soforler);

        }
    }
}
