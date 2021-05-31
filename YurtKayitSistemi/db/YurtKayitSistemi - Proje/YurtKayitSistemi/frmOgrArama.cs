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
    public partial class frmOgrArama : Form
    {
        string tip;
        public frmOgrArama(string aramaTipi)
        {
            tip = aramaTipi;
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void frmOgrArama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet14.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet14.Ogrenci);


            if (tip == "idarama")
            {
                label1.Text = " Aramak istediğiniz öğrencinin ID değerini listeden seçiniz.";
                TxtOgrAdSoyad.Enabled = false;
                TxtOgrId.Enabled = true;
                label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                     
            }

            else if (tip == "isimarama")
            {
                label1.Text = " Aramak istediğiniz öğrencinin isimini listeden seçiniz.";
                TxtOgrId.Enabled = false;
                TxtOgrAdSoyad.Enabled = true;
                label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            }

        }

        FrmOgrDuzenle fr = new FrmOgrDuzenle();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndex;
            secilenIndex = dataGridView1.SelectedCells[0].RowIndex;
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
            fr.Controls["BtnGuncelle"].Visible = false;
            fr.Text = "Öğrenci Bilgileri";

            foreach (Control item in fr.Controls)
            {
                if(item is TextBox || item is MaskedTextBox || item is RichTextBox || item is ComboBox)
                {
                    item.Enabled = false;                   
                }
            }
        
            TxtOgrId.Text = dataGridView1.Rows[secilenIndex].Cells[0].Value.ToString();
            TxtOgrAdSoyad.Text = dataGridView1.Rows[secilenIndex].Cells[1].Value.ToString() + " " + dataGridView1.Rows[secilenIndex].Cells[2].Value.ToString();

        }

        private void btnBolumIslem_Click(object sender, EventArgs e)
        {
            fr.ShowDialog();        
            Application.OpenForms["frmOgrArama"].Close();
        }
    }
}
