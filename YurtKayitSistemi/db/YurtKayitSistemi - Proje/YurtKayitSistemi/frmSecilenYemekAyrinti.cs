using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace YurtKayitSistemi
{
    public partial class frmSecilenYemekAyrinti : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();

        string id;
        Yemekhane secilenYemek = new Yemekhane();
        public frmSecilenYemekAyrinti(string _id)
        {
            id = _id;
            InitializeComponent();
        }

        private void frmSecilenYemekAyrinti_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select *from Yemekhane where YemeklerID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", int.Parse(id));
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                //secilenYemek nesnesinin oluşturulması
                secilenYemek.Yil = oku[0].ToString();
                secilenYemek.ay = oku[1].ToString();
                secilenYemek.gun = oku[2].ToString();
                secilenYemek.ogun = oku[3].ToString();
                secilenYemek.birinci_yemek = oku[4].ToString();
                secilenYemek.ikinci_yemek = oku[5].ToString();
                secilenYemek.ucuncu_yemek = oku[6].ToString();
                secilenYemek.dorduncu_yemek = oku[7].ToString();

                //textboxlarda görüntüleme
                txtYil.Text = secilenYemek.Yil;
                txtAyAdi.Text = secilenYemek.ay;
                txtGunSirasi.Text = secilenYemek.gun;
                txtYemekOgun.Text = secilenYemek.ogun;
                txtBirYemek.Text = secilenYemek.birinci_yemek;
                txtYemekIki.Text = secilenYemek.ikinci_yemek;
                txtYemekUc.Text = secilenYemek.ucuncu_yemek;
                txtYemekDort.Text = secilenYemek.dorduncu_yemek;

            }
            bgl.baglanti().Close();
        }
    }
}
