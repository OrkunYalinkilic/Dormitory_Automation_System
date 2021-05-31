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
    public partial class frmYemekAylikPlan : Form
    {
        string _ogun;
        public frmYemekAylikPlan(string __ogun)
        {
            _ogun = __ogun;
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmAylikPlanListe frm = new frmAylikPlanListe(_ogun, txtSecilenAy.Text);
            frm.ShowDialog();
        }

        private void frmYemekAylikPlan_Load(object sender, EventArgs e)
        {

        }
    }
}
