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
    public partial class frmDuyuruGoruntuleme : Form
    {
        public frmDuyuruGoruntuleme()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void frmDuyuruGoruntuleme_Load(object sender, EventArgs e)
        {
            SqlCommand duyurularıCek = new SqlCommand("select duyuruBaslik from Duyurular", bgl.baglanti());
            SqlDataReader oku = duyurularıCek.ExecuteReader();
            while (oku.Read())
            {
                for (int i = 0; i < oku.FieldCount; i++)
                {
                    Button btn = new Button();
                    btn.BackColor = System.Drawing.Color.Yellow;
                    //btn.Location = new System.Drawing.Point(3, 3);
                    btn.Name = "btnDuyuru"+i;
                    btn.Size = new System.Drawing.Size(268, 53);
                    btn.TabIndex = i;
                    btn.Text = oku[i].ToString().ToUpper();
                    btn.UseVisualStyleBackColor = false;
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
            bgl.baglanti().Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
