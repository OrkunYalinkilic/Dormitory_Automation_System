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
    public partial class frmOdaArama : Form
    {
        public frmOdaArama()
        {
            InitializeComponent();
        }

        private void btnOdaAra_Click(object sender, EventArgs e)
        {
            frmOdaIslem frm = new frmOdaIslem("arama", txtArananOda.Text);
            frm.ShowDialog();
        }

        private void frmOdaArama_Load(object sender, EventArgs e)
        {

        }
    }
}
