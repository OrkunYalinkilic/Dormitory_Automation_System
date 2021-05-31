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
    public partial class frmAracServisListe : Form
    {
        public frmAracServisListe()
        {
            InitializeComponent();
        }

        private void frmAracServisListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet29.ServisSaat' table. You can move, or remove it, as needed.
            this.servisSaatTableAdapter.Fill(this.yurtOtomasyonuDataSet29.ServisSaat);

        }
    }
}
