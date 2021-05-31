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
    public partial class OdaListe : Form
    {
        public OdaListe()
        {
            InitializeComponent();
        }

        private void OdaListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet22.Odalar' table. You can move, or remove it, as needed.
            this.odalarTableAdapter2.Fill(this.yurtOtomasyonuDataSet22.Odalar);


        }
    }
}
